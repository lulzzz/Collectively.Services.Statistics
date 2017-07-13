﻿using System.Threading.Tasks;
using Collectively.Common.Types;
using Collectively.Services.Statistics.Domain;
using Collectively.Services.Statistics.Queries;

namespace Collectively.Services.Statistics.Repositories
{
    public interface ITagStatisticsRepository
    {
        Task<Maybe<PagedResult<TagStatistics>>> BrowseAsync(BrowseTagStatistics query);
        Task<Maybe<TagStatistics>> GetByNameAsync(string name);
        Task AddOrUpdateAsync(TagStatistics statistics);
    }
}