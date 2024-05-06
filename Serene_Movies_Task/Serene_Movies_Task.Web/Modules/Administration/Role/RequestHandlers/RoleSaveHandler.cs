using MyRequest = Serenity.Services.SaveRequest<Serene_Movies_Task.Administration.RoleRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene_Movies_Task.Administration.RoleRow;

namespace Serene_Movies_Task.Administration;
public interface IRoleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
{
    public RoleSaveHandler(IRequestContext context)
         : base(context)
    {
    }

    protected override void InvalidateCacheOnCommit()
    {
        base.InvalidateCacheOnCommit();

        Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
        Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
    }
}