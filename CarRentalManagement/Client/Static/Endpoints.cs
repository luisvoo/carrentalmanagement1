using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MakesEndpoint =$"{Prefix}/Makes";
        public static readonly string ModelsEndpoint = $"{Prefix}/Models";
        public static readonly string ColoursEndpoint=$"{Prefix}/Colours";
        public static readonly string VehiclesEndpoint=$"{Prefix}/Vehicles";
        public static readonly string CustomersEndpoint=$"{Prefix}/Customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/Bookings";

    }
}
