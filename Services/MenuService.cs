using GraphQLAPI.Data;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Services
{
    public class MenuService : IMenu
    {
        private readonly GraphQLDbContext dbContext;

        public MenuService(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
           return dbContext.Menus.ToList();
        }
    }
}
