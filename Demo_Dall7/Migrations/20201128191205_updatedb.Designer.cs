﻿// <auto-generated />
using System;
using Demo_Dall7;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo_Dall7.Migrations
{
    [DbContext(typeof(BookLibaryContext))]
    [Migration("20201128191205_updatedb")]
    partial class updatedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo_Dall7.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Demo_Dall7.BooksLike", b =>
                {
                    b.Property<int>("BooksLikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<bool>("IsLike")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LikeTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BooksLikeId");

                    b.HasIndex("BookId");

                    b.ToTable("likes");
                });

            modelBuilder.Entity("Demo_Dall7.BooksLike", b =>
                {
                    b.HasOne("Demo_Dall7.Book", "Books")
                        .WithMany()
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
