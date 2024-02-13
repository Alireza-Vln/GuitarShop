using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202402101212)]
    public class _202402101212_AddAcousticGuitarTable : Migration
    {
        public override void Up()
        {
            Create.Table("AcousticGuitars")
                 .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Brand").AsString(50).NotNullable()
               .WithColumn("Model").AsString(50).NotNullable()
               .WithColumn("Price").AsDecimal(18, 3).NotNullable()
               .WithColumn("Count").AsInt32().NotNullable();

        }
        public override void Down()
        {
            Delete.Table("AcousticGuitars");
        }

       
    }
}
