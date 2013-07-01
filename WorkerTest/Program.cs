using System;
using System.Threading;

namespace WorkerTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				Console.WriteLine("Testing logging");
				Thread.Sleep(1000);
			}
		}
	}
}
