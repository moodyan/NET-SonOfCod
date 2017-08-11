using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SonOfCod.Models;

namespace SonOfCod.Migrations
{
    [DbContext(typeof(SonOfCodDbContext))]
    partial class SonOfCodDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SonOfCod.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("Method");

                    b.Property<string>("Name");

                    b.Property<string>("Season");

                    b.Property<string>("Size");

                    b.Property<string>("Source");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
        }
    }
}
