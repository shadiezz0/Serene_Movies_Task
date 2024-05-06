using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serene_Movies_Task.Default.MovieGenresRow>;
using MyRow = Serene_Movies_Task.Default.MovieGenresRow;

namespace Serene_Movies_Task.Default;

public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresRetrieveHandler
{
    public MovieGenresRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}