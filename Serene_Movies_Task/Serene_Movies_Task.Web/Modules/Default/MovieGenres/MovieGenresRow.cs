using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace Serene_Movies_Task.Default;

[ConnectionKey("Default"), Module("Default"), TableName("MovieGenres")]
[DisplayName("Movie Genres"), InstanceName("Movie Genres")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class MovieGenresRow : Row<MovieGenresRow.RowFields>, IIdRow
{
    const string jMovie = nameof(jMovie);
    const string jGenre = nameof(jGenre);

    [DisplayName("Movie Genre Id"), Identity, IdProperty]
    public int? MovieGenreId { get => fields.MovieGenreId[this]; set => fields.MovieGenreId[this] = value; }

    [DisplayName("Movie"), NotNull, ForeignKey(typeof(MovieRow)), LeftJoin(jMovie), TextualField(nameof(MovieTitle))]
    [ServiceLookupEditor(typeof(MovieRow), Service = "Default/Movie/List")]
    public int? MovieId { get => fields.MovieId[this]; set => fields.MovieId[this] = value; }

    [DisplayName("Genre"), NotNull, ForeignKey(typeof(GenreRow)), LeftJoin(jGenre), TextualField(nameof(GenreName))]
    [LookupEditor(typeof(GenreRow), Async = true)]
    public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }

    [DisplayName("Movie Title"), Origin(jMovie, nameof(MovieRow.Title))]
    public string MovieTitle { get => fields.MovieTitle[this]; set => fields.MovieTitle[this] = value; }

    [DisplayName("Genre Name"), Origin(jGenre, nameof(GenreRow.Name))]
    public string GenreName { get => fields.GenreName[this]; set => fields.GenreName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field MovieGenreId;
        public Int32Field MovieId;
        public Int32Field GenreId;

        public StringField MovieTitle;
        public StringField GenreName;
    }
}