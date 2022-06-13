﻿// <auto-generated />
using System;
using DayPlanner_V2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DayPlanner_V2.Migrations
{
    [DbContext(typeof(DayPlanner_V2Context))]
    [Migration("20220613080430_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DayPlanner_V2.Models.TableSchema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BrainDump")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EightAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EightAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EightPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EightPM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElevenAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElevenAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElevenPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElevenPM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiveAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiveAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FivePM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FivePM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourPM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NineAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NineAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NinePM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NinePM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnePM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnePM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SevenAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SevenAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SevenPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SevenPM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SixAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SixAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SixPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SixPM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreePM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreePM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopPriorities1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopPriorities2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopPriorities3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwelveAM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwelveAM30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoPM00")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoPM30")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TableLayout");
                });
#pragma warning restore 612, 618
        }
    }
}