using MediatR;
using UsersApi.Dtos;

namespace UsersApi.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int UserId { get; set; }

        public GetUserByIdQuery(int id)
        {
            UserId = id;
        }
    }
}