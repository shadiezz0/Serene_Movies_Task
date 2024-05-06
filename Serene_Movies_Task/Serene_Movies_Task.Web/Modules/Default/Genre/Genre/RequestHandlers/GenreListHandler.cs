using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serene_Movies_Task.Default.GenreRow>;
using MyRow = Serene_Movies_Task.Default.GenreRow;

namespace Serene_Movies_Task.Default;

public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
{
    public GenreListHandler(IRequestContext context)
            : base(context)
    {
    }
}