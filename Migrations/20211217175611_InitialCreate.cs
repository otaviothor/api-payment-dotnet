﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardOwnerName = table.Column<string>(type: "varchar(100)", nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(16)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "varchar(5)", nullable: true),
                    SecurityCode = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
