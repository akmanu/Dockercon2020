﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agilistas.Migrations
{
    [DbContext(typeof(AgilistaContext))]
    [Migration("20190418172940_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgilistaTracker.Agilista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid>("PrimaryFocusId");

                    b.Property<string>("TwitterHandle");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryFocusId");

                    b.ToTable("Agilistas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5efdb55d-1205-419f-8a0b-9cc7a15f8565"),
                            Name = "Lisa Crispin",
                            PrimaryFocusId = new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b")
                        },
                        new
                        {
                            Id = new Guid("554be900-d1a4-4908-9d6a-5ef3ea05650e"),
                            Name = "Janet Gregory",
                            PrimaryFocusId = new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b")
                        },
                        new
                        {
                            Id = new Guid("f2e5fdba-daf9-43f0-8bde-9ed2562bd12a"),
                            Name = "Maaret Pyhäjärvi",
                            PrimaryFocusId = new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea")
                        },
                        new
                        {
                            Id = new Guid("83eda86f-c652-4666-ba17-db90b218a54b"),
                            Name = "Linda Rising",
                            PrimaryFocusId = new Guid("c5b6a0e8-e43f-4765-906f-e15e019a19d8")
                        });
                });

            modelBuilder.Entity("AgilistaTracker.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b"),
                            Description = "Agile Testing"
                        },
                        new
                        {
                            Id = new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"),
                            Description = "Exploratory Testing"
                        },
                        new
                        {
                            Id = new Guid("c5b6a0e8-e43f-4765-906f-e15e019a19d8"),
                            Description = "Psychology of Collaboration"
                        });
                });

            modelBuilder.Entity("AgilistaTracker.Agilista", b =>
                {
                    b.HasOne("AgilistaTracker.Category", "PrimaryFocus")
                        .WithMany()
                        .HasForeignKey("PrimaryFocusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
