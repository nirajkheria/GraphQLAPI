using GraphQLAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();

        Menu AddMenu(Menu menu);
    }
}
