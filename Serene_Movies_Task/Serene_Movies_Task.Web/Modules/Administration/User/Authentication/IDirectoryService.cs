
namespace Serene_Movies_Task;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}