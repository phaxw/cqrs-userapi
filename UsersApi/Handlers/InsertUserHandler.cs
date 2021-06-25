using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UsersApi.Commands;
using UsersApi.DataAccess;
using UsersApi.Dtos;

namespace UsersApi.Handlers
{
    public class InsertUserHandler : IRequestHandler<InsertUserCommand, User>
    {
        private IDataAccess _dataAccess;
        
        public InsertUserHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        
        public Task<User> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertUser(request.Name, request.Email));
        }
    }
}