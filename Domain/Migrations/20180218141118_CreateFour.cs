using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Domain.Migrations
{
    public partial class CreateFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentValueId",
                table: "Property",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Property_CurrentValueId",
                table: "Property",
                column: "CurrentValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyValue_CurrentValueId",
                table: "Property",
                column: "CurrentValueId",
                principalTable: "PropertyValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyValue_CurrentValueId",
                table: "Property");

            migrationBuilder.DropIndex(
                name: "IX_Property_CurrentValueId",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "CurrentValueId",
                table: "Property");
        }
    }
}
