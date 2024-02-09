using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(2024022091319)]
    public class _202402091319_AddBassGuitarTable : Migration
    {
        public override void Up()
        {
            Create.Table("BassGuitars")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Brand").AsString(50).NotNullable()
                .WithColumn("Model").AsString(50).NotNullable()
                .WithColumn("Price").AsDecimal(18, 3).NotNullable()
                .WithColumn("Count").AsInt32().NotNullable();

            Create.Table("Users")
              .WithColumn("Id").AsInt32().Identity().PrimaryKey()
              .WithColumn("Name").AsString(50).NotNullable()
              .WithColumn("Email").AsString(50).NotNullable()
              .WithColumn("PhoneNumber").AsString(50).NotNullable();
        }
        public override void Down()
        {
            Delete.Table("BassGuitars");
            Delete.Table("Users");
        }

       
    }
}
