using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreApp.Migrations
{
    public partial class spellcheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrdouctDes",
                table: "ProductTbl",
                newName: "ProductDes");

            migrationBuilder.RenameColumn(
                name: "PrdouctID",
                table: "ProductTbl",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "MainCateogryID",
                table: "MainCategoryTbl",
                newName: "MainCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDes",
                table: "ProductTbl",
                newName: "PrdouctDes");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductTbl",
                newName: "PrdouctID");

            migrationBuilder.RenameColumn(
                name: "MainCategoryID",
                table: "MainCategoryTbl",
                newName: "MainCateogryID");
        }
    }
}
