﻿// <auto-generated />
using System;
using Animal_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Animal_API.Migrations
{
    [DbContext(typeof(Animal_APIContext))]
    [Migration("20190823172432_AgeCalculation")]
    partial class AgeCalculation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Animal_API.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<float?>("Age");

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("Breed");

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<string>("Gender");

                    b.Property<bool?>("GoodWithCats");

                    b.Property<bool?>("GoodWithDogs");

                    b.Property<bool?>("GoodWithKids");

                    b.Property<DateTime?>("IntakeDate");

                    b.Property<string>("Name");

                    b.Property<bool?>("SpayedNeutered");

                    b.Property<string>("Species");

                    b.Property<float?>("Weight");

                    b.HasKey("AnimalId");

                    b.ToTable("animals");
                });
#pragma warning restore 612, 618
        }
    }
}
