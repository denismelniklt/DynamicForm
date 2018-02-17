using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Domain.Migrations
{
    public partial class CreateTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyName_NameId",
                table: "Property");

            migrationBuilder.DropTable(
                name: "PropertyName");

            migrationBuilder.DropIndex(
                name: "IX_Property_NameId",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "Property");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Property",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Property");

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "Property",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyName", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_NameId",
                table: "Property",
                column: "NameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyName_NameId",
                table: "Property",
                column: "NameId",
                principalTable: "PropertyName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
