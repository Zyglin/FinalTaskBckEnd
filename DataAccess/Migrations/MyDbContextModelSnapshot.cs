﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebFilms.DataAccess;

namespace DataAccess.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.DataAccess.Entity.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FilmId");

                    b.Property<Guid>("UserId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("WebFilms.DataAccess.Entity.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(160);

                    b.Property<Guid>("FilmId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebFilms.DataAccess.Entity.Film", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("GenreId");

                    b.Property<string>("ImageXPath")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(85);

                    b.Property<string>("YoutubeId");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Films");

                    b.HasData(
                        new { Id = new Guid("9579ad12-3439-435a-9673-9b82e41b2de0"), Description = "The surviving Resistance faces the First Order once more in the final chapter of the Skywalker saga.", GenreId = 3, ImageXPath = "https://m.media-amazon.com/images/M/MV5BZWU1NDI3YjEtZTlmMy00Y2FmLWI1ZDYtMjYwNDUxYTdlODllXkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SY1000_CR0,0,675,1000_AL_.jpg", Name = "Star Wars", YoutubeId = "Q1qZ6oLV3hg" },
                        new { Id = new Guid("cc51a9e2-3e0b-45ea-b0f1-7b557dc04da3"), Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.", GenreId = 1, ImageXPath = "https://m.media-amazon.com/images/M/MV5BMTUxMzQyNjA5MF5BMl5BanBnXkFtZTYwOTU2NTY3._V1_.jpg", Name = "The Green Mile", YoutubeId = "CmxArNBJHFQ" },
                        new { Id = new Guid("79133b5b-abf2-4d88-86aa-1065e430716e"), Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", GenreId = 1, ImageXPath = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg", Name = "The Shawshank Redemption", YoutubeId = "6hB3S9bIaco" },
                        new { Id = new Guid("be44635a-ec22-4f43-93ab-3c0809855a28"), Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", GenreId = 1, ImageXPath = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,686,1000_AL_.jpg", Name = "Pulp Fiction", YoutubeId = "Y6YBKdmOlM8" },
                        new { Id = new Guid("cb821af7-a7f3-4949-a1e9-0ac3d483e316"), Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", GenreId = 1, ImageXPath = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,704,1000_AL_.jpg", Name = "The GodFather", YoutubeId = "sY1S34973zA" },
                        new { Id = new Guid("a70e815f-f4c0-4cac-b2f7-a50f1c180e1f"), Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", GenreId = 3, ImageXPath = "https://m.media-amazon.com/images/M/MV5BNGE5MzIyNTAtNWFlMC00NDA2LWJiMjItMjc4Yjg1OWM5NzhhXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,684,1000_AL_.jpg", Name = "The Lord of the Rings", YoutubeId = "r5X-hFf6Bwo" }
                    );
                });

            modelBuilder.Entity("WebFilms.DataAccess.Entity.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(85);

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new { GenreId = 1, Name = "Action" },
                        new { GenreId = 2, Name = "Drama" },
                        new { GenreId = 3, Name = "Comedy" },
                        new { GenreId = 4, Name = "Adventure" },
                        new { GenreId = 5, Name = "Documentaly" },
                        new { GenreId = 6, Name = "Horror" },
                        new { GenreId = 7, Name = "Romance" }
                    );
                });

            modelBuilder.Entity("WebFilms.DataAccess.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(85);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(85);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(85);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = new Guid("b5d8ca58-9a43-483f-b335-bfa35f220bc7"), Email = "zyglin@mail.ru", PasswordHash = "15000|1KCtkVnuuQyjfCTS|GSKMUwFtkcsyzri0KM+QhVWexTZx3XTIu7FvlhWvg7Y=" }
                    );
                });

            modelBuilder.Entity("DataAccess.DataAccess.Entity.Rating", b =>
                {
                    b.HasOne("WebFilms.DataAccess.Entity.Film", "Film")
                        .WithMany("Ratings")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebFilms.DataAccess.Entity.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebFilms.DataAccess.Entity.Comment", b =>
                {
                    b.HasOne("WebFilms.DataAccess.Entity.Film", "Film")
                        .WithMany("Comments")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebFilms.DataAccess.Entity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebFilms.DataAccess.Entity.Film", b =>
                {
                    b.HasOne("WebFilms.DataAccess.Entity.Genre", "Genre")
                        .WithMany("Films")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
