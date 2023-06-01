﻿// <auto-generated />
using EmailCodeCheckIn.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmailCodeCheckIn.Migrations
{
    [DbContext(typeof(CodeCheckInContext))]
    [Migration("20230531072109_Initial1-migration")]
    partial class Initial1migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmailCodeCheckIn.Models.CodeCheckIn", b =>
                {
                    b.Property<int>("CodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodeId");

                    b.ToTable("CodeCheckIns");
                });

            modelBuilder.Entity("EmailCodeCheckIn.Models.FileURL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodeCheckInId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CodeCheckInId");

                    b.ToTable("FileURL");
                });

            modelBuilder.Entity("EmailCodeCheckIn.Models.SendTo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodeCheckInId")
                        .HasColumnType("int");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CodeCheckInId");

                    b.ToTable("SendTo");
                });

            modelBuilder.Entity("EmailCodeCheckIn.Models.FileURL", b =>
                {
                    b.HasOne("EmailCodeCheckIn.Models.CodeCheckIn", "CodeCheckIn")
                        .WithMany("FileURL")
                        .HasForeignKey("CodeCheckInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodeCheckIn");
                });

            modelBuilder.Entity("EmailCodeCheckIn.Models.SendTo", b =>
                {
                    b.HasOne("EmailCodeCheckIn.Models.CodeCheckIn", "CodeCheckIn")
                        .WithMany("SendTo")
                        .HasForeignKey("CodeCheckInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodeCheckIn");
                });

            modelBuilder.Entity("EmailCodeCheckIn.Models.CodeCheckIn", b =>
                {
                    b.Navigation("FileURL");

                    b.Navigation("SendTo");
                });
#pragma warning restore 612, 618
        }
    }
}
