using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DemoSlot10_ConcurrencyProgramming
{
    class ListAllRunningProcesses
    {
        static void GetAllRunningProcesses()
        {
            // Get all the processes on the local machine, ordered by PID.
            var runningProcs = from proc in Process.GetProcesses(".")
                    orderby proc.Id
                    select proc;
            // Print out PID and name of each process.
            foreach (var p in runningProcs)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("************************************\n");
        }

        static void GetSpecificProcess()
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(30592);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            // List out stats for each thread in the specified process.
            Console.WriteLine(
            "Here are the threads used by: {0}", theProc.ProcessName);
            ProcessThreadCollection theThreads = theProc.Threads;
            foreach (ProcessThread pt in theThreads)
            {
                string info = $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority: { pt.PriorityLevel}";
            Console.WriteLine(info);
            }
            Console.WriteLine("************************************\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** List all running Processes *****\n");
            GetAllRunningProcesses();

            Console.WriteLine("***** Enter PID of process to investigate *****");
            Console.Write("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);
            EnumThreadsForPid(theProcID);


            Console.ReadLine();
        }

    }

}
