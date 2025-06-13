using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MWSProductApp.Migrations
{
    /// <inheritdoc />
    public partial class MWSProductLoginFirstMIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_UserRefreshToken",
                columns: table => new
                {
                    RefreshTokenId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MWSLoginLoginId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserRefreshToken", x => x.RefreshTokenId);
                    table.ForeignKey(
                        name: "FK_tbl_UserRefreshToken_tbl_UserLogin_MWSLoginLoginId",
                        column: x => x.MWSLoginLoginId,
                        principalTable: "tbl_UserLogin",
                        principalColumn: "LoginId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserRoles", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserSetPassWord",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Security_Question_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Security_Question_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Security_Question_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Security_Question_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Captcha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserSetPassWord", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_refRoles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MWSUserRolesUserRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_refRoles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_tbl_refRoles_tbl_UserRoles_MWSUserRolesUserRoleId",
                        column: x => x.MWSUserRolesUserRoleId,
                        principalTable: "tbl_UserRoles",
                        principalColumn: "UserRoleId");
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserRegister",
                columns: table => new
                {
                    UserRegisterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MWSSetPasswordUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MWSUserRolesUserRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserRegister", x => x.UserRegisterId);
                    table.ForeignKey(
                        name: "FK_tbl_UserRegister_tbl_UserRoles_MWSUserRolesUserRoleId",
                        column: x => x.MWSUserRolesUserRoleId,
                        principalTable: "tbl_UserRoles",
                        principalColumn: "UserRoleId");
                    table.ForeignKey(
                        name: "FK_tbl_UserRegister_tbl_UserSetPassWord_MWSSetPasswordUserId",
                        column: x => x.MWSSetPasswordUserId,
                        principalTable: "tbl_UserSetPassWord",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_refRoles_MWSUserRolesUserRoleId",
                table: "tbl_refRoles",
                column: "MWSUserRolesUserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRefreshToken_MWSLoginLoginId",
                table: "tbl_UserRefreshToken",
                column: "MWSLoginLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRegister_MWSSetPasswordUserId",
                table: "tbl_UserRegister",
                column: "MWSSetPasswordUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRegister_MWSUserRolesUserRoleId",
                table: "tbl_UserRegister",
                column: "MWSUserRolesUserRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_refRoles");

            migrationBuilder.DropTable(
                name: "tbl_UserRefreshToken");

            migrationBuilder.DropTable(
                name: "tbl_UserRegister");

            migrationBuilder.DropTable(
                name: "tbl_UserRoles");

            migrationBuilder.DropTable(
                name: "tbl_UserSetPassWord");
        }
    }
}
