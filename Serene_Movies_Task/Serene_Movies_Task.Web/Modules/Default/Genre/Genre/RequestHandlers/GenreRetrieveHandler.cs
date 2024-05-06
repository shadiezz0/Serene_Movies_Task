using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serene_Movies_Task.Default.GenreRow>;
using MyRow = Serene_Movies_Task.Default.GenreRow;

namespace Serene_Movies_Task.Default;

public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreRetrieveHandler
{
    public GenreRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}