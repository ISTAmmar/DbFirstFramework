namespace Sigma.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableAdded1223 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.User", "Code", c => c.String(maxLength:5));
            //AddColumn("dbo.User", "CreatedBy", c => c.Int());
            //AddColumn("dbo.User", "CreatedOn", c => c.DateTime());
            //AddColumn("dbo.User", "UpdatedBy", c => c.Int());
            //AddColumn("dbo.User", "UpdatedOn", c => c.DateTime());
            //AddColumn("dbo.User", "ArchivedBy", c => c.Int());
            //AddColumn("dbo.User", "ArchivedOn", c => c.DateTime());
            //AddColumn("dbo.User", "LastUpdateDate", c => c.DateTime());

            //AddColumn("dbo.User", "IsArchived", c => c.Boolean(nullable: false));

            //DropColumn("dbo.User", "IsArchived");
        }

        public override void Down()
        {
            
        }
    }
}
