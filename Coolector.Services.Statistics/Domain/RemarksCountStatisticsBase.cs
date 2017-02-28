﻿using Coolector.Common.Domain;

namespace Coolector.Services.Statistics.Domain
{
    public abstract class RemarksCountStatisticsBase : Entity
    {
        public int NewCount { get; protected set; }
        public int ReportedCount { get; protected set; }
        public int ProcessingCount { get; protected set; }
        public int ResolvedCount { get; protected set; }
        public int CanceledCount { get; protected set; }
        public int DeletedCount { get; protected set; }
        public int RenewedCount { get; protected set; }

        protected RemarksCountStatisticsBase() { }

        protected RemarksCountStatisticsBase(int @new = 0, int reported = 0, 
                int processing = 0, int resolved = 0, int canceled = 0, 
                int deleted = 0, int renewed = 0)
        {
            NewCount = @new;
            ReportedCount = reported;
            ProcessingCount = processing;
            ResolvedCount = resolved;
            CanceledCount = canceled;
            DeletedCount = deleted;
            RenewedCount = renewed;
        }

        public virtual void IncreaseNew()
        {
            NewCount++;
        }

        public virtual void IncreaseReported()
        {
            ReportedCount++;
        }

        public virtual void IncreaseProcessing()
        {
            ProcessingCount++;
        }

        public virtual void IncreaseResolved()
        {
            ResolvedCount++;
        }

        public virtual void IncreaseCanceled()
        {
            CanceledCount++;
        }

        public virtual void IncreaseDeleted()
        {
            DeletedCount++;
        }

        public virtual void IncreaseRenewed()
        {
            RenewedCount++;
        }
    }
}