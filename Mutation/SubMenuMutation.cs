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
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
                resolve: context => { return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu")); });

        }
    }
}
