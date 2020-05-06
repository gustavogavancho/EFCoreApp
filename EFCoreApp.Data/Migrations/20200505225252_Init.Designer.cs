using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCoreApp.Data;

namespace EFCoreApp.Data.Migrations
{
    [DbContext(typeof(EFCoreDbContext))]
    [Migration("20200505225252_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6");

            modelBuilder.Entity("EFCoreApp.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Direccion");

                    b.Property<int>("Dni");

                    b.Property<string>("Nombres");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
        }
    }
}
