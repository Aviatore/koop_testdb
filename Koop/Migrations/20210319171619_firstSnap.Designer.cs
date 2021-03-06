// <auto-generated />
using System;
using Koop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Koop.Migrations
{
    [DbContext(typeof(koopTmpContext))]
    [Migration("20210319171619_firstSnap")]
    partial class firstSnap
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Koop.Models.AvailableQuantity", b =>
                {
                    b.Property<long>("AvailableQuantityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("available_quantity_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("AvailableQuantityId");

                    b.HasIndex("ProductId");

                    b.ToTable("available_quantities");
                });

            modelBuilder.Entity("Koop.Models.Basket", b =>
                {
                    b.Property<long>("BasketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("basket_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CoopId")
                        .HasColumnType("bigint")
                        .HasColumnName("coop_id");

                    b.HasKey("BasketId");

                    b.HasIndex("CoopId");

                    b.ToTable("baskets");
                });

            modelBuilder.Entity("Koop.Models.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("category_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("category_name");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Koop.Models.Cooperator", b =>
                {
                    b.Property<long>("CoopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("coop_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte?>("BasketId")
                        .HasColumnType("tinyint")
                        .HasColumnName("basket_id");

                    b.Property<double?>("Debt")
                        .HasColumnType("float")
                        .HasColumnName("debt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("first_name");

                    b.Property<long?>("FunctionId")
                        .HasColumnType("bigint")
                        .HasColumnName("function_id");

                    b.Property<long>("FundId")
                        .HasColumnType("bigint")
                        .HasColumnName("fund_id");

                    b.Property<string>("Info")
                        .HasColumnType("text")
                        .HasColumnName("info");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.HasKey("CoopId")
                        .HasName("pk_cooperators");

                    b.HasIndex("FunctionId");

                    b.HasIndex("FundId");

                    b.ToTable("cooperators");
                });

            modelBuilder.Entity("Koop.Models.Favority", b =>
                {
                    b.Property<long>("FavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("favorite_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CoopId")
                        .HasColumnType("bigint")
                        .HasColumnName("coop_id");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.HasKey("FavoriteId")
                        .HasName("pk_favorities");

                    b.HasIndex("CoopId");

                    b.HasIndex("ProductId");

                    b.ToTable("favorities");
                });

            modelBuilder.Entity("Koop.Models.Function", b =>
                {
                    b.Property<long>("FunctionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("function_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FunctionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("function_name");

                    b.HasKey("FunctionId");

                    b.ToTable("functions");
                });

            modelBuilder.Entity("Koop.Models.Fund", b =>
                {
                    b.Property<long>("FundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("fund_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Value")
                        .HasColumnType("tinyint")
                        .HasColumnName("value");

                    b.HasKey("FundId");

                    b.ToTable("funds");
                });

            modelBuilder.Entity("Koop.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("order_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderStartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_start_date");

                    b.Property<DateTime>("OrderStopDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_stop_date");

                    b.HasKey("OrderId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Koop.Models.OrderStatus", b =>
                {
                    b.Property<long>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("order_status_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStatusName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("order_status_name");

                    b.HasKey("OrderStatusId");

                    b.ToTable("order_status");
                });

            modelBuilder.Entity("Koop.Models.OrderedItem", b =>
                {
                    b.Property<long>("OrderedItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ordered_item_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CoopId")
                        .HasColumnType("bigint")
                        .HasColumnName("coop_id");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint")
                        .HasColumnName("order_id");

                    b.Property<long>("OrderStatusId")
                        .HasColumnType("bigint")
                        .HasColumnName("order_status_id");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("OrderedItemId");

                    b.HasIndex("CoopId");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("ProductId");

                    b.ToTable("ordered_items");
                });

            modelBuilder.Entity("Koop.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("product_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountInMagazine")
                        .HasColumnType("int")
                        .HasColumnName("amount_in_magazine");

                    b.Property<int?>("AmountMax")
                        .HasColumnType("int")
                        .HasColumnName("amount_max");

                    b.Property<bool>("Available")
                        .HasColumnType("bit")
                        .HasColumnName("available");

                    b.Property<bool>("Blocked")
                        .HasColumnType("bit")
                        .HasColumnName("blocked");

                    b.Property<int?>("Deposit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("deposit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("Magazine")
                        .HasColumnType("bit")
                        .HasColumnName("magazine");

                    b.Property<string>("Picture")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasColumnName("picture")
                        .HasDefaultValueSql("('')");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("product_name");

                    b.Property<long>("SupplierId")
                        .HasColumnType("bigint")
                        .HasColumnName("supplier_id");

                    b.Property<long>("UnitId")
                        .HasColumnType("bigint")
                        .HasColumnName("unit_id");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UnitId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Koop.Models.ProductCategory", b =>
                {
                    b.Property<long>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("product_category_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.HasKey("ProductCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("product_categories");
                });

            modelBuilder.Entity("Koop.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("supplier_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("email");

                    b.Property<long>("OproId")
                        .HasColumnType("bigint")
                        .HasColumnName("opro_id");

                    b.Property<DateTime?>("OrderClosingDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_closing_date");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<string>("Picture")
                        .HasColumnType("text")
                        .HasColumnName("picture");

                    b.Property<string>("SupplierAbbr")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("supplier_abbr");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("supplier_name");

                    b.HasKey("SupplierId");

                    b.HasIndex("OproId");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("Koop.Models.Unit", b =>
                {
                    b.Property<long>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("unit_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("unit_name");

                    b.HasKey("UnitId");

                    b.ToTable("units");
                });

            modelBuilder.Entity("Koop.Models.Work", b =>
                {
                    b.Property<long>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("work_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CoopId")
                        .HasColumnType("bigint")
                        .HasColumnName("coop_id");

                    b.Property<double>("Duration")
                        .HasColumnType("float")
                        .HasColumnName("duration");

                    b.Property<DateTime>("WorkDate")
                        .HasColumnType("datetime")
                        .HasColumnName("work_date");

                    b.Property<long>("WorkTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("work_type_id");

                    b.HasKey("WorkId");

                    b.HasIndex("CoopId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("works");
                });

            modelBuilder.Entity("Koop.Models.WorkType", b =>
                {
                    b.Property<long>("WorkTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("work_type_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WorkType1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("work_type");

                    b.HasKey("WorkTypeId");

                    b.ToTable("work_types");
                });

            modelBuilder.Entity("Koop.Models.AvailableQuantity", b =>
                {
                    b.HasOne("Koop.Models.Product", "Product")
                        .WithMany("AvailableQuantities")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_available_quantities_product_id")
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koop.Models.Basket", b =>
                {
                    b.HasOne("Koop.Models.Cooperator", "Coop")
                        .WithMany("Baskets")
                        .HasForeignKey("CoopId")
                        .HasConstraintName("fk_baskets_coop_id");

                    b.Navigation("Coop");
                });

            modelBuilder.Entity("Koop.Models.Cooperator", b =>
                {
                    b.HasOne("Koop.Models.Function", "Function")
                        .WithMany("Cooperators")
                        .HasForeignKey("FunctionId")
                        .HasConstraintName("fk_cooperators_function_id");

                    b.HasOne("Koop.Models.Fund", "Fund")
                        .WithMany("Cooperators")
                        .HasForeignKey("FundId")
                        .HasConstraintName("fk_cooperators_fund_id")
                        .IsRequired();

                    b.Navigation("Function");

                    b.Navigation("Fund");
                });

            modelBuilder.Entity("Koop.Models.Favority", b =>
                {
                    b.HasOne("Koop.Models.Cooperator", "Coop")
                        .WithMany("Favorities")
                        .HasForeignKey("CoopId")
                        .HasConstraintName("fk_favorities_coop_id")
                        .IsRequired();

                    b.HasOne("Koop.Models.Product", "Product")
                        .WithMany("Favorities")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_favorities_product_id")
                        .IsRequired();

                    b.Navigation("Coop");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koop.Models.OrderedItem", b =>
                {
                    b.HasOne("Koop.Models.Cooperator", "Coop")
                        .WithMany("OrderedItems")
                        .HasForeignKey("CoopId")
                        .HasConstraintName("fk_ordered_items_coop_id")
                        .IsRequired();

                    b.HasOne("Koop.Models.Order", "Order")
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("fk_ordered_items_order_id")
                        .IsRequired();

                    b.HasOne("Koop.Models.OrderStatus", "OrderStatus")
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderStatusId")
                        .HasConstraintName("fk_ordered_items_order_status_id")
                        .IsRequired();

                    b.HasOne("Koop.Models.Product", "Product")
                        .WithMany("OrderedItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_ordered_items_product_id")
                        .IsRequired();

                    b.Navigation("Coop");

                    b.Navigation("Order");

                    b.Navigation("OrderStatus");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koop.Models.Product", b =>
                {
                    b.HasOne("Koop.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("fk_products_supplier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koop.Models.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .HasConstraintName("fk_products_unit_id")
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Koop.Models.ProductCategory", b =>
                {
                    b.HasOne("Koop.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("fk_product_categories_category_id")
                        .IsRequired();

                    b.HasOne("Koop.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_product_categories_product_id")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Koop.Models.Supplier", b =>
                {
                    b.HasOne("Koop.Models.Cooperator", "Opro")
                        .WithMany("Suppliers")
                        .HasForeignKey("OproId")
                        .HasConstraintName("fk_suppliers_coop_id")
                        .IsRequired();

                    b.Navigation("Opro");
                });

            modelBuilder.Entity("Koop.Models.Work", b =>
                {
                    b.HasOne("Koop.Models.Cooperator", "Coop")
                        .WithMany("Works")
                        .HasForeignKey("CoopId")
                        .HasConstraintName("fk_works_coop_id")
                        .IsRequired();

                    b.HasOne("Koop.Models.WorkType", "WorkType")
                        .WithMany("Works")
                        .HasForeignKey("WorkTypeId")
                        .HasConstraintName("fk_works_work_type_id")
                        .IsRequired();

                    b.Navigation("Coop");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("Koop.Models.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Koop.Models.Cooperator", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("Favorities");

                    b.Navigation("OrderedItems");

                    b.Navigation("Suppliers");

                    b.Navigation("Works");
                });

            modelBuilder.Entity("Koop.Models.Function", b =>
                {
                    b.Navigation("Cooperators");
                });

            modelBuilder.Entity("Koop.Models.Fund", b =>
                {
                    b.Navigation("Cooperators");
                });

            modelBuilder.Entity("Koop.Models.Order", b =>
                {
                    b.Navigation("OrderedItems");
                });

            modelBuilder.Entity("Koop.Models.OrderStatus", b =>
                {
                    b.Navigation("OrderedItems");
                });

            modelBuilder.Entity("Koop.Models.Product", b =>
                {
                    b.Navigation("AvailableQuantities");

                    b.Navigation("Favorities");

                    b.Navigation("OrderedItems");

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Koop.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Koop.Models.Unit", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Koop.Models.WorkType", b =>
                {
                    b.Navigation("Works");
                });
#pragma warning restore 612, 618
        }
    }
}
