﻿// <auto-generated />
using System;
using BuroTek.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuroTek.Migrations
{
    [DbContext(typeof(BuroContext))]
    [Migration("20230928105043_arsiv")]
    partial class arsiv
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BuroTek.Model.Durum", b =>
                {
                    b.Property<int>("DurumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DurumId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DurumId");

                    b.ToTable("Durum");
                });

            modelBuilder.Entity("BuroTek.Model.Evrak", b =>
                {
                    b.Property<int>("EvrakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvrakID"));

                    b.Property<DateTime>("BelgeKayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("BelgeNo")
                        .HasColumnType("int");

                    b.Property<int>("BelgeTuruID")
                        .HasColumnType("int");

                    b.Property<string>("DosyaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DosyaNo")
                        .HasColumnType("int");

                    b.Property<string>("DosyaTuru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EklendigiTarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EvrakTuruID")
                        .HasColumnType("int");

                    b.Property<string>("KisiAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KurumAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KurumBelgeTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("EvrakID");

                    b.ToTable("evraks");
                });

            modelBuilder.Entity("BuroTek.Model.Notlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KayitTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Not")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notlar");
                });

            modelBuilder.Entity("BuroTek.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BaroSicilNo")
                        .HasColumnType("int");

                    b.Property<int>("BuroSıraNo")
                        .HasColumnType("int");

                    b.Property<int>("DurumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KayitTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KisiTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciTipi")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TuzelKisiAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YasalTemsilci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("DurumId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BuroTek.Model.User", b =>
                {
                    b.HasOne("BuroTek.Model.Durum", "Durum")
                        .WithMany("users")
                        .HasForeignKey("DurumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Durum");
                });

            modelBuilder.Entity("BuroTek.Model.Durum", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
