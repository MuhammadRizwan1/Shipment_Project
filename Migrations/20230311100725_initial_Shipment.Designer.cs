﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shipment_Project.Data.DBContext;

namespace Shipment_Project.Migrations
{
    [DbContext(typeof(ShipmentDbContext))]
    [Migration("20230311100725_initial_Shipment")]
    partial class initial_Shipment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Shipment_Project.Model.Carrier", b =>
                {
                    b.Property<int>("Carrier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Carrier_mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carrier_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Carrier_id");

                    b.ToTable("Carrier");
                });

            modelBuilder.Entity("Shipment_Project.Model.Shipment", b =>
                {
                    b.Property<int>("Shipment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Carrier_id")
                        .HasColumnType("int");

                    b.Property<string>("Shipment_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Shipment_rate_id")
                        .HasColumnType("int");

                    b.Property<string>("Shipment_weight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Shipper_id")
                        .HasColumnType("int");

                    b.HasKey("Shipment_id");

                    b.HasIndex("Carrier_id");

                    b.HasIndex("Shipment_rate_id");

                    b.HasIndex("Shipper_id");

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("Shipment_Project.Model.Shipment_Rate", b =>
                {
                    b.Property<int>("Shipment_rate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Shipment_rate_class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shipment_rate_description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Shipment_rate_id");

                    b.ToTable("Shipment_Rate");
                });

            modelBuilder.Entity("Shipment_Project.Model.Shipper", b =>
                {
                    b.Property<int>("Shipper_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Shipper_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Shipper_id");

                    b.ToTable("Shipper");
                });

            modelBuilder.Entity("Shipment_Project.Model.Shipment", b =>
                {
                    b.HasOne("Shipment_Project.Model.Carrier", "Carrier")
                        .WithMany("Shipments")
                        .HasForeignKey("Carrier_id");

                    b.HasOne("Shipment_Project.Model.Shipment_Rate", "Shipment_Rate")
                        .WithMany("Shipments")
                        .HasForeignKey("Shipment_rate_id");

                    b.HasOne("Shipment_Project.Model.Shipper", "Shipper")
                        .WithMany("Shipments")
                        .HasForeignKey("Shipper_id");

                    b.Navigation("Carrier");

                    b.Navigation("Shipment_Rate");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Shipment_Project.Model.Carrier", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("Shipment_Project.Model.Shipment_Rate", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("Shipment_Project.Model.Shipper", b =>
                {
                    b.Navigation("Shipments");
                });
#pragma warning restore 612, 618
        }
    }
}
