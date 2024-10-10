namespace GameForumWeb.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ContextChange : DbMigration
    {
        public override void Up()
        {
            if (ColumnExists("dbo.Reviews", "UserId"))
            {
                DropForeignKey("dbo.Reviews", "UserId", "dbo.Users");
                RenameColumn(table: "dbo.Reviews", name: "UserId", newName: "User_Id");
                AlterColumn("dbo.Reviews", "User_Id", c => c.Int(nullable: false));

                CreateIndex("dbo.Reviews", "User_Id");
                AddForeignKey("dbo.Reviews", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
            }
        }

        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            AlterColumn("dbo.Reviews", "User_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Reviews", name: "User_Id", newName: "UserId");
            CreateIndex("dbo.Reviews", "UserId");
            AddForeignKey("dbo.Reviews", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }

        private bool ColumnExists(string tableName, string columnName)
        {
            return true; 
        }
    }
}
