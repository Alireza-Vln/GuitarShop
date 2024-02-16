using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Migrations.Migrations
{
    [Migration(202402161257)]
    public class _202402161257_AddGuitarTabel : Migration
    {
        public override void Up()
        {
            Create.Table("Guitars")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("GuitarModel").AsString(50).NotNullable()
                .WithColumn("GuitarBrand").AsString(50).NotNullable()
                .WithColumn("Price").AsDecimal(18, 3).NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Guitars");
        }


    }
}
