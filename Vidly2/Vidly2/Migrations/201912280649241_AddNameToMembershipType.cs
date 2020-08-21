namespace Vidly2.Migrations
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;

    /*[GeneratedCode("EntityFramework.Migrations","6.1.1-30610")]
    public sealed partial class AddNameToMembershipType : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddNameToMembershipType));
        string IMigrationMetadata.Id
        {
            get { return "201912280649241_AddNameToMembershipType.Designer"; }
        }

        string IMigrationMetadata.Source
        {
            get { return null; }
        }

        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }*/

    public partial class AddNameToMembershipTypeDesigner: DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }


}
