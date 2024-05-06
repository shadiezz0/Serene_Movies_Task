using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<Serene_Movies_Task.Default.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene_Movies_Task.Default.GenreRow;

namespace Serene_Movies_Task.Default;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}