using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serene_Movies_Task.Default.MovieGenresRow>;
using MyRow = Serene_Movies_Task.Default.MovieGenresRow;

namespace Serene_Movies_Task.Default;

public interface IMovieGenresListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresListHandler
{
    public MovieGenresListHandler(IRequestContext context)
            : base(context)
    {
    }
}