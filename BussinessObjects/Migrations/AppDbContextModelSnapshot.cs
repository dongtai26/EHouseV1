﻿// <auto-generated />
using System;
using BussinessObjects.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BussinessObjects.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BussinessObjects.Models.Comment", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"), 1L, 1);

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastTimeModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("CId");

                    b.HasIndex("PId");

                    b.HasIndex("UId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BussinessObjects.Models.Contract", b =>
                {
                    b.Property<int>("ConId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConId"), 1L, 1);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractApproveDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContractContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractCreatedDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("LesseId")
                        .HasColumnType("int");

                    b.Property<int>("LessorId")
                        .HasColumnType("int");

                    b.HasKey("ConId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("BussinessObjects.Models.History", b =>
                {
                    b.Property<int>("Hid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hid"), 1L, 1);

                    b.Property<int>("ConId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("Hid");

                    b.HasIndex("ConId");

                    b.HasIndex("PId");

                    b.HasIndex("UId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("BussinessObjects.Models.HouseRent", b =>
                {
                    b.Property<int>("Hoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hoid"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AirConditioning")
                        .HasColumnType("bit");

                    b.Property<float>("Area")
                        .HasColumnType("real");

                    b.Property<bool>("Bed")
                        .HasColumnType("bit");

                    b.Property<float>("ElectricityPrice")
                        .HasColumnType("real");

                    b.Property<string>("HouseStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<bool>("Parking")
                        .HasColumnType("bit");

                    b.Property<bool>("Refrigerator")
                        .HasColumnType("bit");

                    b.Property<float>("RentPrice")
                        .HasColumnType("real");

                    b.Property<bool>("Restroom")
                        .HasColumnType("bit");

                    b.Property<bool>("WashingMachine")
                        .HasColumnType("bit");

                    b.Property<bool>("WaterHeater")
                        .HasColumnType("bit");

                    b.Property<float>("WaterPrice")
                        .HasColumnType("real");

                    b.Property<bool>("Wifi")
                        .HasColumnType("bit");

                    b.HasKey("Hoid");

                    b.HasIndex("PId");

                    b.ToTable("HouseRents");
                });

            modelBuilder.Entity("BussinessObjects.Models.Image", b =>
                {
                    b.Property<int>("IId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IId"), 1L, 1);

                    b.Property<string>("ImageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.HasKey("IId");

                    b.HasIndex("PId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BussinessObjects.Models.Notification", b =>
                {
                    b.Property<int>("NoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoId"), 1L, 1);

                    b.Property<string>("NoContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("NoId");

                    b.HasIndex("PId");

                    b.HasIndex("UId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("BussinessObjects.Models.Post", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"), 1L, 1);

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostCreatedDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("PId");

                    b.HasIndex("UId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BussinessObjects.Models.Role", b =>
                {
                    b.Property<int>("RId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BussinessObjects.Models.User", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitizenIdentification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BussinessObjects.Models.UserRole", b =>
                {
                    b.Property<int>("RId")
                        .HasColumnType("int");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasIndex("RId");

                    b.HasIndex("UId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BussinessObjects.Models.Comment", b =>
                {
                    b.HasOne("BussinessObjects.Models.Post", "Post")
                        .WithMany("Comment")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BussinessObjects.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObjects.Models.History", b =>
                {
                    b.HasOne("BussinessObjects.Models.Contract", "Contract")
                        .WithMany("Histories")
                        .HasForeignKey("ConId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BussinessObjects.Models.Post", "Post")
                        .WithMany("Histories")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BussinessObjects.Models.User", "User")
                        .WithMany("Histories")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObjects.Models.HouseRent", b =>
                {
                    b.HasOne("BussinessObjects.Models.Post", "Post")
                        .WithMany("HouseRents")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("BussinessObjects.Models.Image", b =>
                {
                    b.HasOne("BussinessObjects.Models.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("BussinessObjects.Models.Notification", b =>
                {
                    b.HasOne("BussinessObjects.Models.Post", "Post")
                        .WithMany("Notifications")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BussinessObjects.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObjects.Models.Post", b =>
                {
                    b.HasOne("BussinessObjects.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObjects.Models.UserRole", b =>
                {
                    b.HasOne("BussinessObjects.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BussinessObjects.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObjects.Models.Contract", b =>
                {
                    b.Navigation("Histories");
                });

            modelBuilder.Entity("BussinessObjects.Models.Post", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Histories");

                    b.Navigation("HouseRents");

                    b.Navigation("Images");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("BussinessObjects.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Histories");

                    b.Navigation("Notifications");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
