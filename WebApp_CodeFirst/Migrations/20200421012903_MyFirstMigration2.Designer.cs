﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp_CodeFirst.Models;

namespace WebApp_CodeFirst.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200421012903_MyFirstMigration2")]
    partial class MyFirstMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp_CodeFirst.Models.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("WebApp_CodeFirst.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<int>("CiudadId");

                    b.Property<string>("Nombre");

                    b.Property<string>("Numero_Identificacion");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("WebApp_CodeFirst.Models.Vendedor", b =>
                {
                    b.HasOne("WebApp_CodeFirst.Models.Ciudad", "Ciudad")
                        .WithMany("Vendedores")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
