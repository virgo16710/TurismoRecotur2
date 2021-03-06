﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recotur2.Models;

namespace Recotur2.Migrations
{
    [DbContext(typeof(RecoUserDBContext))]
    [Migration("20200425164040_IniciarCreacion")]
    partial class IniciarCreacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recotur2.Models.DCandidato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanNombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("pass")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("DCandidatos");
                });
#pragma warning restore 612, 618
        }
    }
}
