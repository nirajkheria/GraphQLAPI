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
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservtionService)
        {
            Field<ReservationType>("createReservation", arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
                resolve: context => { return reservtionService.AddReservation(context.GetArgument<Reservation>("reservation")); });

        }
    }
}
