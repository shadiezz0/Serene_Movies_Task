using Microsoft.AspNetCore.Hosting;
using MyRepository = Serene_Movies_Task.Administration.Repositories.TranslationRepository;

namespace Serene_Movies_Task.Administration.Endpoints;
[Route("Services/Administration/Translation/[action]")]
[ServiceAuthorize(PermissionKeys.Translation)]
public class TranslationEndpoint : ServiceEndpoint
{
    protected IWebHostEnvironment HostEnvironment { get; }
    protected ILocalTextRegistry LocalTextRegistry { get; }
    protected ITypeSource TypeSource { get; }

    public TranslationEndpoint(IWebHostEnvironment hostEnvironment,
        ILocalTextRegistry localTextRegistry, ITypeSource typeSource)
    {
        HostEnvironment = hostEnvironment ?? throw new ArgumentNullException(nameof(hostEnvironment));
        LocalTextRegistry = localTextRegistry ?? throw new ArgumentNullException(nameof(localTextRegistry));
        TypeSource = typeSource ?? throw new ArgumentNullException(nameof(typeSource));
    }

    private MyRepository NewRepository()
    {
        return new MyRepository(Context, HostEnvironment, LocalTextRegistry, TypeSource);
    }

    public ListResponse<TranslationItem> List(TranslationListRequest request)
    {
        return NewRepository().List(request);
    }

    [HttpPost]
    public SaveResponse Update(TranslationUpdateRequest request)
    {
        return NewRepository().Update(request, HttpContext.RequestServices);
    }
}