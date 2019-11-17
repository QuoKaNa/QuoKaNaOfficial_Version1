namespace Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data.ShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "quocit",
            //    Email = "quocitspkt@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Technology Education"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("quocitspkt@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
        private void CreateProductCategorySample(Data.ShopDbContext context)
        {
            if(context.ProductCategories.Count()==0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory(){Name="Điện lạnh",Alias="dien-lanh",Status=true},
                new ProductCategory(){Name="Viễn thông",Alias="vien-thong",Status=true},
                new ProductCategory(){Name="Đồ gia dụng",Alias="do-gia-dung",Status=true},
                new ProductCategory(){Name="Mỹ phẩm",Alias="my-pham",Status=true},
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
            
        }
    }
}
