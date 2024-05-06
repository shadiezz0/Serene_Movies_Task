using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serene_Movies_Task.Default.MovieGenresRow;

namespace Serene_Movies_Task.Default;

public interface IMovieGenresDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresDeleteHandler
{
    public MovieGenresDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}