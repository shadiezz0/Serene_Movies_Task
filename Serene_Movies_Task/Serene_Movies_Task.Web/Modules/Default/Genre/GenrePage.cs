using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Serene_Movies_Task.Default.Pages;

[PageAuthorize(typeof(GenreRow))]
public class GenrePage : Controller
{
    [Route("Default/Genre")]
    public ActionResult Index()
    {
        return this.GridPage("@/Default/Genre/GenrePage",
            GenreRow.Fields.PageTitle());
    }
}