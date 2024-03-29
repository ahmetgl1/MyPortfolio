﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPortfolioServer.Context;

#nullable disable

namespace MyPortfolioServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240108093422_init7")]
    partial class init7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyPortfolioServer.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<short>("Duration")
                        .HasColumnType("smallint");

                    b.Property<string>("PostURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İmageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.BlogTag", b =>
                {
                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("BlogId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("BlogTags");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.Technology", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Technologies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97146b8b-f05d-4110-be17-e145079125b6"),
                            Name = ".NET",
                            Status = "Backend",
                            URL = "NET_Core_Logo.svg.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("aa7d6511-c50f-414d-b56d-e68842bac704"),
                            Name = "MSSQL",
                            Status = "Database",
                            URL = "mssql.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("575c3152-181a-401c-81ef-71307ba0ef7a"),
                            Name = "Angular",
                            Status = "Frontend",
                            URL = "angular.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("abdd39a8-c930-43ed-bc9d-9daea1159f3f"),
                            Name = "MongoDB",
                            Status = "Database",
                            URL = "mongo.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("fd8815cb-9b57-44c7-a238-91c249d6ebe0"),
                            Name = "TypeScript",
                            Status = "Frontend",
                            URL = "typescript.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("863e6d58-70fa-4c0c-b0d1-998df7464ffd"),
                            Name = "JavaScript",
                            Status = "Frontend",
                            URL = "javascript.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("e5818e59-27ee-41df-9b0d-1872676dda4c"),
                            Name = "HTML",
                            Status = "Frontend",
                            URL = "html.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("25f5b4ba-857a-47d2-b34f-1e92fadbcdcb"),
                            Name = "CSS",
                            Status = "Frontend",
                            URL = "css.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        });
                });

            modelBuilder.Entity("MyPortfolioServer.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.UserDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.BlogTag", b =>
                {
                    b.HasOne("MyPortfolioServer.Models.Blog", "Blog")
                        .WithMany("BlogTags")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyPortfolioServer.Models.Tag", "Tag")
                        .WithMany("BlogTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.UserDetail", b =>
                {
                    b.HasOne("MyPortfolioServer.Models.User", null)
                        .WithOne("UserDetail")
                        .HasForeignKey("MyPortfolioServer.Models.UserDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyPortfolioServer.Models.Blog", b =>
                {
                    b.Navigation("BlogTags");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.Tag", b =>
                {
                    b.Navigation("BlogTags");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.User", b =>
                {
                    b.Navigation("UserDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
