using Serenity.Navigation;
using MyPages = Serene_Movies_Task.Default.Pages;

[assembly: NavigationMenu(1000, "Movies Database", icon: null)]
[assembly: NavigationLink(1001, "Movies Database/Movie", typeof(MyPages.MoviePage), icon: null)]
[assembly: NavigationLink(1002, "Movies Database/Genre", typeof(MyPages.GenrePage), icon: null)]