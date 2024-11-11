using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImportExport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsertionDEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeId", "Age", "DateOfBirth", "Departement", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 39, new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Alice Dupont", "0997916876" },
                    { 2, 34, new DateTime(1990, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Bernard Lefevre", "0997916877" },
                    { 3, 36, new DateTime(1988, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Caroline Martin", "0997916878" },
                    { 4, 32, new DateTime(1992, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "David Dubois", "0997916879" },
                    { 5, 33, new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Daniel Kadima", "0997916880" },
                    { 6, 38, new DateTime(1986, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Elisabeth Garnier", "0997916881" },
                    { 7, 40, new DateTime(1984, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "François Lemoine", "0997916882" },
                    { 8, 33, new DateTime(1991, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Gabrielle Dumont", "0997916883" },
                    { 9, 41, new DateTime(1983, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Henri Clément", "0997916884" },
                    { 10, 29, new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Isabelle Lefranc", "0997916885" },
                    { 11, 37, new DateTime(1987, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Julien Moreau", "0997916886" },
                    { 12, 30, new DateTime(1994, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Katherine Bernard", "0997916887" },
                    { 13, 43, new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Louis Lefevre", "0997916888" },
                    { 14, 31, new DateTime(1993, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Marie Lefevre", "0997916889" },
                    { 15, 34, new DateTime(1990, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Nicolas Dufresne", "0997916890" },
                    { 16, 32, new DateTime(1992, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Olivier Vidal", "0997916891" },
                    { 17, 35, new DateTime(1989, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Pauline Chretien", "0997916892" },
                    { 18, 38, new DateTime(1986, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Quentin Renaud", "0997916893" },
                    { 19, 33, new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Raphaël Dufresne", "0997916894" },
                    { 20, 34, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Sophie Berger", "0997916895" },
                    { 21, 39, new DateTime(1985, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Thomas Lefranc", "0997916896" },
                    { 22, 36, new DateTime(1988, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Ursula David", "0997916897" },
                    { 23, 30, new DateTime(1994, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Vincent Boucher", "0997916898" },
                    { 24, 32, new DateTime(1992, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Wendy Dumont", "0997916899" },
                    { 25, 37, new DateTime(1987, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Xavier Girard", "0997916900" },
                    { 26, 35, new DateTime(1989, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Yannick Bernard", "0997916901" },
                    { 27, 33, new DateTime(1991, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Zoe Lefevre", "0997916902" },
                    { 28, 43, new DateTime(1980, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Noel Kazadi", "123-456-7890" },
                    { 29, 38, new DateTime(1985, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Joel Kirengo", "234-567-8901" },
                    { 30, 31, new DateTime(1992, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Joel Muhindo", "345-678-9012" },
                    { 31, 35, new DateTime(1988, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Claudien Green", "456-789-0123" },
                    { 32, 33, new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Jonathan Mutendi", "567-890-1234" },
                    { 33, 43, new DateTime(1980, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Gabriel Kanyibu", "0997916872" },
                    { 34, 38, new DateTime(1985, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Bob Smith", "0997916873" },
                    { 35, 38, new DateTime(1985, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Bob Smith", "0997916873" },
                    { 36, 38, new DateTime(1985, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Bob Smith", "0997916873" },
                    { 37, 31, new DateTime(1992, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Charlie Brown", "0997916874" },
                    { 38, 35, new DateTime(1988, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Diana Green", "0997916875" },
                    { 39, 33, new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Edward White", "0997916876" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeId",
                keyValue: 39);
        }
    }
}
