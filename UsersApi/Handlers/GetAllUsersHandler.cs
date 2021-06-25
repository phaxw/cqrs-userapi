using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UsersApi.DataAccess;
using UsersApi.Dtos;
using UsersApi.Queries;

namespace UsersApi.Handlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private IDataAccess _dataAccess;
        public GetAllUsersHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetUsers());
        }
    }
}