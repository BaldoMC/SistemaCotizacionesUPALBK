﻿// <auto-generated />
using Cotizaciones.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Cotizaciones.Migrations
{
    [DbContext(typeof(CotizacionesContext))]
    partial class CotizacionesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Cotizaciones.Models.Cotizacion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("costo");

                    b.Property<string>("descripcion");

                    b.Property<string>("estado");

                    b.Property<DateTime>("fechaCreacion");

                    b.Property<DateTime>("fechaValidez");

                    b.Property<string>("nombreCliente");

                    b.Property<string>("nombreProductor");

                    b.Property<int>("total");

                    b.HasKey("ID");

                    b.ToTable("Cotizaciones");
                });

            modelBuilder.Entity("Cotizaciones.Models.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Materno");

                    b.Property<string>("Nombre");

                    b.Property<string>("Paterno");

                    b.Property<string>("Rut");

                    b.HasKey("ID");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
