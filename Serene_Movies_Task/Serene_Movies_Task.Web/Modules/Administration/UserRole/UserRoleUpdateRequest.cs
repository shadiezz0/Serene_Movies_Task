namespace Serene_Movies_Task.Administration;

public class UserRoleUpdateRequest : ServiceRequest
{
    public int? UserID { get; set; }
    public List<int> Roles { get; set; }
}