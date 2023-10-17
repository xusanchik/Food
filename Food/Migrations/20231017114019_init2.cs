using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "menuId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "OrderHistorie",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "functionsId",
                table: "Menus",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "profilId",
                table: "Menus",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Foods",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Foods",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_menuId",
                table: "Users",
                column: "menuId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RegistrationId",
                table: "Users",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_functionsId",
                table: "Menus",
                column: "functionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_profilId",
                table: "Menus",
                column: "profilId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MenuId",
                table: "Foods",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_OrdersId",
                table: "Foods",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Menus_MenuId",
                table: "Foods",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Orders_OrdersId",
                table: "Foods",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Functions_functionsId",
                table: "Menus",
                column: "functionsId",
                principalTable: "Functions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_profiles_profilId",
                table: "Menus",
                column: "profilId",
                principalTable: "profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Menus_menuId",
                table: "Users",
                column: "menuId",
                principalTable: "Menus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_registrations_RegistrationId",
                table: "Users",
                column: "RegistrationId",
                principalTable: "registrations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Menus_MenuId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Orders_OrdersId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Functions_functionsId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_profiles_profilId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Menus_menuId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_registrations_RegistrationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_menuId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RegistrationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Menus_functionsId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_profilId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Foods_MenuId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_OrdersId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "menuId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "OrderHistorie");

            migrationBuilder.DropColumn(
                name: "functionsId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "profilId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Foods");
        }
    }
}
