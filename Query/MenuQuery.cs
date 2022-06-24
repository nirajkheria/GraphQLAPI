using GraphQL.Types;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context => {
                return menuService.GetMenus();
            });
        }
    }
}
