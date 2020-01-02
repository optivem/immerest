﻿using AutoMapper;
using Optivem.Framework.Core.Domain;
using Optivem.Template.Core.Application.Customers.Queries;
using Optivem.Template.Core.Domain.Customers;

namespace Optivem.Template.Infrastructure.Mapping.Customers
{
    public class BrowseCustomersQueryResponseProfile : Profile
    {
        public BrowseCustomersQueryResponseProfile()
        {
            CreateMap<PageReadModel<CustomerHeaderReadModel>, BrowseCustomersQueryResponse>()
                .ForMember(dest => dest.Records, opt => opt.MapFrom(e => e.Records))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(e => e.TotalRecords));

            CreateMap<CustomerHeaderReadModel, BrowseCustomersRecordResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.CustomerId));
        }
    }
}