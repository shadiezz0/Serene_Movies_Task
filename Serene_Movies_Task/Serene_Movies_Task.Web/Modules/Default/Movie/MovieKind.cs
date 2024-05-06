using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Serene_Movies_Task.Default;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film = 1,
    [Description("TV Series")]
    TvSeries = 2,
    [Description("Mini Series")]
    MiniSeries = 3
}