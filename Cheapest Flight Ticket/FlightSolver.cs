using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheapest_Flight_Ticket
{
    internal class FlightSolver
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            // Create a graph representation for direct flights
            Dictionary<(int, int), int> directFlights = new Dictionary<(int, int), int>();
            foreach (var flight in flights)
            {
                int fromCity = flight[0];
                int toCity = flight[1];
                int cost = flight[2];

                directFlights[(fromCity, toCity)] = cost;
            }

            // Initialize dp array
            int[,] dp = new int[n, k + 2];
            for (int city = 0; city < n; city++)
            {
                for (int stops = 0; stops <= k + 1; stops++)
                {
                    dp[city, stops] = int.MaxValue;
                }
            }
            dp[src, 0] = 0;

            // Dynamic programming loop
            for (int stops = 1; stops <= k + 1; stops++)
            {
                for (int city = 0; city < n; city++)
                {
                    dp[city, stops] = Math.Min(dp[city, stops], directFlights.GetValueOrDefault((src, city), int.MaxValue));
                    foreach (var directFlight in directFlights)
                    {
                        int fromCity = directFlight.Key.Item1;
                        int toCity = directFlight.Key.Item2;
                        int cost = directFlight.Value;

                        if (toCity == city && dp[fromCity, stops - 1] != int.MaxValue)
                        {
                            dp[city, stops] = Math.Min(dp[city, stops], dp[fromCity, stops - 1] + cost);
                        }
                    }
                }
            }


            // Find the minimum cost among the stops
            int minCost = int.MaxValue;
            for (int stops = 0; stops <= k + 1; stops++)
            {
                minCost = Math.Min(minCost, dp[dst, stops]);
            }
            if (minCost == int.MaxValue)
            {
                return -1;
            }

            return minCost;
        }
    }
}
