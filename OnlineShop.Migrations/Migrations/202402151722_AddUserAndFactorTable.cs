using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Migrations.Migrations
{
    [Migration(202402151722)]
    public class _202402151722_AddUserAndFactorTable : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
             .WithColumn("Id").AsInt32().Identity().PrimaryKey()
             .WithColumn("FirstName").AsString(50).NotNullable()
             .WithColumn("LastName").AsString(50).NotNullable()
             .WithColumn("Email").AsString(50).NotNullable()
             .WithColumn("PhoneNumber").AsString(50).NotNullable()
             .WithColumn("Address").AsString(50).NotNullable();

            Create.Table("Factors")
            .WithColumn("Id").AsInt32().Identity().PrimaryKey()
            .WithColumn("Name").AsString(50).NotNullable()
            .WithColumn("CreateAt").AsDateTime().NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable().ForeignKey();
        }
        public override void Down()
        {
            Delete.Table("Users");
        }


    }
}
