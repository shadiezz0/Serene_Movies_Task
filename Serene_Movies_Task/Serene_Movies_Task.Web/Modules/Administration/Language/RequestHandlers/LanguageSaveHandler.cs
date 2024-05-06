using MyRequest = Serenity.Services.SaveRequest<Serene_Movies_Task.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene_Movies_Task.Administration.LanguageRow;


namespace Serene_Movies_Task.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}