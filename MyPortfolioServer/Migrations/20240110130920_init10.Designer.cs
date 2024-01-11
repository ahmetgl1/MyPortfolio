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
    [Migration("20240110130920_init10")]
    partial class init10
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

            modelBuilder.Entity("MyPortfolioServer.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
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
                            Id = new Guid("97a08611-9a6d-4ec9-ba8c-2e190af3846e"),
                            Name = ".NET",
                            Status = "Backend",
                            URL = "NET_Core_Logo.svg.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("ce7400b1-0d44-46fb-938a-f55368db78d5"),
                            Name = "MSSQL",
                            Status = "Database",
                            URL = "mssql.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("efc95eef-6d85-4375-afaf-a8f9d1555715"),
                            Name = "Angular",
                            Status = "Frontend",
                            URL = "angular.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("ea0b3b2c-69b2-48d8-b361-4464d5c7ef23"),
                            Name = "MongoDB",
                            Status = "Database",
                            URL = "mongo.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("e20c1e8f-52b8-44b3-ae72-0e3d02b381fa"),
                            Name = "TypeScript",
                            Status = "Frontend",
                            URL = "typescript.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("84412608-2bb9-479e-a180-4cda25b61834"),
                            Name = "JavaScript",
                            Status = "Frontend",
                            URL = "javascript.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("3102f8f6-d0b7-45bb-84e0-9e3ec6e20596"),
                            Name = "HTML",
                            Status = "Frontend",
                            URL = "html.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        },
                        new
                        {
                            Id = new Guid("40de2973-ed5b-4cbb-a8fb-50ad7c8dcf2b"),
                            Name = "CSS",
                            Status = "Frontend",
                            URL = "css.png",
                            UserId = new Guid("9d06cf48-edca-4d1d-8f24-6539390b0d1b")
                        });
                });

            modelBuilder.Entity("MyPortfolioServer.Models.Thesis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Thesises");
                });

            modelBuilder.Entity("MyPortfolioServer.Models.UsedTechnology", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("UsedTechnologies");
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

            modelBuilder.Entity("MyPortfolioServer.Models.UsedTechnology", b =>
                {
                    b.HasOne("MyPortfolioServer.Models.Project", null)
                        .WithMany("Technologies")
                        .HasForeignKey("ProjectId");
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

            modelBuilder.Entity("MyPortfolioServer.Models.Project", b =>
                {
                    b.Navigation("Technologies");
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