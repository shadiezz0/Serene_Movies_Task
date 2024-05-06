import { fieldsProxy } from "@serenity-is/corelib";

export interface MovieGenresRow {
    MovieGenreId?: number;
    MovieId?: number;
    GenreId?: number;
    MovieTitle?: string;
    GenreName?: string;
}

export abstract class MovieGenresRow {
    static readonly idProperty = 'MovieGenreId';
    static readonly localTextPrefix = 'Default.MovieGenres';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MovieGenresRow>();
}