using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UsersApi.DataAccess;
using UsersApi.Dtos;
using UsersApi.Queries;

namespace UsersApi.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private IDataAccess _dataAccess;

        public GetUserByIdHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_dataAccess.GetUserById(request.UserId));
        }
    }
}