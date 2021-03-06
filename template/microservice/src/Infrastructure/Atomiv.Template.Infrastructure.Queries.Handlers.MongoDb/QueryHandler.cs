﻿using Atomiv.Core.Application;
using Atomiv.Infrastructure.MongoDB;
using Atomiv.Template.Infrastructure.Domain.Persistence.MongoDB;

namespace Atomiv.Template.Infrastructure.Queries.Handlers.MongoDB
{
    public abstract class QueryHandler<TQuery, TResponse> : QueryHandler<DatabaseContext, TQuery, TResponse>
        where TQuery : IQuery<TResponse>
    {
        public QueryHandler(DatabaseContext context) : base(context)
        {
        }
    }
}
