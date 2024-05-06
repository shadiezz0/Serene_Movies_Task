using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace Serene_Movies_Task.Default;

[ConnectionKey("Default"), Module("Default"), TableName("Movie")]
[DisplayName("Movies"), InstanceName("Movie")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Movie Id"), Identity, IdProperty]
    public int? MovieId { get => fields.MovieId[this]; set => fields.MovieId[this] = value; }

    [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(1000) , QuickSearch]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Storyline") , QuickSearch]
    public string Storyline { get => fields.Storyline[this]; set => fields.Storyline[this] = value; }

    [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
    public int? Year { get => fields.Year[this]; set => fields.Year[this] = value; }

    [DisplayName("Release Date")]
    public DateTime? ReleaseDate { get => fields.ReleaseDate[this]; set => fields.ReleaseDate[this] = value; }

    [DisplayName("Runtime")]
    public int? Runtime { get => fields.Runtime[this]; set => fields.Runtime[this] = value; }



    [DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
    public MovieKind? Kind { get => fields.Kind[this]; set => fields.Kind[this] = value; }


    [DisplayName("Genres"), LookupEditor(typeof(GenreRow), Multiple = true), NotMapped]
    [LinkingSetRelation(typeof(MovieGenresRow), nameof(MovieGenresRow.MovieId), nameof(MovieGenresRow.GenreId))]
    public List<int> GenreList { get => fields.GenreList[this]; set => fields.GenreList[this] = value; }


    public class RowFields : RowFieldsBase
    {
        public Int32Field MovieId;
        public StringField Title;
        public StringField Description;
        public StringField Storyline;
        public Int32Field Year;
        public DateTimeField ReleaseDate;
        public Int32Field Runtime;
        public EnumField<MovieKind> Kind;
        public ListField<int> GenreList;
    }
}