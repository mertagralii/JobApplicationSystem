using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplicationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Baglama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Skill",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Referance",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Project",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Link",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Language",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Experience",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Education",
                newName: "PersonalIdId");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Certificate",
                newName: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_PersonalIdId",
                table: "Skill",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Referance_PersonalIdId",
                table: "Referance",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PersonalIdId",
                table: "Project",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_PersonalIdId",
                table: "Link",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_PersonalIdId",
                table: "Language",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_PersonalIdId",
                table: "Experience",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_PersonalIdId",
                table: "Education",
                column: "PersonalIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_PersonalIdId",
                table: "Certificate",
                column: "PersonalIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_Personal_PersonalIdId",
                table: "Certificate",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Personal_PersonalIdId",
                table: "Education",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Personal_PersonalIdId",
                table: "Experience",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Personal_PersonalIdId",
                table: "Language",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Personal_PersonalIdId",
                table: "Link",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Personal_PersonalIdId",
                table: "Project",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referance_Personal_PersonalIdId",
                table: "Referance",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_Personal_PersonalIdId",
                table: "Skill",
                column: "PersonalIdId",
                principalTable: "Personal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_Personal_PersonalIdId",
                table: "Certificate");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Personal_PersonalIdId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Personal_PersonalIdId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_Personal_PersonalIdId",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Personal_PersonalIdId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Personal_PersonalIdId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Referance_Personal_PersonalIdId",
                table: "Referance");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Personal_PersonalIdId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_PersonalIdId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Referance_PersonalIdId",
                table: "Referance");

            migrationBuilder.DropIndex(
                name: "IX_Project_PersonalIdId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Link_PersonalIdId",
                table: "Link");

            migrationBuilder.DropIndex(
                name: "IX_Language_PersonalIdId",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Experience_PersonalIdId",
                table: "Experience");

            migrationBuilder.DropIndex(
                name: "IX_Education_PersonalIdId",
                table: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Certificate_PersonalIdId",
                table: "Certificate");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Skill",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Referance",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Project",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Link",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Language",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Experience",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Education",
                newName: "PersonalId");

            migrationBuilder.RenameColumn(
                name: "PersonalIdId",
                table: "Certificate",
                newName: "PersonalId");
        }
    }
}
