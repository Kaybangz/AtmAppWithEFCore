﻿// <auto-generated />
using System;
using AtmApp.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AtmApp.DATA.Migrations
{
    [DbContext(typeof(AtmDbContext))]
    partial class AtmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AtmApp.DATA.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Middlename")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("AtmApp.DATA.Entities.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("AtmApp.DATA.Entities.Transfer", b =>
                {
                    b.Property<int>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(15,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("TransferId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Transfer");
                });

            modelBuilder.Entity("AtmApp.DATA.Entities.Transaction", b =>
                {
                    b.HasOne("AtmApp.DATA.Entities.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AtmApp.DATA.Entities.Transfer", b =>
                {
                    b.HasOne("AtmApp.DATA.Entities.Customer", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId");

                    b.HasOne("AtmApp.DATA.Entities.Customer", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("AtmApp.DATA.Entities.Customer", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
