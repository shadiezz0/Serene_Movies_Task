using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serene_Movies_Task.Default.MovieRow>;
using MyRow = Serene_Movies_Task.Default.MovieRow;

namespace Serene_Movies_Task.Default;

public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    public MovieListHandler(IRequestContext context)
            : base(context)
    {
    }
}