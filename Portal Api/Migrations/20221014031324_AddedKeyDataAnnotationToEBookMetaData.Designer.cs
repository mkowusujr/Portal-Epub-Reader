﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal_Api.Models;

#nullable disable

namespace Portal_Api.Migrations
{
    [DbContext(typeof(EBookMetaDataDbContext))]
    [Migration("20221014031324_AddedKeyDataAnnotationToEBookMetaData")]
    partial class AddedKeyDataAnnotationToEBookMetaData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Portal_Api.Models.EBookMetaData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMarkAsFavorite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("EBookMetaData");
                });
#pragma warning restore 612, 618
        }
    }
}
