﻿using Collectively.Common.Services;
using Collectively.Messages.Events.Remarks;
using Collectively.Services.Statistics.Repositories;
using Collectively.Common.ServiceClients;

namespace Collectively.Services.Statistics.Handlers
{
    public class RemarkCanceledHandler : RemarkStateChangedBaseHandler<RemarkCanceled>
    {
        public RemarkCanceledHandler(IHandler handler, 
            IRemarkStatisticsRepository remarkStatisticsRepository,
            IUserStatisticsRepository userStatisticsRepository,
            ICategoryStatisticsRepository categoryStatisticsRepository,
            ITagStatisticsRepository tagStatisticsRepository,
            IServiceClient serviceClient) : 
                base(handler, remarkStatisticsRepository, 
                    userStatisticsRepository, categoryStatisticsRepository, 
                    tagStatisticsRepository, serviceClient)
        {
            Setup(x => { x.Remarks.IncreaseCanceled(); x.Remarks.DecreaseNew(); }, 
                  x => { x.Remarks.IncreaseCanceled(); x.Remarks.DecreaseNew(); }, 
                  x => { x.Remarks.IncreaseCanceled(); x.Remarks.DecreaseNew(); });
        }
    }
}