using Cheapest_Flight_Ticket;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage and test cases
        FlightSolver solver = new FlightSolver();

        // Test Case 1
        int n1 = 4;
        int[][] flights1 = new int[][] {
            new int[] {0, 1, 100},
            new int[] {1, 2, 100},
            new int[] {2, 0, 100},
            new int[] {1, 3, 600},
            new int[] {2, 3, 200}
        };
        int src1 = 0;
        int dst1 = 3;
        int k1 = 1;
        int result1 = solver.FindCheapestPrice(n1, flights1, src1, dst1, k1);
        Console.WriteLine("Test Case 1: " + result1);  // Expected: 700

        // Test Case 2
        int n2 = 3;
        int[][] flights2 = new int[][] {
            new int[] {0, 1, 100},
            new int[] {1, 2, 100},
            new int[] {0, 2, 500}
        };
        int src2 = 0;
        int dst2 = 2;
        int k2 = 1;
        int result2 = solver.FindCheapestPrice(n2, flights2, src2, dst2, k2);
        Console.WriteLine("Test Case 2: " + result2);  // Expected: 200

        // Test Case 3
        int n3 = 3;
        int[][] flights3 = new int[][] {
            new int[] {0, 1, 100},
            new int[] {1, 2, 100},
            new int[] {0, 2, 500}
        };
        int src3 = 0;
        int dst3 = 2;
        int k3 = 0;
        int result3 = solver.FindCheapestPrice(n3, flights3, src3, dst3, k3);
        Console.WriteLine("Test Case 3: " + result3);  // Expected: 500

        // Test Case 4 (Complex)
        int n4 = 5;
        int[][] flights4 = new int[][] {
            new int[] {0, 1, 100},
            new int[] {1, 2, 200},
            new int[] {0, 3, 300},
            new int[] {3, 4, 400},
            new int[] {1, 4, 500},
            new int[] {2, 4, 600}
        };
        int src4 = 0;
        int dst4 = 4;
        int k4 = 2;
        int result4 = solver.FindCheapestPrice(n4, flights4, src4, dst4, k4);
        Console.WriteLine("Test Case 4: " + result4);  // Expected: 600

        // Test Case 5 (No Possible Route)
        int n5 = 4;
        int[][] flights5 = new int[][] {
            new int[] {0, 1, 100},
            new int[] {1, 2, 200},
            new int[] {2, 3, 300}
        };
        int src5 = 0;
        int dst5 = 3;
        int k5 = 1;
        int result5 = solver.FindCheapestPrice(n5, flights5, src5, dst5, k5);
        Console.WriteLine("Test Case 5: " + result5);  // Expected: -1
    }
}
