using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace afcbot
{
	public class Task2
	{
		public static Thread thread;
		public static void Init()
		{
			MainClass.DebugLog("Task 2");
			thread = new Thread(exec);
			thread.Start();
			MainClass.Log("Task 2 initialized");
		}
		
		public static void exec()
		{
			
		}
	}
}

