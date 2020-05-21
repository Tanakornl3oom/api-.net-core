using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace test_project_api.Entity.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "users");

            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "users",
                newSchema: "public");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "public",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "users",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "public",
                table: "users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created",
                schema: "public",
                table: "users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "role",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users_role",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    User = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_role", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_role_role_Role",
                        column: x => x.Role,
                        principalSchema: "public",
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_role_users_User",
                        column: x => x.User,
                        principalSchema: "public",
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_role_Role",
                schema: "public",
                table: "users_role",
                column: "Role");

            migrationBuilder.CreateIndex(
                name: "IX_users_role_User",
                schema: "public",
                table: "users_role",
                column: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users_role",
                schema: "public");

            migrationBuilder.DropTable(
                name: "role",
                schema: "public");

            migrationBuilder.DropColumn(
                name: "created",
                schema: "public",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                schema: "public",
                newName: "users");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
