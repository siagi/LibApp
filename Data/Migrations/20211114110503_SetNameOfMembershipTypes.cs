using Microsoft.EntityFrameworkCore.Migrations;

namespace LibApp.Data.Migrations
{
    public partial class SetNameOfMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Membership SET Name = 'Pay as you go' WHERE Id = 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
