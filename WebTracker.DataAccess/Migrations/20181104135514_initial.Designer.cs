﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTracker.DataAccess;

namespace WebTracker.DataAccess.Migrations
{
    [DbContext(typeof(WebTrackerDbContext))]
    [Migration("20181104135514_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("WebTracker.Domain.WorkDay", b =>
                {
                    b.Property<int>("WorkDayId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("CurrentDate");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("WorkDayId");

                    b.ToTable("WorkDays");
                });
#pragma warning restore 612, 618
        }
    }
}
