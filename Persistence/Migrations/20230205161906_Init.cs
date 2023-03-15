using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "auditory_tags",
                columns: table => new
                {
                    auditorytagid = table.Column<Guid>(name: "auditory_tag_id", type: "uniqueidentifier", nullable: false),
                    tag = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auditory_tags", x => x.auditorytagid);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeid = table.Column<Guid>(name: "employee_id", type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    patronymic = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employeeid);
                });

            migrationBuilder.CreateTable(
                name: "keys",
                columns: table => new
                {
                    keyid = table.Column<Guid>(name: "key_id", type: "uniqueidentifier", nullable: false),
                    auditoryname = table.Column<string>(name: "auditory_name", type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keys", x => x.keyid);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    eventid = table.Column<Guid>(name: "event_id", type: "uniqueidentifier", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    employeeid = table.Column<Guid>(name: "employee_id", type: "uniqueidentifier", nullable: true),
                    keyid = table.Column<Guid>(name: "key_id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.eventid);
                    table.ForeignKey(
                        name: "FK_events_employees_employee_id",
                        column: x => x.employeeid,
                        principalTable: "employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_events_keys_key_id",
                        column: x => x.keyid,
                        principalTable: "keys",
                        principalColumn: "key_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "key_auditory_tags",
                columns: table => new
                {
                    keyauditorytagid = table.Column<Guid>(name: "key_auditory_tag_id", type: "uniqueidentifier", nullable: false),
                    keyid = table.Column<Guid>(name: "key_id", type: "uniqueidentifier", nullable: false),
                    auditorytagid = table.Column<Guid>(name: "auditory_tag_id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_key_auditory_tags", x => x.keyauditorytagid);
                    table.UniqueConstraint("AK_key_auditory_tags_key_id_auditory_tag_id", x => new { x.keyid, x.auditorytagid });
                    table.ForeignKey(
                        name: "FK_key_auditory_tags_auditory_tags_auditory_tag_id",
                        column: x => x.auditorytagid,
                        principalTable: "auditory_tags",
                        principalColumn: "auditory_tag_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_key_auditory_tags_keys_key_id",
                        column: x => x.keyid,
                        principalTable: "keys",
                        principalColumn: "key_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    permissionid = table.Column<Guid>(name: "permission_id", type: "uniqueidentifier", nullable: false),
                    employeeid = table.Column<Guid>(name: "employee_id", type: "uniqueidentifier", nullable: false),
                    keyid = table.Column<Guid>(name: "key_id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => x.permissionid);
                    table.UniqueConstraint("AK_permissions_key_id_employee_id", x => new { x.keyid, x.employeeid });
                    table.ForeignKey(
                        name: "FK_permissions_employees_employee_id",
                        column: x => x.employeeid,
                        principalTable: "employees",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_permissions_keys_key_id",
                        column: x => x.keyid,
                        principalTable: "keys",
                        principalColumn: "key_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_events_employee_id",
                table: "events",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_events_key_id",
                table: "events",
                column: "key_id");

            migrationBuilder.CreateIndex(
                name: "IX_key_auditory_tags_auditory_tag_id",
                table: "key_auditory_tags",
                column: "auditory_tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_permissions_employee_id",
                table: "permissions",
                column: "employee_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "key_auditory_tags");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "auditory_tags");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "keys");
        }
    }
}
