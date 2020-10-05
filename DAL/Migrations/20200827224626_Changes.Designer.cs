﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200827224626_Changes")]
    partial class Changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.6.20312.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryOrder")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("SectionID")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.HasIndex("SectionID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BAL.Entities.Currency", b =>
                {
                    b.Property<int>("CurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CurrencyID");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("BAL.Entities.DoorType", b =>
                {
                    b.Property<int>("DoorTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoorTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoorTypeID");

                    b.ToTable("DoorType");
                });

            modelBuilder.Entity("BAL.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BestQuantity")
                        .HasColumnType("int");

                    b.Property<string>("BuildingCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentQuantity")
                        .HasColumnType("int");

                    b.Property<string>("GroupNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndexNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LocationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriorityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductDesignID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductGradeID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<string>("RetailBin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("WholeSaleBin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ProductDesignID");

                    b.HasIndex("ProductGradeID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BAL.Entities.ProductAttribute", b =>
                {
                    b.Property<int>("ProductAttributeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<string>("ProductAttributeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ProductAttributeID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductAttributes");
                });

            modelBuilder.Entity("BAL.Entities.ProductAttributeThickness", b =>
                {
                    b.Property<int>("ProductAttributeThicknessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductAttributeID")
                        .HasColumnType("int");

                    b.Property<string>("ProductCodeInitials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductThicknessID")
                        .HasColumnType("int");

                    b.HasKey("ProductAttributeThicknessID");

                    b.HasIndex("ProductAttributeID");

                    b.HasIndex("ProductThicknessID");

                    b.ToTable("ProductAttributeThickness");
                });

            modelBuilder.Entity("BAL.Entities.ProductDesign", b =>
                {
                    b.Property<int>("ProductDesignID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductDesignName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductDesignID");

                    b.ToTable("ProductDesigns");
                });

            modelBuilder.Entity("BAL.Entities.ProductGrade", b =>
                {
                    b.Property<int>("ProductGradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductGradeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductGradeID");

                    b.ToTable("ProductGrades");
                });

            modelBuilder.Entity("BAL.Entities.ProductHeight", b =>
                {
                    b.Property<int>("ProductHeightID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductHeightName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductHeightID");

                    b.ToTable("ProductHeights");
                });

            modelBuilder.Entity("BAL.Entities.ProductImage", b =>
                {
                    b.Property<int>("ProductImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsMainImage")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("OriginalImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ThumbNailSizeImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductImageID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("BAL.Entities.ProductSizeAndPrice", b =>
                {
                    b.Property<int>("ProductSizeAndPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InvDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Markup")
                        .HasColumnType("float");

                    b.Property<DateTime>("PriceDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PriceVoid")
                        .HasColumnType("float");

                    b.Property<int?>("ProductAttributeThicknessID")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductHeightID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductWidthID")
                        .HasColumnType("int");

                    b.Property<double>("RetailPriceDisc")
                        .HasColumnType("float");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductSizeAndPriceID");

                    b.HasIndex("ProductAttributeThicknessID");

                    b.HasIndex("ProductHeightID");

                    b.HasIndex("ProductWidthID");

                    b.ToTable("ProductSizeAndPrices");
                });

            modelBuilder.Entity("BAL.Entities.ProductSupplier", b =>
                {
                    b.Property<int>("ProductSupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("InboundCost")
                        .HasColumnType("float");

                    b.Property<bool>("IsLive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOption")
                        .HasColumnType("bit");

                    b.Property<double>("LandedCost")
                        .HasColumnType("float");

                    b.Property<int?>("ProductSizeAndPriceID")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.Property<double>("TransportationCost")
                        .HasColumnType("float");

                    b.HasKey("ProductSupplierID");

                    b.HasIndex("ProductSizeAndPriceID");

                    b.HasIndex("SupplierID");

                    b.ToTable("ProductSuppliers");
                });

            modelBuilder.Entity("BAL.Entities.ProductThickness", b =>
                {
                    b.Property<int>("ProductThicknessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductThicknessName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductThicknessID");

                    b.ToTable("ProductThicknesses");
                });

            modelBuilder.Entity("BAL.Entities.ProductWidth", b =>
                {
                    b.Property<int>("ProductWidthID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductWidthName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductWidthID");

                    b.ToTable("ProductWidths");
                });

            modelBuilder.Entity("BAL.Entities.Roles", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BAL.Entities.Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionOrder")
                        .HasColumnType("int");

                    b.HasKey("SectionID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("BAL.Entities.SubCatGallery", b =>
                {
                    b.Property<int>("SubCatGalleryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("IsMainImage")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("OriginalImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ThumbNailSizeImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCatGalleryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("SubCatGalleries");
                });

            modelBuilder.Entity("BAL.Entities.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("BAL.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SupplierCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("BAL.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BAL.Entities.UserRoles", b =>
                {
                    b.Property<int>("UserRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserRoleID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BAL.Entities.WebsiteInfo", b =>
                {
                    b.Property<int>("WebsiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpanelPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpanelUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DBPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DBUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevelopedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DomainRenewDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FTPPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FTPUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostingProviderContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostingProviderDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostingProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostingRenewDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteBannerTagLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteBannerTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(true);

                    b.HasKey("WebsiteID");

                    b.ToTable("WebsiteInfos");
                });

            modelBuilder.Entity("BAL.Entities.Category", b =>
                {
                    b.HasOne("BAL.Entities.Section", "Section")
                        .WithMany("Categoriess")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.Product", b =>
                {
                    b.HasOne("BAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BAL.Entities.ProductDesign", "ProductDesign")
                        .WithMany("Products")
                        .HasForeignKey("ProductDesignID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BAL.Entities.ProductGrade", "ProductGrade")
                        .WithMany("Products")
                        .HasForeignKey("ProductGradeID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BAL.Entities.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.ProductAttribute", b =>
                {
                    b.HasOne("BAL.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyID");

                    b.HasOne("BAL.Entities.Product", "Product")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BAL.Entities.ProductAttributeThickness", b =>
                {
                    b.HasOne("BAL.Entities.ProductAttribute", "ProductAttribute")
                        .WithMany("ProductAttributeThicknesses")
                        .HasForeignKey("ProductAttributeID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BAL.Entities.ProductThickness", "ProductThickness")
                        .WithMany("ProductAttributeThicknesses")
                        .HasForeignKey("ProductThicknessID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BAL.Entities.ProductImage", b =>
                {
                    b.HasOne("BAL.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.ProductSizeAndPrice", b =>
                {
                    b.HasOne("BAL.Entities.ProductAttributeThickness", "ProductAttributeThickness")
                        .WithMany("ProductSizeAndPrices")
                        .HasForeignKey("ProductAttributeThicknessID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BAL.Entities.ProductHeight", "ProductHeight")
                        .WithMany("ProductSizeAndPrices")
                        .HasForeignKey("ProductHeightID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BAL.Entities.ProductWidth", "ProductWidth")
                        .WithMany("ProductSizeAndPrices")
                        .HasForeignKey("ProductWidthID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.ProductSupplier", b =>
                {
                    b.HasOne("BAL.Entities.ProductSizeAndPrice", "ProductSizeAndPrice")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("ProductSizeAndPriceID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BAL.Entities.Supplier", "Supplier")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.SubCatGallery", b =>
                {
                    b.HasOne("BAL.Entities.Category", "Category")
                        .WithMany("SubCatGalleries")
                        .HasForeignKey("CategoryID");

                    b.HasOne("BAL.Entities.SubCategory", "SubCategory")
                        .WithMany("SubCatGallery")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.SubCategory", b =>
                {
                    b.HasOne("BAL.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BAL.Entities.UserRoles", b =>
                {
                    b.HasOne("BAL.Entities.Roles", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BAL.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
