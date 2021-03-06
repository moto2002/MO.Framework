﻿// <auto-generated />
using System;
using MO.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MO.Model.Migrations.MOData
{
    [DbContext(typeof(MODataContext))]
    [Migration("20201020032602_InitMODataV8")]
    partial class InitMODataV8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MO.Model.Entitys.GameUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DeviceId")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("HeadIcon")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("NickName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNum")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("WeiXinCode")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("GameUser");
                });

            modelBuilder.Entity("MO.Model.Entitys.PhoneCode", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<int>("PhoneType")
                        .HasColumnType("int")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("PhoneCode");
                });

            modelBuilder.Entity("MO.Model.Entitys.ServerConfig", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ApiIP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20)
                        .HasDefaultValue("127.0.0.1");

                    b.Property<ushort>("ApiPort")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasMaxLength(6)
                        .HasDefaultValue((ushort)8000);

                    b.Property<string>("GateIP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20)
                        .HasDefaultValue("127.0.0.1");

                    b.Property<ushort>("GatePort")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasMaxLength(6)
                        .HasDefaultValue((ushort)9001);

                    b.Property<string>("LoginIP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20)
                        .HasDefaultValue("127.0.0.1");

                    b.Property<ushort>("LoginPort")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasMaxLength(6)
                        .HasDefaultValue((ushort)8001);

                    b.Property<int>("ServerLevel")
                        .HasColumnType("int")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("ServerConfig");
                });
#pragma warning restore 612, 618
        }
    }
}
