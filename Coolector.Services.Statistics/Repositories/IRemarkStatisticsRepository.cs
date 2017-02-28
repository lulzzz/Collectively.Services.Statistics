using System;
using System.Threading.Tasks;
using Coolector.Common.Types;
using Coolector.Services.Statistics.Domain;
using Coolector.Services.Statistics.Queries;

namespace Coolector.Services.Statistics.Repositories
{
    public interface IRemarkStatisticsRepository
    {
        Task<Maybe<PagedResult<RemarkStatistics>>> BrowseAsync(BrowseRemarkStatistics query);
        Task<Maybe<RemarkStatistics>> GetAsync(Guid remarkId);
        Task<Maybe<RemarksCountStatistics>> GetGeneralStatisticsAsync(GetRemarkGeneralStatistics query);
        Task AddOrUpdateAsync(RemarkStatistics statistics);
        Task<Maybe<PagedResult<Vote>>> BrowseVotesAsync(BrowseRemarkVotes query);
        Task AddVoteAsync(Vote vote);
    }
}