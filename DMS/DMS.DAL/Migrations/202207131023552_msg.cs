namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class msg : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            create table contact(
                contactId int primary key identity(1,1),
                name varchar(80) not null ,
                Email varchar(90) not null,
                mobile int not null ,
                subject varchar(1000) not null
                );");
        }
        
        public override void Down()
        {
        }
    }
}
