using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_konserlerim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Konserler_KonserDestinationID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Konserler_Guides_GuideID",
                table: "Konserler");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Konserler_KonserDestinationID",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Konserler",
                table: "Konserler");

            migrationBuilder.RenameTable(
                name: "Konserler",
                newName: "Konserlerim");

            migrationBuilder.RenameColumn(
                name: "KonserDestinationID",
                table: "Reservations",
                newName: "KonserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_KonserDestinationID",
                table: "Reservations",
                newName: "IX_Reservations_KonserID");

            migrationBuilder.RenameColumn(
                name: "KonserDestinationID",
                table: "Comments",
                newName: "KonserID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_KonserDestinationID",
                table: "Comments",
                newName: "IX_Comments_KonserID");

            migrationBuilder.RenameColumn(
                name: "DestinationID",
                table: "Konserlerim",
                newName: "KonserID");

            migrationBuilder.RenameIndex(
                name: "IX_Konserler_GuideID",
                table: "Konserlerim",
                newName: "IX_Konserlerim_GuideID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Konserlerim",
                table: "Konserlerim",
                column: "KonserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Konserlerim_KonserID",
                table: "Comments",
                column: "KonserID",
                principalTable: "Konserlerim",
                principalColumn: "KonserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Konserlerim_Guides_GuideID",
                table: "Konserlerim",
                column: "GuideID",
                principalTable: "Guides",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Konserlerim_KonserID",
                table: "Reservations",
                column: "KonserID",
                principalTable: "Konserlerim",
                principalColumn: "KonserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Konserlerim_KonserID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Konserlerim_Guides_GuideID",
                table: "Konserlerim");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Konserlerim_KonserID",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Konserlerim",
                table: "Konserlerim");

            migrationBuilder.RenameTable(
                name: "Konserlerim",
                newName: "Konserler");

            migrationBuilder.RenameColumn(
                name: "KonserID",
                table: "Reservations",
                newName: "KonserDestinationID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_KonserID",
                table: "Reservations",
                newName: "IX_Reservations_KonserDestinationID");

            migrationBuilder.RenameColumn(
                name: "KonserID",
                table: "Comments",
                newName: "KonserDestinationID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_KonserID",
                table: "Comments",
                newName: "IX_Comments_KonserDestinationID");

            migrationBuilder.RenameColumn(
                name: "KonserID",
                table: "Konserler",
                newName: "DestinationID");

            migrationBuilder.RenameIndex(
                name: "IX_Konserlerim_GuideID",
                table: "Konserler",
                newName: "IX_Konserler_GuideID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Konserler",
                table: "Konserler",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Konserler_KonserDestinationID",
                table: "Comments",
                column: "KonserDestinationID",
                principalTable: "Konserler",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Konserler_Guides_GuideID",
                table: "Konserler",
                column: "GuideID",
                principalTable: "Guides",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Konserler_KonserDestinationID",
                table: "Reservations",
                column: "KonserDestinationID",
                principalTable: "Konserler",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
