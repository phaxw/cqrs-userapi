using System.Collections.Generic;
using MediatR;
using UsersApi.Dtos;

namespace UsersApi.Queries
{
    public class GetAllUsersQuery : IRequest<List<User>>
    {
        
    }
}