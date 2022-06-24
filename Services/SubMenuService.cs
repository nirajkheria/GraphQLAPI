using GraphQLAPI.Data;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Services
{
    public class SubMenuService : ISubMenu
    {
        private readonly GraphQLDbContext dbContext;

        public SubMenuService(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            dbContext.SubMenus.Add(subMenu);
            dbContext.SaveChanges();
            return subMenu;
        }

        public List<SubMenu> GetSubMenus()
        {
            return dbContext.SubMenus.ToList();
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return dbContext.SubMenus.Where(x => x.MenuId == menuId).ToList();
        }
    }
}
