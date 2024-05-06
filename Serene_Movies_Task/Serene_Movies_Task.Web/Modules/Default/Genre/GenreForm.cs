using Serenity.ComponentModel;

namespace Serene_Movies_Task.Default.Forms;

[FormScript("Default.Genre")]
[BasedOnRow(typeof(GenreRow), CheckNames = true)]
public class GenreForm
{
    public string Name { get; set; }
}