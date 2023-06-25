using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountOwnerServer.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    AccountType = table.Column<string>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_account_owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "owner",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "AccountId", "AccountType", "DateCreated", "OwnerId" },
                values: new object[] { new Guid("a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc"), "Domestic", new DateTime(2010, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937") });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "AccountId", "AccountType", "DateCreated", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6"), "Domestic", new DateTime(2003, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") },
                    { new Guid("371b93f2-f8c5-4a32-894a-fc672741aa5b"), "Domestic", new DateTime(1999, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") },
                    { new Guid("670775db-ecc0-4b90-a9ab-37cd0d8e2801"), "Savings", new DateTime(1999, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") },
                    { new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"), "Domestic", new DateTime(1996, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("261e1685-cf26-494c-b17c-3546e65f5620") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_account_OwnerId",
                table: "account",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "owner");
        }
    }
}
