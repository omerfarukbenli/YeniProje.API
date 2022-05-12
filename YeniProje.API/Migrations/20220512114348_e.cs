using Microsoft.EntityFrameworkCore.Migrations;

namespace YeniProje.API.Migrations
{
    public partial class e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_Order_Id1_OrderCustomer_Id",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Order_Id1",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderCustomer_Id",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_Order_Id1_OrderCustomer_Id",
                table: "OrderDetails",
                columns: new[] { "Order_Id1", "OrderCustomer_Id" },
                principalTable: "Orders",
                principalColumns: new[] { "Order_Id", "Customer_Id" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_Order_Id1_OrderCustomer_Id",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Order_Id1",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderCustomer_Id",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_Order_Id1_OrderCustomer_Id",
                table: "OrderDetails",
                columns: new[] { "Order_Id1", "OrderCustomer_Id" },
                principalTable: "Orders",
                principalColumns: new[] { "Order_Id", "Customer_Id" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
