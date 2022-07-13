namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class usersignup : DbMigration
    {
        public override void Up()
        {

            Sql(@"create table user_SignUp(
                    id int primary key identity(1,1),
                    username varchar(80) NOT NULL,
                    password varchar(80) NOT NULL,
                    confirmpassword varchar(80) Not Null
                      
                );");
        }

        public override void Down()
        {
        }
    }
}
