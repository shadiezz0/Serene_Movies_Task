using Newtonsoft.Json;

namespace Serene_Movies_Task.Administration;
public class RolePermissionUpdateRequest : ServiceRequest
{
    public int? RoleID { get; set; }
    public List<string> Permissions { get; set; }
}