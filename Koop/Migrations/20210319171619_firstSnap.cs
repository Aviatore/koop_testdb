using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Koop.Migrations
{
    public partial class firstSnap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "functions",
                columns: table => new
                {
                    function_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    function_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functions", x => x.function_id);
                });

            migrationBuilder.CreateTable(
                name: "funds",
                columns: table => new
                {
                    fund_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funds", x => x.fund_id);
                });

            migrationBuilder.CreateTable(
                name: "order_status",
                columns: table => new
                {
                    order_status_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_status_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_status", x => x.order_status_id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    order_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_start_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    order_stop_date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.order_id);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    unit_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unit_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.unit_id);
                });

            migrationBuilder.CreateTable(
                name: "work_types",
                columns: table => new
                {
                    work_type_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    work_type = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work_types", x => x.work_type_id);
                });

            migrationBuilder.CreateTable(
                name: "cooperators",
                columns: table => new
                {
                    coop_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    info = table.Column<string>(type: "text", nullable: true),
                    debt = table.Column<double>(type: "float", nullable: true),
                    fund_id = table.Column<long>(type: "bigint", nullable: false),
                    function_id = table.Column<long>(type: "bigint", nullable: true),
                    basket_id = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cooperators", x => x.coop_id);
                    table.ForeignKey(
                        name: "fk_cooperators_function_id",
                        column: x => x.function_id,
                        principalTable: "functions",
                        principalColumn: "function_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cooperators_fund_id",
                        column: x => x.fund_id,
                        principalTable: "funds",
                        principalColumn: "fund_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "baskets",
                columns: table => new
                {
                    basket_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coop_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baskets", x => x.basket_id);
                    table.ForeignKey(
                        name: "fk_baskets_coop_id",
                        column: x => x.coop_id,
                        principalTable: "cooperators",
                        principalColumn: "coop_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    supplier_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    supplier_abbr = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    picture = table.Column<string>(type: "text", nullable: true),
                    order_closing_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    opro_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.supplier_id);
                    table.ForeignKey(
                        name: "fk_suppliers_coop_id",
                        column: x => x.opro_id,
                        principalTable: "cooperators",
                        principalColumn: "coop_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "works",
                columns: table => new
                {
                    work_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    work_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    duration = table.Column<double>(type: "float", nullable: false),
                    coop_id = table.Column<long>(type: "bigint", nullable: false),
                    work_type_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_works", x => x.work_id);
                    table.ForeignKey(
                        name: "fk_works_coop_id",
                        column: x => x.coop_id,
                        principalTable: "cooperators",
                        principalColumn: "coop_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_works_work_type_id",
                        column: x => x.work_type_id,
                        principalTable: "work_types",
                        principalColumn: "work_type_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    product_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    amount_in_magazine = table.Column<int>(type: "int", nullable: false),
                    magazine = table.Column<bool>(type: "bit", nullable: false),
                    amount_max = table.Column<int>(type: "int", nullable: true),
                    deposit = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    picture = table.Column<string>(type: "text", nullable: true, defaultValueSql: "('')"),
                    unit_id = table.Column<long>(type: "bigint", nullable: false),
                    supplier_id = table.Column<long>(type: "bigint", nullable: false),
                    available = table.Column<bool>(type: "bit", nullable: false),
                    blocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.product_id);
                    table.ForeignKey(
                        name: "fk_products_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "suppliers",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_products_unit_id",
                        column: x => x.unit_id,
                        principalTable: "units",
                        principalColumn: "unit_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "available_quantities",
                columns: table => new
                {
                    available_quantity_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_available_quantities", x => x.available_quantity_id);
                    table.ForeignKey(
                        name: "fk_available_quantities_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "favorities",
                columns: table => new
                {
                    favorite_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coop_id = table.Column<long>(type: "bigint", nullable: false),
                    product_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_favorities", x => x.favorite_id);
                    table.ForeignKey(
                        name: "fk_favorities_coop_id",
                        column: x => x.coop_id,
                        principalTable: "cooperators",
                        principalColumn: "coop_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_favorities_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ordered_items",
                columns: table => new
                {
                    ordered_item_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<long>(type: "bigint", nullable: false),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    coop_id = table.Column<long>(type: "bigint", nullable: false),
                    order_status_id = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordered_items", x => x.ordered_item_id);
                    table.ForeignKey(
                        name: "fk_ordered_items_coop_id",
                        column: x => x.coop_id,
                        principalTable: "cooperators",
                        principalColumn: "coop_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordered_items_order_id",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordered_items_order_status_id",
                        column: x => x.order_status_id,
                        principalTable: "order_status",
                        principalColumn: "order_status_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ordered_items_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product_categories",
                columns: table => new
                {
                    product_category_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    category_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_categories", x => x.product_category_id);
                    table.ForeignKey(
                        name: "fk_product_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_product_categories_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_available_quantities_product_id",
                table: "available_quantities",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_baskets_coop_id",
                table: "baskets",
                column: "coop_id");

            migrationBuilder.CreateIndex(
                name: "IX_cooperators_function_id",
                table: "cooperators",
                column: "function_id");

            migrationBuilder.CreateIndex(
                name: "IX_cooperators_fund_id",
                table: "cooperators",
                column: "fund_id");

            migrationBuilder.CreateIndex(
                name: "IX_favorities_coop_id",
                table: "favorities",
                column: "coop_id");

            migrationBuilder.CreateIndex(
                name: "IX_favorities_product_id",
                table: "favorities",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ordered_items_coop_id",
                table: "ordered_items",
                column: "coop_id");

            migrationBuilder.CreateIndex(
                name: "IX_ordered_items_order_id",
                table: "ordered_items",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_ordered_items_order_status_id",
                table: "ordered_items",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_ordered_items_product_id",
                table: "ordered_items",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_categories_category_id",
                table: "product_categories",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_categories_product_id",
                table: "product_categories",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_supplier_id",
                table: "products",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_unit_id",
                table: "products",
                column: "unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_opro_id",
                table: "suppliers",
                column: "opro_id");

            migrationBuilder.CreateIndex(
                name: "IX_works_coop_id",
                table: "works",
                column: "coop_id");

            migrationBuilder.CreateIndex(
                name: "IX_works_work_type_id",
                table: "works",
                column: "work_type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "available_quantities");

            migrationBuilder.DropTable(
                name: "baskets");

            migrationBuilder.DropTable(
                name: "favorities");

            migrationBuilder.DropTable(
                name: "ordered_items");

            migrationBuilder.DropTable(
                name: "product_categories");

            migrationBuilder.DropTable(
                name: "works");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "order_status");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "work_types");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "units");

            migrationBuilder.DropTable(
                name: "cooperators");

            migrationBuilder.DropTable(
                name: "functions");

            migrationBuilder.DropTable(
                name: "funds");
        }
    }
}
