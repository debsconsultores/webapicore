﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using contactos.Models;

namespace contactos.Migrations
{
    [DbContext(typeof(ContactosContext))]
    [Migration("20190311043416_UsuarioMigration")]
    partial class UsuarioMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("contactos.Models.Contacto", b =>
                {
                    b.Property<long?>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("mensaje");

                    b.Property<DateTime?>("nace");

                    b.Property<string>("nombre");

                    b.HasKey("id");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("contactos.Models.Usuario", b =>
                {
                    b.Property<string>("username")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("username");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
