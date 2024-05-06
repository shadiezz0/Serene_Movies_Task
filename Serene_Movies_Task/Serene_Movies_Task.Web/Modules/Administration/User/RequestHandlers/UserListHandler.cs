using MyRequest = Serene_Movies_Task.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Serene_Movies_Task.Administration.UserRow>;
using MyRow = Serene_Movies_Task.Administration.UserRow;

namespace Serene_Movies_Task.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}