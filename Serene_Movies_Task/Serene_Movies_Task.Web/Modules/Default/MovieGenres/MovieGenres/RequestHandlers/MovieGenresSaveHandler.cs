using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Serene_Movies_Task.Default.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene_Movies_Task.Default.MovieGenresRow;

namespace Serene_Movies_Task.Default;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
{
    public MovieGenresSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}