﻿// <auto-generated />
using System;
using IEManageSystem.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IEManageSystem.Migrations
{
    [DbContext(typeof(IEManageSystemDbContext))]
    partial class IEManageSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApiManageScopeId")
                        .HasColumnType("int");

                    b.Property<int?>("ApiQueryScopeId")
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiManageScopeId");

                    b.HasIndex("ApiQueryScopeId");

                    b.ToTable("ApiScope");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScopePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiScopeId")
                        .HasColumnType("int");

                    b.Property<int?>("ApiScopeNodeId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeNodeId");

                    b.HasIndex("PermissionId");

                    b.ToTable("ApiScopePermission");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApiScopeNode");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApiScopeNode");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.CmsComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CmsComponents");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Logics.Logic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logics");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.MenuBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompositeMenuId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageDataId")
                        .HasColumnType("int");

                    b.Property<int?>("RootMenuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompositeMenuId");

                    b.HasIndex("PageDataId");

                    b.HasIndex("RootMenuId");

                    b.ToTable("Menus");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MenuBase");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.ContentComponentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PageDataId")
                        .HasColumnType("int");

                    b.Property<string>("Sign")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PageDataId");

                    b.ToTable("ContentComponentData");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.PageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("PageDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Index",
                            PageId = 1,
                            Title = "首页"
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.SingleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContentComponentDataId")
                        .HasColumnType("int");

                    b.Property<string>("Field1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContentComponentDataId");

                    b.ToTable("SingleData");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PageBase");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CmsComponentId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("ParentSign")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sign")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CmsComponentId");

                    b.HasIndex("PageId");

                    b.ToTable("PageComponentBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PageComponentBase");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageComponentBaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PageComponentBaseId");

                    b.ToTable("PageComponentSetting");
                });

            modelBuilder.Entity("IEManageSystem.Common.DomainModel.SiteSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Permissions.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Roles.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermission");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.Accounts.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadSculpture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PersonSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiManageScope", b =>
                {
                    b.HasBaseType("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode");

                    b.HasDiscriminator().HasValue("ApiManageScope");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiQueryScope", b =>
                {
                    b.HasBaseType("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode");

                    b.HasDiscriminator().HasValue("ApiQueryScope");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.CompositeMenu", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Menus.MenuBase");

                    b.HasDiscriminator().HasValue("CompositeMenu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discriminator = "CompositeMenu",
                            DisplayName = "主菜单",
                            Icon = "",
                            Name = "Main"
                        },
                        new
                        {
                            Id = 2,
                            CompositeMenuId = 1,
                            Discriminator = "CompositeMenu",
                            DisplayName = "首页",
                            Icon = "oi-home",
                            Name = "Home",
                            RootMenuId = 1
                        },
                        new
                        {
                            Id = 3,
                            CompositeMenuId = 1,
                            Discriminator = "CompositeMenu",
                            DisplayName = "游戏",
                            Icon = "oi-dial",
                            Name = "Game",
                            RootMenuId = 1
                        },
                        new
                        {
                            Id = 4,
                            CompositeMenuId = 1,
                            Discriminator = "CompositeMenu",
                            DisplayName = "技术文档",
                            Icon = "oi-document",
                            Name = "Document",
                            RootMenuId = 1
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.LeafMenu", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Menus.MenuBase");

                    b.HasDiscriminator().HasValue("LeafMenu");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CompositeMenuId = 3,
                            Discriminator = "LeafMenu",
                            DisplayName = "主机游戏",
                            Name = "PCGame",
                            RootMenuId = 1
                        },
                        new
                        {
                            Id = 102,
                            CompositeMenuId = 3,
                            Discriminator = "LeafMenu",
                            DisplayName = "手机游戏",
                            Name = "PhoneGame",
                            RootMenuId = 1
                        },
                        new
                        {
                            Id = 103,
                            CompositeMenuId = 4,
                            Discriminator = "LeafMenu",
                            DisplayName = "站点技术",
                            Name = "Web",
                            RootMenuId = 1
                        },
                        new
                        {
                            Id = 104,
                            CompositeMenuId = 4,
                            Discriminator = "LeafMenu",
                            DisplayName = "桌面开发",
                            Name = "Desktop",
                            RootMenuId = 1
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.ContentPage", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageBase");

                    b.HasDiscriminator().HasValue("ContentPage");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.StaticPage", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageBase");

                    b.HasDiscriminator().HasValue("StaticPage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "这是一个首页",
                            Discriminator = "StaticPage",
                            DisplayName = "首页",
                            Name = "Home"
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.CompositeComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.HasDiscriminator().HasValue("CompositeComponent");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.LeafComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.HasDiscriminator().HasValue("LeafComponent");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.MenuComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MenuComponent");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageLeafComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.Property<int?>("TargetPageId")
                        .HasColumnType("int");

                    b.HasIndex("TargetPageId");

                    b.HasDiscriminator().HasValue("PageLeafComponent");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScope", b =>
                {
                    b.HasOne("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", "ApiManageScope")
                        .WithMany()
                        .HasForeignKey("ApiManageScopeId");

                    b.HasOne("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", "ApiQueryScope")
                        .WithMany()
                        .HasForeignKey("ApiQueryScopeId");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScopePermission", b =>
                {
                    b.HasOne("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", null)
                        .WithMany("ApiScopePermissions")
                        .HasForeignKey("ApiScopeNodeId");

                    b.HasOne("IEManageSystem.Entitys.Authorization.Permissions.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.MenuBase", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Menus.CompositeMenu", null)
                        .WithMany("Menus")
                        .HasForeignKey("CompositeMenuId");

                    b.HasOne("IEManageSystem.CMS.DomainModel.PageDatas.PageData", "PageData")
                        .WithMany()
                        .HasForeignKey("PageDataId");

                    b.HasOne("IEManageSystem.CMS.DomainModel.Menus.CompositeMenu", "RootMenu")
                        .WithMany()
                        .HasForeignKey("RootMenuId");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.ContentComponentData", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.PageDatas.PageData", "PageData")
                        .WithMany("ContentComponentDatas")
                        .HasForeignKey("PageDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.PageData", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageBase", "Page")
                        .WithMany("PageDatas")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.SingleData", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.PageDatas.ContentComponentData", null)
                        .WithMany("SingleDatas")
                        .HasForeignKey("ContentComponentDataId");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.CmsComponent", "CmsComponent")
                        .WithMany()
                        .HasForeignKey("CmsComponentId");

                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageBase", "Page")
                        .WithMany("PageComponents")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("IEManageSystem.CMS.DomainModel.Pages.PageComponentBaseSetting", "PageComponentBaseSetting", b1 =>
                        {
                            b1.Property<int>("PageComponentBaseId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("BackgroundColor")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ClassName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Col")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Height")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Margin")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Padding")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("SortIndex")
                                .HasColumnType("int");

                            b1.HasKey("PageComponentBaseId");

                            b1.ToTable("PageComponentBase");

                            b1.WithOwner()
                                .HasForeignKey("PageComponentBaseId");
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentSetting", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase", null)
                        .WithMany("PageComponentSettings")
                        .HasForeignKey("PageComponentBaseId");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Roles.RolePermission", b =>
                {
                    b.HasOne("IEManageSystem.Entitys.Authorization.Permissions.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IEManageSystem.Entitys.Authorization.Roles.Role", null)
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.Accounts.Account", b =>
                {
                    b.OwnsOne("IEManageSystem.Entitys.Authorization.Users.Accounts.SafetyProblem", "SafetyProblem", b1 =>
                        {
                            b1.Property<int>("AccountId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Answer")
                                .HasColumnType("nvarchar(20)")
                                .HasMaxLength(20);

                            b1.Property<string>("Problem")
                                .HasColumnType("nvarchar(20)")
                                .HasMaxLength(20);

                            b1.HasKey("AccountId");

                            b1.ToTable("Account");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.User", b =>
                {
                    b.HasOne("IEManageSystem.Entitys.Authorization.Users.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.UserRole", b =>
                {
                    b.HasOne("IEManageSystem.Entitys.Authorization.Roles.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IEManageSystem.Entitys.Authorization.Users.User", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageLeafComponent", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageBase", "TargetPage")
                        .WithMany()
                        .HasForeignKey("TargetPageId");
                });
#pragma warning restore 612, 618
        }
    }
}
