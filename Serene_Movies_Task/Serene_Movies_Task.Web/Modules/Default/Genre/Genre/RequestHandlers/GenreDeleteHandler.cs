using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serene_Movies_Task.Default.GenreRow;

namespace Serene_Movies_Task.Default;

public interface IGenreDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class GenreDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGenreDeleteHandler
{
    public GenreDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}