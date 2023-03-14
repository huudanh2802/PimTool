using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Pim_Tool.Migrations {
    public partial class ProjectEmployeeInheritBaseEntity : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 1m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 2m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 3m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 4m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 5m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 6m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 7m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 8m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 9m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 661, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 1m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 655, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 2m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 3m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 4m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 5m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 6m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 7m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 8m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 9m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 10m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 13, 41, 7, 656, DateTimeKind.Local).AddTicks(7040));
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
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
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 369, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 2m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 3m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 4m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 5m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 6m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 7m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 8m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 9m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 10m,
                column: "START_DATE",
                value: new DateTime(2022, 5, 25, 12, 55, 7, 370, DateTimeKind.Local).AddTicks(5756));
        }
    }
}
