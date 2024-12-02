//List computer process
using System;
using System.Diagnostics;
using System.ComponentModel;

namespace ListProc{
	
	static class Program{
		
		static void Main(){
			Process[] listaDeProcess = Process.GetProcesses();

			foreach (Process theprocess in listaDeProcess)
			{	
				Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
			}
		}
	}
	
}