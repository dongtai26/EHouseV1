﻿// <auto-generated />
using System;
using BusinessObjects.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessObjects.Models.Admin", b =>
                {
                    b.Property<int>("AdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdId"), 1L, 1);

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("AdId");

                    b.HasIndex("UId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("BusinessObjects.Models.Comment", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"), 1L, 1);

                    b.Property<string>("CommentContent")
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

            modelBuilder.Entity("BusinessObjects.Models.Contract", b =>
                {
                    b.Property<int>("ConId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConId"), 1L, 1);

                    b.Property<int?>("AdId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractApproveDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContractContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractCreatedDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("HoId")
                        .HasColumnType("int");

                    b.Property<string>("HouseRentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LeId")
                        .HasColumnType("int");

                    b.Property<int?>("LesId")
                        .HasColumnType("int");

                    b.Property<float>("RentPrice")
                        .HasColumnType("real");

                    b.Property<bool>("StatusAdminId")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusLessorId")
                        .HasColumnType("bit");

                    b.HasKey("ConId");

                    b.HasIndex("AdId");

                    b.HasIndex("HoId");

                    b.HasIndex("LeId");

                    b.HasIndex("LesId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("BusinessObjects.Models.HouseAddress", b =>
                {
                    b.Property<int>("HouseAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HouseAddressId"), 1L, 1);

                    b.Property<int>("House_Id")
                        .HasColumnType("int");

                    b.Property<int>("Location_Id")
                        .HasColumnType("int");

                    b.HasKey("HouseAddressId");

                    b.HasIndex("House_Id");

                    b.HasIndex("Location_Id");

                    b.ToTable("HouseAddresses");
                });

            modelBuilder.Entity("BusinessObjects.Models.HouseImage", b =>
                {
                    b.Property<int>("PIId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PIId"), 1L, 1);

                    b.Property<int>("HoId")
                        .HasColumnType("int");

                    b.Property<string>("HouseImageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PIId");

                    b.HasIndex("HoId");

                    b.ToTable("HouseImages");
                });

            modelBuilder.Entity("BusinessObjects.Models.HouseRent", b =>
                {
                    b.Property<int>("HoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HoId"), 1L, 1);

                    b.Property<bool>("AirConditioning")
                        .HasColumnType("bit");

                    b.Property<float>("Area")
                        .HasColumnType("real");

                    b.Property<int>("Bed")
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ElectricityPrice")
                        .HasColumnType("real");

                    b.Property<string>("HouseRentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HouseStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("Kitchen")
                        .HasColumnType("bit");

                    b.Property<int>("LeId")
                        .HasColumnType("int");

                    b.Property<bool>("Parking")
                        .HasColumnType("bit");

                    b.Property<bool>("Refrigerator")
                        .HasColumnType("bit");

                    b.Property<float>("RentPrice")
                        .HasColumnType("real");

                    b.Property<int>("Restroom")
                        .HasColumnType("int");

                    b.Property<bool>("WashingMachine")
                        .HasColumnType("bit");

                    b.Property<bool>("WaterHeater")
                        .HasColumnType("bit");

                    b.Property<float>("WaterPrice")
                        .HasColumnType("real");

                    b.Property<bool>("Wifi")
                        .HasColumnType("bit");

                    b.HasKey("HoId");

                    b.HasIndex("LeId");

                    b.ToTable("HouseRents");
                });

            modelBuilder.Entity("BusinessObjects.Models.Lessee", b =>
                {
                    b.Property<int>("LesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LesId"), 1L, 1);

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("LesId");

                    b.HasIndex("UId");

                    b.ToTable("Lessees");
                });

            modelBuilder.Entity("BusinessObjects.Models.Lessor", b =>
                {
                    b.Property<int>("LeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeId"), 1L, 1);

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("LeId");

                    b.HasIndex("UId");

                    b.ToTable("Lessors");
                });

            modelBuilder.Entity("BusinessObjects.Models.Location", b =>
                {
                    b.Property<int>("LId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.HasKey("LId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BusinessObjects.Models.Merchant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantIpnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantReturnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantWebLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecretKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("BusinessObjects.Models.Notification", b =>
                {
                    b.Property<int>("NoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoId"), 1L, 1);

                    b.Property<int>("CId")
                        .HasColumnType("int");

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

                    b.HasIndex("CId");

                    b.HasIndex("PId");

                    b.HasIndex("UId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("BusinessObjects.Models.Payment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PaymentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDestinationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PaymentLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentLastMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentRefId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RequiredAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId");

                    b.HasIndex("PaymentDestinationId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentDestination", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DesLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DesSortIndex")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId")
                        .IsUnique()
                        .HasFilter("[ParentId] IS NOT NULL");

                    b.ToTable("PaymentDestinations");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentNotification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NotiAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotiContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NotiDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotiMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NotiResDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotiResHttpCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotiResMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotiSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotiStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentRefId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId");

                    b.HasIndex("ParentId");

                    b.ToTable("PaymentNotifications");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentSignature", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsVaid")
                        .HasColumnType("bit");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignAlgo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SignDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SignOwn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("PaymentSignatures");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentTransaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TranDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TranMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranRefId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("PaymentTransactions");
                });

            modelBuilder.Entity("BusinessObjects.Models.Post", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"), 1L, 1);

                    b.Property<int?>("AdId")
                        .HasColumnType("int");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostCreatedDay")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PostStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("PId");

                    b.HasIndex("AdId");

                    b.HasIndex("UId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BusinessObjects.Models.PostImage", b =>
                {
                    b.Property<int>("PIId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PIId"), 1L, 1);

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.Property<string>("PostImageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostImageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostImageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PIId");

                    b.HasIndex("PId");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("BusinessObjects.Models.Role", b =>
                {
                    b.Property<int>("RId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BusinessObjects.Models.User", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitizenIdentification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dateofbirth")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("RId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UId");

                    b.HasIndex("RId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessObjects.Models.UserToken", b =>
                {
                    b.Property<int>("TId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TId"), 1L, 1);

                    b.Property<string>("Jwt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("TId");

                    b.HasIndex("UId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("BusinessObjects.Models.Admin", b =>
                {
                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.Comment", b =>
                {
                    b.HasOne("BusinessObjects.Models.Post", "Post")
                        .WithMany("Comment")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.Contract", b =>
                {
                    b.HasOne("BusinessObjects.Models.Admin", "Admin")
                        .WithMany("Contracts")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusinessObjects.Models.HouseRent", "HouseRent")
                        .WithMany()
                        .HasForeignKey("HoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.Lessor", "Lessor")
                        .WithMany("Contracts")
                        .HasForeignKey("LeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusinessObjects.Models.Lessee", "Lessee")
                        .WithMany("Contracts")
                        .HasForeignKey("LesId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Admin");

                    b.Navigation("HouseRent");

                    b.Navigation("Lessee");

                    b.Navigation("Lessor");
                });

            modelBuilder.Entity("BusinessObjects.Models.HouseAddress", b =>
                {
                    b.HasOne("BusinessObjects.Models.HouseRent", "HouseRent")
                        .WithMany()
                        .HasForeignKey("House_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("Location_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("HouseRent");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BusinessObjects.Models.HouseImage", b =>
                {
                    b.HasOne("BusinessObjects.Models.HouseRent", "HouseRent")
                        .WithMany()
                        .HasForeignKey("HoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("HouseRent");
                });

            modelBuilder.Entity("BusinessObjects.Models.HouseRent", b =>
                {
                    b.HasOne("BusinessObjects.Models.Lessor", "Lessor")
                        .WithMany("HouseRents")
                        .HasForeignKey("LeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Lessor");
                });

            modelBuilder.Entity("BusinessObjects.Models.Lessee", b =>
                {
                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.Lessor", b =>
                {
                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.Notification", b =>
                {
                    b.HasOne("BusinessObjects.Models.Comment", "comment")
                        .WithMany("Notifications")
                        .HasForeignKey("CId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.Post", "Post")
                        .WithMany("Notifications")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");

                    b.Navigation("comment");
                });

            modelBuilder.Entity("BusinessObjects.Models.Payment", b =>
                {
                    b.HasOne("BusinessObjects.Models.Merchant", "Merchant")
                        .WithMany("Payments")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.PaymentDestination", "PaymentDestination")
                        .WithMany()
                        .HasForeignKey("PaymentDestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Merchant");

                    b.Navigation("PaymentDestination");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentDestination", b =>
                {
                    b.HasOne("BusinessObjects.Models.Payment", "Payment")
                        .WithOne()
                        .HasForeignKey("BusinessObjects.Models.PaymentDestination", "ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentNotification", b =>
                {
                    b.HasOne("BusinessObjects.Models.Merchant", "Merchant")
                        .WithMany("PaymentNotifications")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.Payment", "Payment")
                        .WithMany("PaymentNotifications")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Merchant");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentSignature", b =>
                {
                    b.HasOne("BusinessObjects.Models.Payment", "Payment")
                        .WithMany("PaymentSignatures")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("BusinessObjects.Models.PaymentTransaction", b =>
                {
                    b.HasOne("BusinessObjects.Models.Payment", "Payment")
                        .WithMany("PaymentTransactions")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("BusinessObjects.Models.Post", b =>
                {
                    b.HasOne("BusinessObjects.Models.Admin", "Admin")
                        .WithMany("Posts")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.PostImage", b =>
                {
                    b.HasOne("BusinessObjects.Models.Post", "Post")
                        .WithMany("PostImages")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("BusinessObjects.Models.User", b =>
                {
                    b.HasOne("BusinessObjects.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessObjects.Models.UserToken", b =>
                {
                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.Admin", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("BusinessObjects.Models.Comment", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("BusinessObjects.Models.Lessee", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("BusinessObjects.Models.Lessor", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("HouseRents");
                });

            modelBuilder.Entity("BusinessObjects.Models.Merchant", b =>
                {
                    b.Navigation("PaymentNotifications");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("BusinessObjects.Models.Payment", b =>
                {
                    b.Navigation("PaymentNotifications");

                    b.Navigation("PaymentSignatures");

                    b.Navigation("PaymentTransactions");
                });

            modelBuilder.Entity("BusinessObjects.Models.Post", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Notifications");

                    b.Navigation("PostImages");
                });

            modelBuilder.Entity("BusinessObjects.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Notifications");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
