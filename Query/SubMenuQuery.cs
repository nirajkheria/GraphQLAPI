using GraphQL;
using GraphQL.Types;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context =>
            {
                return subMenuService.GetSubMenus();
            });

            Field<ListGraphType<SubMenuType>>("submenuById", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),

                resolve: context => { return subMenuService.GetSubMenus(context.GetArgument<int>("id")); });
        }
    }
}