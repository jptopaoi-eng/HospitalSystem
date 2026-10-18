using System;

namespace HospitalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("    HOSPITAL MANAGEMENT SYSTEM TEST       ");
            Console.WriteLine("==========================================\n");

            
            Console.WriteLine("[Step 1] Initializing Patient Action Stack...");
            MyStack<string> actionLog = new MyStack<string>();
            Console.WriteLine($"Stack created successfully. Is empty? {actionLog.IsEmpty()}\n");

           
            Console.WriteLine("[Step 2] Logging patient actions (Push)...");
            actionLog.Push("Admitted Patient: John Doe (Room 302)");
            actionLog.Push("Administered Pain Medication to John Doe");
            actionLog.Push("Doctor Consultation completed for John Doe");

            Console.WriteLine($"Current number of actions in log: {actionLog.Count}\n");

            
            Console.WriteLine("[Step 3] Checking the most recent action (Peek)...");
            Console.WriteLine($"-> Most Recent Action: {actionLog.Peek()}\n");

            
            Console.WriteLine("[Step 4] Removing/Processing the top action (Pop)...");
            string removedAction = actionLog.Pop();
            Console.WriteLine($"-> Processed & Removed: '{removedAction}'");
            Console.WriteLine($"Remaining actions in log: {actionLog.Count}\n");

            
            Console.WriteLine("[Step 5] Checking new top action after Pop...");
            Console.WriteLine($"-> New Most Recent Action: {actionLog.Peek()}\n");

            Console.WriteLine("==========================================");
            Console.WriteLine("   All Stack tests completed successfully! ");
            Console.WriteLine("==========================================");
        }
    }
}
