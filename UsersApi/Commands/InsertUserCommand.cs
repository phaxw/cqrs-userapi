using MediatR;
using UsersApi.Dtos;

namespace UsersApi.Commands
{
    public class InsertUserCommand : IRequest<User>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public InsertUserCommand(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}