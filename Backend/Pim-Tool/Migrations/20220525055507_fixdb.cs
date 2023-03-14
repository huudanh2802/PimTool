using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Pim_Tool.Migrations {
    public partial class fixdb : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "ProjectDTO");

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 1m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 2m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 3m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 4m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 5m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 6m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 7m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 8m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 9m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 375, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 1m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 369, DateTimeKind.Local).AddTicks(976), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 2m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5718), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 3m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5734), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 4m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5738), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 5m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5740), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 6m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5745), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 7m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5748), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 8m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5750), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 9m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5752), "PLA" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 10m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5756), "PLA" });
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "ProjectDTO",
                columns: table => new {
                    Id = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Group_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Project_Number = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_ProjectDTO", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 1m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 2m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 3m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 4m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 5m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 6m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 7m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 8m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 9m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 23, 15, 21, 26, 351, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 1m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 343, DateTimeKind.Local).AddTicks(4773), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 2m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(80), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 3m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(95), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 4m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(99), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 5m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(101), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 6m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(106), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 7m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(109), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 8m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(111), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 9m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(114), "FIN" });

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 10m,
                columns: new[] { "START_DATE", "STATUS" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 21, 26, 345, DateTimeKind.Local).AddTicks(118), "FIN" });
        }
    }
}
