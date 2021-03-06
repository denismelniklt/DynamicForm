﻿// <auto-generated />
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Domain.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CurrentValueId");

                    b.Property<int?>("FormId");

                    b.Property<string>("Name");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("CurrentValueId");

                    b.HasIndex("FormId");

                    b.HasIndex("TypeId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("Domain.Models.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PropertyType");
                });

            modelBuilder.Entity("Domain.Models.PropertyValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyValue");
                });

            modelBuilder.Entity("Domain.Models.Property", b =>
                {
                    b.HasOne("Domain.Models.PropertyValue", "CurrentValue")
                        .WithMany()
                        .HasForeignKey("CurrentValueId");

                    b.HasOne("Domain.Models.Form")
                        .WithMany("Properties")
                        .HasForeignKey("FormId");

                    b.HasOne("Domain.Models.PropertyType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Domain.Models.PropertyValue", b =>
                {
                    b.HasOne("Domain.Models.Property")
                        .WithMany("Values")
                        .HasForeignKey("PropertyId");
                });
#pragma warning restore 612, 618
        }
    }
}
