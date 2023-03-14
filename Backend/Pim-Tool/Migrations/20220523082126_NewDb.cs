using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Pim_Tool.Migrations {
    public partial class NewDb : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new {
                    ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VISA = table.Column<string>(type: "char(3)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "varchar(50)", nullable: false),
                    LAST_NAME = table.Column<string>(type: "varchar(50)", nullable: false),
                    BIRTH_DAY = table.Column<DateTime>(type: "date", nullable: false),
                    VERSION = table.Column<decimal>(type: "decimal(10,0)", nullable: false, defaultValue: 1m)
                },
                constraints: table => {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDTO",
                columns: table => new {
                    Id = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Project_Number = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Group_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_ProjectDTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GROUP",
                columns: table => new {
                    ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GROUP_LEADER_ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false),
                    VERSION = table.Column<decimal>(type: "decimal(10,0)", nullable: false, defaultValue: 1m)
                },
                constraints: table => {
                    table.PrimaryKey("PK_GROUP", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GROUP_EMPLOYEE_GROUP_LEADER_ID",
                        column: x => x.GROUP_LEADER_ID,
                        principalTable: "EMPLOYEE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PROJECT",
                columns: table => new {
                    ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECT_NUMBER = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    NAME = table.Column<string>(type: "varchar(50)", nullable: false),
                    CUSTOMER = table.Column<string>(type: "varchar(50)", nullable: false),
                    STATUS = table.Column<string>(type: "char(3)", nullable: false, defaultValue: "NEW"),
                    START_DATE = table.Column<DateTime>(type: "date", nullable: false),
                    END_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    GROUP_ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false),
                    VERSION = table.Column<decimal>(type: "decimal(10,0)", nullable: false, defaultValue: 1m)
                },
                constraints: table => {
                    table.PrimaryKey("PK_PROJECT", x => x.ID);
                    table.CheckConstraint("CK_Project_Status", "STATUS='NEW'OR STATUS='PLA'OR STATUS='INP'OR STATUS='FIN'");
                    table.ForeignKey(
                        name: "FK_PROJECT_GROUP_GROUP_ID",
                        column: x => x.GROUP_ID,
                        principalTable: "GROUP",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PROJECT_EMPLOYEE",
                columns: table => new {
                    PROJECT_ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false),
                    EMPLOYEE_ID = table.Column<decimal>(type: "decimal(19,0)", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_PROJECT_EMPLOYEE", x => new { x.PROJECT_ID, x.EMPLOYEE_ID });
                    table.ForeignKey(
                        name: "FK_PROJECT_EMPLOYEE_EMPLOYEE_EMPLOYEE_ID",
                        column: x => x.EMPLOYEE_ID,
                        principalTable: "EMPLOYEE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PROJECT_EMPLOYEE_PROJECT_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECT",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "EMPLOYEE",
                columns: new[] { "ID", "BIRTH_DAY", "FIRST_NAME", "LAST_NAME", "VISA" },
                values: new object[,]
                {
                    { 1m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1166), "FirstName1", "LastName1", "AB1" },
                    { 2m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1444), "FirstName2", "LastName2", "AB2" },
                    { 3m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1451), "FirstName3", "LastName3", "AB3" },
                    { 4m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1493), "FirstName4", "LastName4", "AB4" },
                    { 5m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1496), "FirstName5", "LastName5", "AB5" },
                    { 6m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1501), "FirstName6", "LastName6", "AB6" },
                    { 7m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1505), "FirstName7", "LastName7", "AB7" },
                    { 8m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1508), "FirstName8", "LastName8", "AB8" },
                    { 9m, new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1510), "FirstName9", "LastName9", "AB9" }
                });

            migrationBuilder.InsertData(
                table: "GROUP",
                columns: new[] { "ID", "GROUP_LEADER_ID" },
                values: new object[] { 1m, 1m });

            migrationBuilder.InsertData(
                table: "GROUP",
                columns: new[] { "ID", "GROUP_LEADER_ID" },
                values: new object[] { 2m, 2m });

            migrationBuilder.InsertData(
                table: "PROJECT",
                columns: new[] { "ID", "CUSTOMER", "END_DATE", "GROUP_ID", "NAME", "PROJECT_NUMBER", "START_DATE", "STATUS" },
                values: new object[,]
                {
                    { 1m, "Customer1", null, 1m, "Test1", 1m, new DateTime(2022, 5, 23, 15, 21, 26, 343, DateTimeKind.Local).AddTicks(4773), "FIN" },
                    { 2m, "Customer2", null, 1m, "Test2", 2m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(80), "FIN" },
                    { 3m, "Customer3", null, 1m, "Test3", 3m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(95), "FIN" },
                    { 4m, "Customer4", null, 1m, "Test4", 4m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(99), "FIN" },
                    { 5m, "Customer5", null, 1m, "Test5", 5m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(101), "FIN" },
                    { 6m, "Customer6", null, 1m, "Test6", 6m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(106), "FIN" },
                    { 7m, "Customer7", null, 1m, "Test7", 7m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(109), "FIN" },
                    { 8m, "Customer8", null, 1m, "Test8", 8m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(111), "FIN" },
                    { 9m, "Customer9", null, 1m, "Test9", 9m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(114), "FIN" },
                    { 10m, "Customer10", null, 1m, "Test10", 10m, new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(118), "FIN" }
                });

            migrationBuilder.InsertData(
                table: "PROJECT_EMPLOYEE",
                columns: new[] { "EMPLOYEE_ID", "PROJECT_ID" },
                values: new object[,]
                {
                    { 1m, 1m },
                    { 2m, 1m },
                    { 2m, 2m },
                    { 2m, 3m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GROUP_GROUP_LEADER_ID",
                table: "GROUP",
                column: "GROUP_LEADER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_GROUP_ID",
                table: "PROJECT",
                column: "GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_PROJECT_NUMBER",
                table: "PROJECT",
                column: "PROJECT_NUMBER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PROJECT_EMPLOYEE_EMPLOYEE_ID",
                table: "PROJECT_EMPLOYEE",
                column: "EMPLOYEE_ID");
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "PROJECT_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "ProjectDTO");

            migrationBuilder.DropTable(
                name: "PROJECT");

            migrationBuilder.DropTable(
                name: "GROUP");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");
        }
    }
}
