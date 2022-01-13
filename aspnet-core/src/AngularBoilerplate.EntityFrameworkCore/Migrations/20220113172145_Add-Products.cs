using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularBoilerplate.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                table: "AbpTenantConnectionStrings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpRoles_RoleId",
                table: "AbpUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenantConnectionStrings",
                table: "AbpTenantConnectionStrings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSecurityLogs",
                table: "AbpSecurityLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLinkUsers",
                table: "AbpLinkUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpClaimTypes",
                table: "AbpClaimTypes");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "AppTenants");

            migrationBuilder.RenameTable(
                name: "AbpTenantConnectionStrings",
                newName: "AppTenantConnectionStrings");

            migrationBuilder.RenameTable(
                name: "AbpSecurityLogs",
                newName: "AppSecurityLogs");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "AppRoles");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "AppOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AbpLinkUsers",
                newName: "AppLinkUsers");

            migrationBuilder.RenameTable(
                name: "AbpClaimTypes",
                newName: "AppClaimTypes");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_Name",
                table: "AppTenants",
                newName: "IX_AppTenants_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_UserId",
                table: "AppSecurityLogs",
                newName: "IX_AppSecurityLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_Identity",
                table: "AppSecurityLogs",
                newName: "IX_AppSecurityLogs_TenantId_Identity");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_ApplicationName",
                table: "AppSecurityLogs",
                newName: "IX_AppSecurityLogs_TenantId_ApplicationName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSecurityLogs_TenantId_Action",
                table: "AppSecurityLogs",
                newName: "IX_AppSecurityLogs_TenantId_Action");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_NormalizedName",
                table: "AppRoles",
                newName: "IX_AppRoles_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "AppOrganizationUnits",
                newName: "IX_AppOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_Code",
                table: "AppOrganizationUnits",
                newName: "IX_AppOrganizationUnits_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId",
                table: "AppLinkUsers",
                newName: "IX_AppLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTenants",
                table: "AppTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTenantConnectionStrings",
                table: "AppTenantConnectionStrings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppSecurityLogs",
                table: "AppSecurityLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppOrganizationUnits",
                table: "AppOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppLinkUsers",
                table: "AppLinkUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppClaimTypes",
                table: "AppClaimTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProducts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AppOrganizationUnits_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                column: "OrganizationUnitId",
                principalTable: "AppOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AppRoles_RoleId",
                table: "AbpOrganizationUnitRoles",
                column: "RoleId",
                principalTable: "AppRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AppRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AppRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserOrganizationUnits_AppOrganizationUnits_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                column: "OrganizationUnitId",
                principalTable: "AppOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AppRoles_RoleId",
                table: "AbpUserRoles",
                column: "RoleId",
                principalTable: "AppRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrganizationUnits_AppOrganizationUnits_ParentId",
                table: "AppOrganizationUnits",
                column: "ParentId",
                principalTable: "AppOrganizationUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTenantConnectionStrings_AppTenants_TenantId",
                table: "AppTenantConnectionStrings",
                column: "TenantId",
                principalTable: "AppTenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AppOrganizationUnits_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AppRoles_RoleId",
                table: "AbpOrganizationUnitRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AppRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserOrganizationUnits_AppOrganizationUnits_OrganizationUnitId",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AppRoles_RoleId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrganizationUnits_AppOrganizationUnits_ParentId",
                table: "AppOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTenantConnectionStrings_AppTenants_TenantId",
                table: "AppTenantConnectionStrings");

            migrationBuilder.DropTable(
                name: "AppProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTenants",
                table: "AppTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTenantConnectionStrings",
                table: "AppTenantConnectionStrings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppSecurityLogs",
                table: "AppSecurityLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppOrganizationUnits",
                table: "AppOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppLinkUsers",
                table: "AppLinkUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppClaimTypes",
                table: "AppClaimTypes");

            migrationBuilder.RenameTable(
                name: "AppTenants",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "AppTenantConnectionStrings",
                newName: "AbpTenantConnectionStrings");

            migrationBuilder.RenameTable(
                name: "AppSecurityLogs",
                newName: "AbpSecurityLogs");

            migrationBuilder.RenameTable(
                name: "AppRoles",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "AppOrganizationUnits",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AppLinkUsers",
                newName: "AbpLinkUsers");

            migrationBuilder.RenameTable(
                name: "AppClaimTypes",
                newName: "AbpClaimTypes");

            migrationBuilder.RenameIndex(
                name: "IX_AppTenants_Name",
                table: "AbpTenants",
                newName: "IX_AbpTenants_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AppSecurityLogs_TenantId_UserId",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AppSecurityLogs_TenantId_Identity",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_Identity");

            migrationBuilder.RenameIndex(
                name: "IX_AppSecurityLogs_TenantId_ApplicationName",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_ApplicationName");

            migrationBuilder.RenameIndex(
                name: "IX_AppSecurityLogs_TenantId_Action",
                table: "AbpSecurityLogs",
                newName: "IX_AbpSecurityLogs_TenantId_Action");

            migrationBuilder.RenameIndex(
                name: "IX_AppRoles_NormalizedName",
                table: "AbpRoles",
                newName: "IX_AbpRoles_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrganizationUnits_Code",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AppLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId",
                table: "AbpLinkUsers",
                newName: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenantConnectionStrings",
                table: "AbpTenantConnectionStrings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSecurityLogs",
                table: "AbpSecurityLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLinkUsers",
                table: "AbpLinkUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpClaimTypes",
                table: "AbpClaimTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                column: "OrganizationUnitId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                table: "AbpOrganizationUnitRoles",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                table: "AbpTenantConnectionStrings",
                column: "TenantId",
                principalTable: "AbpTenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                column: "OrganizationUnitId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpRoles_RoleId",
                table: "AbpUserRoles",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
