﻿using AutoMapper;
using Coolector.Services.Statistics.Domain;
using Coolector.Services.Statistics.Shared.Dto;

namespace Coolector.Services.Statistics.Framework
{
    public class AutoMapperConfig
    {
        public static IMapper InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Location, LocationDto>();
                cfg.CreateMap<Vote, VoteDto>();
                cfg.CreateMap<RemarkState, RemarkStateDto>();
                cfg.CreateMap<RemarksCountStatistics, RemarksCountStatisticsDto>();
                cfg.CreateMap<RemarkStatistics, RemarkStatisticsDto>();
                cfg.CreateMap<UserStatistics, UserStatisticsDto>();
                cfg.CreateMap<CategoryStatistics, CategoryStatisticsDto>();
                cfg.CreateMap<TagStatistics, TagStatisticsDto>();
            });

            return config.CreateMapper();
        }
    }
}