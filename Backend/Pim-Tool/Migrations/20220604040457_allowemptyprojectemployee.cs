using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pim_Tool.Migrations
{
    public partial class allowemptyprojectemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 1m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 2m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 3m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 4m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 5m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 6m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 7m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 8m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "EMPLOYEE",
                keyColumn: "ID",
                keyValue: 9m,
                column: "BIRTH_DAY",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 493, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 1m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 486, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 2m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 3m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 4m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 5m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 6m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 7m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 8m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 9m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "PROJECT",
                keyColumn: "ID",
                keyValue: 10m,
                column: "START_DATE",
                value: new DateTime(2022, 6, 4, 11, 4, 57, 488, DateTimeKind.Local).AddTicks(5802));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
