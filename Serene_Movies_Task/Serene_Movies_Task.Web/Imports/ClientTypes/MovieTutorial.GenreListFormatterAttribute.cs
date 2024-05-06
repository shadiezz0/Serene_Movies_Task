using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieTutorial;

public partial class GenreListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "MovieTutorial.GenreListFormatter";

    public GenreListFormatterAttribute()
        : base(Key)
    {
    }
}