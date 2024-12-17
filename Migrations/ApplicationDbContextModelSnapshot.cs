﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.API.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MovieApp.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid")
                        .HasColumnName("movie_id");

                    b.Property<string>("Text")
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("Favorite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid")
                        .HasColumnName("movie_id");

                    b.Property<string>("Note")
                        .HasColumnType("text")
                        .HasColumnName("note");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("favorites");
                });

            modelBuilder.Entity("MovieApp.API.Models.GenreModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("MovieApp.API.Models.MovieModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("Audience")
                        .HasColumnType("integer")
                        .HasColumnName("audience");

                    b.Property<string>("DateCreated")
                        .HasColumnType("text")
                        .HasColumnName("date_created");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid")
                        .HasColumnName("genre_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Picture")
                        .HasColumnType("text")
                        .HasColumnName("picture");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric")
                        .HasColumnName("rating");

                    b.Property<Guid>("SubGenreId")
                        .HasColumnType("uuid")
                        .HasColumnName("sub_genre_id");

                    b.Property<string>("VideoFilePath")
                        .HasColumnType("text")
                        .HasColumnName("video_file_path");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("SubGenreId");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("MovieApp.API.Models.SubGenreModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid")
                        .HasColumnName("genre_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("sub_genres");
                });

            modelBuilder.Entity("MovieApp.API.Models.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("text")
                        .HasColumnName("facebook_link");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("InstagramLink")
                        .HasColumnType("text")
                        .HasColumnName("instagram_link");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("LinkedInLink")
                        .HasColumnType("text")
                        .HasColumnName("linked_in_link");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea")
                        .HasColumnName("password_salt");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("profile_image_url");

                    b.Property<string>("Role")
                        .HasColumnType("text")
                        .HasColumnName("role");

                    b.Property<string>("TwitterLink")
                        .HasColumnType("text")
                        .HasColumnName("twitter_link");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.HasOne("MovieApp.API.Models.MovieModel", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieApp.API.Models.UserModel", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Favorite", b =>
                {
                    b.HasOne("MovieApp.API.Models.MovieModel", "Movie")
                        .WithMany("Favorites")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieApp.API.Models.MovieModel", b =>
                {
                    b.HasOne("MovieApp.API.Models.GenreModel", "Genres")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieApp.API.Models.SubGenreModel", "SubGenres")
                        .WithMany()
                        .HasForeignKey("SubGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");

                    b.Navigation("SubGenres");
                });

            modelBuilder.Entity("MovieApp.API.Models.SubGenreModel", b =>
                {
                    b.HasOne("MovieApp.API.Models.GenreModel", "Genres")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("MovieApp.API.Models.MovieModel", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("MovieApp.API.Models.UserModel", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
