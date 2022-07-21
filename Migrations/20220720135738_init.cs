using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.net_student.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<double>(type: "float", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 101, "Admin" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 102, "Developer" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "DepartmentId", "Email", "EnrollmentDate", "Gender", "Name", "Phone", "country" },
                values: new object[] { 1, 21, 101, "aaa@gmail.com", "01-01-2022", "Male", "Tim", 9876543212.0, "india" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "DepartmentId", "Email", "EnrollmentDate", "Gender", "Name", "Phone", "country" },
                values: new object[] { 2, 22, 101, "bbb@gmail.com", "02-01-2022", "Female", "jim", 9876543219.0, "india" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
