using System;

namespace Coolector.Services.Statistics.Shared.Dto
{
    public class VoteDto
    {
        public string UserId { get; set; }
        public Guid RemarkId { get; set; }
        public bool Positive { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}