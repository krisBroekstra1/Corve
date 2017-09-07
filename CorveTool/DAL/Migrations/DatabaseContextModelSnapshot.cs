﻿// <auto-generated />
using CorveTool.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CorveTool.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CorveTool.DAL.Models.Schedules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ScheduleTaskId");

                    b.Property<DateTime>("When");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleTaskId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("CorveTool.DAL.Models.ScheduleTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Schedule_Task");
                });

            modelBuilder.Entity("CorveTool.DAL.Models.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ScheduleTaskId");

                    b.Property<string>("Task");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleTaskId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("CorveTool.DAL.Models.Schedules", b =>
                {
                    b.HasOne("CorveTool.DAL.Models.ScheduleTask")
                        .WithMany("Schedules")
                        .HasForeignKey("ScheduleTaskId");
                });

            modelBuilder.Entity("CorveTool.DAL.Models.Tasks", b =>
                {
                    b.HasOne("CorveTool.DAL.Models.ScheduleTask")
                        .WithMany("Tasks")
                        .HasForeignKey("ScheduleTaskId");
                });
#pragma warning restore 612, 618
        }
    }
}
