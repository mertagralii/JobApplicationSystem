using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplicationSystem.Migrations
{
    /// <inheritdoc />
    public partial class DeleteResumeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Skill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Referance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkId",
                table: "Personal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Link",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Link",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Language",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Experience",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Certificate",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Referance");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "WorkId",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Link");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Link");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Certificate");

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: true),
                    ExperienceId = table.Column<int>(type: "int", nullable: true),
                    LanguagesId = table.Column<int>(type: "int", nullable: true),
                    LinkId = table.Column<int>(type: "int", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: true),
                    ReferanceId = table.Column<int>(type: "int", nullable: true),
                    SkillsId = table.Column<int>(type: "int", nullable: true),
                    WorkCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.Id);
                });
        }
    }
}
