using GraphQL.Types;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<MenuType>>("reservations", resolve: context => {
                return reservationService.GetReservations();
            });
        }
    }
}
