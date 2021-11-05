﻿namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Movies.AddOrUpdate(i=>i.Title,
                
                new Movie{
                    Title="when Harry Met Sally",
                    ReleaseDate=DateTime.Parse("1989-1-11"),
                    Genre="Romantic Comedy",
                    Rating = "PG",
                    Price=7.99M

                },
               new Movie
                  {
                Title="Ghostbusters",
                ReleaseDate=DateTime.Parse("1984-3-13"),
                Genre="Comedy",
                Rating = "PG",
                Price=8.99M
            },
            new Movie
            {
                Title="Ghostbuster 2",
                ReleaseDate=DateTime.Parse("1986-2-23"),
                Genre="Comedy",
                Rating = "PG",
                Price=9.99M
            },
            new Movie
            {
                Title="Rio Bravo",
                ReleaseDate=DateTime.Parse("1969-4-15"),
                Genre="Wastern",
                Rating = "PG",
                Price=3.99M
            }
            );
        }
    }
}