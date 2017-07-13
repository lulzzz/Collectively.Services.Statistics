﻿using System;
using System.Collections.Generic;
using Collectively.Common.Extensions;

namespace Collectively.Services.Statistics.Domain
{
    public class UserStatistics
    {
        private ISet<Vote> _votes = new HashSet<Vote>();
        public string UserId { get; protected set; }
        public string Name { get; protected set; }
        public RemarksCountStatistics Remarks { get; protected set; }

        public IEnumerable<Vote> Votes
        {
            get { return _votes; }
            protected set { _votes = new HashSet<Vote>(value); }
        }

        protected UserStatistics() { }

        public UserStatistics(string userId, string name, RemarksCountStatistics remarks = null)
        {
            if (userId.Empty())
            {
                throw new ArgumentException("User id can not be empty.", nameof(name));
            }
            if (name.Empty())
            {
                throw new ArgumentException("User name can not be empty.", nameof(name));
            }
            UserId = userId;
            Name = name;
            Remarks = remarks ?? new RemarksCountStatistics();
        }

        public void AddVote(Vote vote)
        {
            _votes.Add(vote);
        }
    }
}