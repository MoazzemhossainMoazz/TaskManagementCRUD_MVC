using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignTask",
                table: "AssignTask");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "AssignTask",
                newName: "AssignTasks");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "AssignTasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Taskid",
                table: "AssignTasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TaskModelsId",
                table: "AssignTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserModelsId",
                table: "AssignTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignTasks",
                table: "AssignTasks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AssignTasks_TaskModelsId",
                table: "AssignTasks",
                column: "TaskModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignTasks_UserModelsId",
                table: "AssignTasks",
                column: "UserModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignTasks_Tasks_TaskModelsId",
                table: "AssignTasks",
                column: "TaskModelsId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignTasks_Users_UserModelsId",
                table: "AssignTasks",
                column: "UserModelsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignTasks_Tasks_TaskModelsId",
                table: "AssignTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignTasks_Users_UserModelsId",
                table: "AssignTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignTasks",
                table: "AssignTasks");

            migrationBuilder.DropIndex(
                name: "IX_AssignTasks_TaskModelsId",
                table: "AssignTasks");

            migrationBuilder.DropIndex(
                name: "IX_AssignTasks_UserModelsId",
                table: "AssignTasks");

            migrationBuilder.DropColumn(
                name: "TaskModelsId",
                table: "AssignTasks");

            migrationBuilder.DropColumn(
                name: "UserModelsId",
                table: "AssignTasks");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameTable(
                name: "AssignTasks",
                newName: "AssignTask");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AssignTask",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Taskid",
                table: "AssignTask",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignTask",
                table: "AssignTask",
                column: "Id");
        }
    }
}
