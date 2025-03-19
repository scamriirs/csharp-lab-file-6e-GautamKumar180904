using System;

class ParkingSystem
{
    static int vipCount = 0, studentCount = 0, visitorCount = 0;
    static int totalRevenue = 0;
    
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. VIP Car (No fee)\n2. Student Car (10 rupees)\n3. Visitor Car (20 rupees)\n4. Show Summary\n5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                vipCount++;
                Console.WriteLine("VIP car registered.");
            }
            else if (choice == 2)
            {
                studentCount++;
                totalRevenue += 10;
                Console.WriteLine("Student car registered. Fee: 10 rupees");
            }
            else if (choice == 3)
            {
                visitorCount++;
                totalRevenue += 20;
                Console.WriteLine("Visitor car registered. Fee: 20 rupees");
            }
            else if (choice == 4)
            {
                Console.WriteLine("\n--- Parking Summary ---");
                Console.WriteLine($"VIP cars: {vipCount}");
                Console.WriteLine($"Student cars: {studentCount}");
                Console.WriteLine($"Visitor cars: {visitorCount}");
                Console.WriteLine($"Total revenue: {totalRevenue} rupees");
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}
