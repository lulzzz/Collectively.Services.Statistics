﻿using System.Threading.Tasks;
using Collectively.Common.Mongo;
using Collectively.Services.Statistics.Domain;
using Collectively.Services.Statistics.Queries;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Collectively.Services.Statistics.Repositories.Queries
{
    public static class TagStatisticsQueries
    {
        public static IMongoCollection<TagStatistics> TagStatistics(this IMongoDatabase database)
            => database.GetCollection<TagStatistics>();

        public static async Task<TagStatistics> GetByNameAsync(
            this IMongoCollection<TagStatistics> collection, string name)
        {
            return await collection.FirstOrDefaultAsync(x => x.Name == name);
        }

        public static async Task AddOrUpdateAsync(this IMongoCollection<TagStatistics> collection,
            TagStatistics statistics)
        {
            await collection.ReplaceOneAsync(x => x.Name == statistics.Name, statistics, new UpdateOptions
            {
                IsUpsert = true
            });
        }

        public static IMongoQueryable<TagStatistics> Query(
            this IMongoCollection<TagStatistics> collection,
            BrowseTagStatistics query)
        {
            var values = collection
                .AsQueryable()
                .OrderByDescending(x => x.Remarks.ReportedCount);

            return values;
        }
    }
}