﻿using Atomiv.Core.Application;
using System.Collections.Generic;

namespace Generator.Core.Application.Orders.Responses
{
    public class BrowseOrdersResponse : ICollectionResponse<BrowseOrdersRecordResponse, int>
    {
        public List<BrowseOrdersRecordResponse> Records { get; set; }

        public int Count { get; set; }
    }

    public class BrowseOrdersRecordResponse : IResponse<int>
    {
        public int Id { get; set; }
    }
}
