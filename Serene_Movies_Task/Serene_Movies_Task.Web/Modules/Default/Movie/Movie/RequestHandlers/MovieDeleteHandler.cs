using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serene_Movies_Task.Default.MovieRow;

namespace Serene_Movies_Task.Default;

public interface IMovieDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MovieDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieDeleteHandler
{
    public MovieDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}