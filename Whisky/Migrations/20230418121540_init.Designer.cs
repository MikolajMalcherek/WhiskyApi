﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Whisky;

#nullable disable

namespace Whisky.Migrations
{
    [DbContext(typeof(DistilleryDbContext))]
    [Migration("20230418121540_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Whisky.Distillery", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("whiskybase_rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("whiskybase_votes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("whiskybase_whiskies")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("name");

                    b.ToTable("DistDB");
                });
#pragma warning restore 612, 618
        }
    }
}