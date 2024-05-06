using Serenity.ComponentModel;
using System;

namespace Serene_Movies_Task.Default.Forms;

[FormScript("Default.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieForm
{
    public string Title { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
    [TextAreaEditor(Rows = 8)]
    public string Storyline { get; set; }
    public int Year { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Runtime { get; set; }
    public List<int> GenreList { get; set; }
    public MovieKind Kind { get; set; }

}