using GraphQL;
using GraphQL.Types;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Models;
using GraphQLAPI.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                resolve: context => { return menuService.AddMenu(context.GetArgument<Menu>("menu")); });

        }
    }
}
