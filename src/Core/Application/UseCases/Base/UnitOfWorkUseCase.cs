﻿using Optivem.Framework.Core.Application.Mappers;
using Optivem.Framework.Core.Domain;
using System.Threading.Tasks;

namespace Optivem.Framework.Core.Application
{
    public abstract class UnitOfWorkUseCase<TRepository, TRequest, TResponse> 
        : IUseCase<TRequest, TResponse>
        where TRepository : IRepository
        where TRequest : IRequest
        where TResponse : IResponse
    {
        public UnitOfWorkUseCase(IUseCaseMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        public abstract Task<TResponse> HandleAsync(TRequest request);

        protected IUseCaseMapper Mapper { get; set; }

        protected IUnitOfWork UnitOfWork { get; }

        protected TRepository GetRepository()
        {
            return UnitOfWork.GetRepository<TRepository>();
        }
    }

}
