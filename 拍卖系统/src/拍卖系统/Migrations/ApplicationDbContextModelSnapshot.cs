﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using 拍卖系统.Data;
using 拍卖系统.Models;

namespace 拍卖系统.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("拍卖系统.Areas.Admin.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ControllerName");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("GroupICO");

                    b.Property<string>("GroupIDX");

                    b.Property<string>("GroupName");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("拍卖系统.Areas.Admin.Models.Menuitem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionName");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("ItemDesc");

                    b.Property<string>("ItemICO");

                    b.Property<string>("ItemIDX");

                    b.Property<string>("ItemName");

                    b.Property<string>("ItemURL");

                    b.Property<int>("MenuId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("拍卖系统.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("拍卖系统.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("拍卖系统.Models.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BidCount");

                    b.Property<string>("Bidnb");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("EndStatus");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("Gid");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("Mid");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("NowPrice");

                    b.Property<decimal>("Onset");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("StartTime");

                    b.Property<bool>("Status");

                    b.Property<decimal>("StepSize");

                    b.HasKey("Id");

                    b.HasIndex("Gid");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("拍卖系统.Models.AuctionRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Bided");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Gid");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("Mid");

                    b.Property<decimal>("Money");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("Gid");

                    b.HasIndex("Mid");

                    b.ToTable("AuctionRecords");
                });

            modelBuilder.Entity("拍卖系统.Models.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Picture");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("拍卖系统.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgentId");

                    b.Property<int>("AgentLevelId");

                    b.Property<DateTime>("AgentTime");

                    b.Property<string>("Area");

                    b.Property<string>("Avatar");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("City");

                    b.Property<int>("ClickCount");

                    b.Property<decimal>("Commission");

                    b.Property<decimal>("Commission_Pay");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Credit1");

                    b.Property<decimal>("Credit2");

                    b.Property<int>("Gender");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsAgent");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("LevelId");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NickName");

                    b.Property<string>("NoticeSet");

                    b.Property<string>("OpenId");

                    b.Property<string>("Password");

                    b.Property<string>("Province");

                    b.Property<bool>("Status");

                    b.Property<string>("Weixin");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("拍卖系统.Models.ApplicationRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("拍卖系统.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("拍卖系统.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("拍卖系统.Models.ApplicationRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("拍卖系统.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("拍卖系统.Areas.Admin.Models.Menuitem", b =>
                {
                    b.HasOne("拍卖系统.Areas.Admin.Models.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("拍卖系统.Models.Auction", b =>
                {
                    b.HasOne("拍卖系统.Models.Good", "Good")
                        .WithMany()
                        .HasForeignKey("Gid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("拍卖系统.Models.AuctionRecord", b =>
                {
                    b.HasOne("拍卖系统.Models.Auction", "Auction")
                        .WithMany("AuctionRecords")
                        .HasForeignKey("Gid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("拍卖系统.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
