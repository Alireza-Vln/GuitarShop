using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Migrations.Migrations
{
    [Migration(202402091706)]
    public class _202402091706_AddClassiceGuitarTable : Migration
    {
        public override void Up()
        {
            Create.Table("ClassicGuitars")
                 .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Brand").AsString(50).NotNullable()
               .WithColumn("Model").AsString(50).NotNullable()
               .WithColumn("Price").AsDecimal(18, 3).NotNullable()
               .WithColumn("Count").AsInt32().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("ClassicGuitars");
        }


    }
}
