using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreApp.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrderTbl_Users_UserID",
                table: "UserOrderTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UserTbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTbl",
                table: "UserTbl",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrderTbl_UserTbl_UserID",
                table: "UserOrderTbl",
                column: "UserID",
                principalTable: "UserTbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrderTbl_UserTbl_UserID",
                table: "UserOrderTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTbl",
                table: "UserTbl");

            migrationBuilder.RenameTable(
                name: "UserTbl",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrderTbl_Users_UserID",
                table: "UserOrderTbl",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
