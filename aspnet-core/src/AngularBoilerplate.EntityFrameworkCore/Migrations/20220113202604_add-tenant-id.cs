using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularBoilerplate.Migrations
{
    public partial class addtenantid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "AppProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AppProducts");
        }
    }
}
