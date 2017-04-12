using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeseMVC.Migrations
{
    public partial class AddMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenu_Cheeses_CheeseID",
                table: "CheeseMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenu_Menu_MenuID",
                table: "CheeseMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheeseMenu",
                table: "CheeseMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menu",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheeseMenus",
                table: "CheeseMenu",
                columns: new[] { "CheeseID", "MenuID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenus_Cheeses_CheeseID",
                table: "CheeseMenu",
                column: "CheeseID",
                principalTable: "Cheeses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenus_Menus_MenuID",
                table: "CheeseMenu",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_CheeseMenu_MenuID",
                table: "CheeseMenu",
                newName: "IX_CheeseMenus_MenuID");

            migrationBuilder.RenameIndex(
                name: "IX_CheeseMenu_CheeseID",
                table: "CheeseMenu",
                newName: "IX_CheeseMenus_CheeseID");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");

            migrationBuilder.RenameTable(
                name: "CheeseMenu",
                newName: "CheeseMenus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenus_Cheeses_CheeseID",
                table: "CheeseMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenus_Menus_MenuID",
                table: "CheeseMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheeseMenus",
                table: "CheeseMenus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menus",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheeseMenu",
                table: "CheeseMenus",
                columns: new[] { "CheeseID", "MenuID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenu_Cheeses_CheeseID",
                table: "CheeseMenus",
                column: "CheeseID",
                principalTable: "Cheeses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenu_Menu_MenuID",
                table: "CheeseMenus",
                column: "MenuID",
                principalTable: "Menus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_CheeseMenus_MenuID",
                table: "CheeseMenus",
                newName: "IX_CheeseMenu_MenuID");

            migrationBuilder.RenameIndex(
                name: "IX_CheeseMenus_CheeseID",
                table: "CheeseMenus",
                newName: "IX_CheeseMenu_CheeseID");

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");

            migrationBuilder.RenameTable(
                name: "CheeseMenus",
                newName: "CheeseMenu");
        }
    }
}
