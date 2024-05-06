using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Serene_Movies_Task.Default.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene_Movies_Task.Default.MovieRow;

namespace Serene_Movies_Task.Default;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}