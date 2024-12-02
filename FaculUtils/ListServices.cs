//list of Services
//Information about the processor, CPU time and memory (used and available) in Windows.
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Management;
using System.Collections;
using System.Collections.Specialized;
using System.Threading;

namespace ListProc{
	
	static class Program{
		
		static void Main(){
			//Thread.Sleep(5000);
			PerformanceCounter cpuCounter;

			cpuCounter = new PerformanceCounter();

			cpuCounter.CategoryName = "Processor";

			cpuCounter.CounterName = "% Processor Time";

			cpuCounter.InstanceName = "_Total";

			// Get Current Cpu Usage
			string currentCpuUsage =
			cpuCounter.NextValue()+"%";
			Console.WriteLine("Tempo de processamento: "+currentCpuUsage);
			PerformanceCounter ramCounter = new PerformanceCounter
			{
				CategoryName = "Memory",
				CounterName = "Available MBytes"
			};

			float availableRam = ramCounter.NextValue();	
			Console.WriteLine("Memoria RAM disponivel: "+availableRam);
		}	
	}
}