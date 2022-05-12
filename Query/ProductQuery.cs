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
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductService productService)
        {
            Field<ListGraphType<ProductType>>("products",resolve: context => { return productService.GetProducts(); });

            Field<ProductType>("product", arguments:  new QueryArguments(new QueryArgument<IntGraphType> { Name="id" }),
                
                resolve: context => { return productService.GetProductById(context.GetArgument<int>("id")); });
        }
    }
}
