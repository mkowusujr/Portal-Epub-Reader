﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalApi.Models;

#nullable disable

namespace PortalApi.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20221210164331_MadeUserPropsNull")]
    partial class MadeUserPropsNull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("CollectionEBook", b =>
                {
                    b.Property<int>("CollectionsCollectionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EBooksEBookId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CollectionsCollectionId", "EBooksEBookId");

                    b.HasIndex("EBooksEBookId");

                    b.ToTable("CollectionEBook");
                });

            modelBuilder.Entity("PortalApi.Models.Annotation", b =>
                {
                    b.Property<int>("AnnotationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EBookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnnotationId");

                    b.HasIndex("EBookId");

                    b.HasIndex("UserId");

                    b.ToTable("Annotations");
                });

            modelBuilder.Entity("PortalApi.Models.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CollectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("PortalApi.Models.EBook", b =>
                {
                    b.Property<int>("EBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("CoverImage")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("TableOfContentsAsJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EBookId");

                    b.HasIndex("UserId");

                    b.ToTable("EBooks");
                });

            modelBuilder.Entity("PortalApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CollectionEBook", b =>
                {
                    b.HasOne("PortalApi.Models.Collection", null)
                        .WithMany()
                        .HasForeignKey("CollectionsCollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalApi.Models.EBook", null)
                        .WithMany()
                        .HasForeignKey("EBooksEBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortalApi.Models.Annotation", b =>
                {
                    b.HasOne("PortalApi.Models.EBook", "EBook")
                        .WithMany("Annotations")
                        .HasForeignKey("EBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortalApi.Models.User", "User")
                        .WithMany("Annotations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EBook");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalApi.Models.Collection", b =>
                {
                    b.HasOne("PortalApi.Models.User", "User")
                        .WithMany("Collections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalApi.Models.EBook", b =>
                {
                    b.HasOne("PortalApi.Models.User", "User")
                        .WithMany("EBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortalApi.Models.EBook", b =>
                {
                    b.Navigation("Annotations");
                });

            modelBuilder.Entity("PortalApi.Models.User", b =>
                {
                    b.Navigation("Annotations");

                    b.Navigation("Collections");

                    b.Navigation("EBooks");
                });
#pragma warning restore 612, 618
        }
    }
}