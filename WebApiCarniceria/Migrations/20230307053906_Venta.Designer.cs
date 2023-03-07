﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCarniceria;

#nullable disable

namespace WebApiCarniceria.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230307053906_Venta")]
    partial class Venta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiCarniceria.Carniceria.Cliente", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cliente"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebApiCarniceria.Carniceria.Venta", b =>
                {
                    b.Property<int>("Id_venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_venta"), 1L, 1);

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("clienteId_cliente")
                        .HasColumnType("int");

                    b.Property<string>("fecha_venta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_venta");

                    b.HasIndex("clienteId_cliente");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("WebApiCarniceria.Carniceria.Venta", b =>
                {
                    b.HasOne("WebApiCarniceria.Carniceria.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId_cliente");

                    b.Navigation("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
