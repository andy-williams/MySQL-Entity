namespace MySQL_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Length_Constraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Forenames", c => c.String(maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Authors", "Surname", c => c.String(maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Books", "Title", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(unicode: false));
            AlterColumn("dbo.Authors", "Surname", c => c.String(unicode: false));
            AlterColumn("dbo.Authors", "Forenames", c => c.String(unicode: false));
        }
    }
}
