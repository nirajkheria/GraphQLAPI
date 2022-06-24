using GraphQLAPI.Data;
using GraphQLAPI.Interfaces;
using GraphQLAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Services
{
    public class ReservationService : IReservation
    {
        private readonly GraphQLDbContext dbContext;

        public ReservationService(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            dbContext.Reservations.Add(reservation);
            dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return dbContext.Reservations.ToList();
        }
    }
}
