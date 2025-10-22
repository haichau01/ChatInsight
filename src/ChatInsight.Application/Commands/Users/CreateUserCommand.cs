using ChatInsight.Application.DTOs;
using MediatR;

namespace ChatInsight.Application.Commands.Users
{

    namespace ChatInsight.Core.Application.Commands.Users
    {
        // Command nhận dữ liệu tạo User
        public record CreateUserCommand(string DisplayName, string Email) : IRequest<UserDTO>;
    }
}
