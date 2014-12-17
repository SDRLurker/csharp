using System;

namespace csharp_139
{
	abstract class BaseLogger
	{
		public virtual void Log(string message)
		{
			Console.WriteLine ("Base: " + message);
		}
		public void LogCompleted()
		{
			Console.WriteLine ("Completed");
		}
	}

	class Logger : BaseLogger
	{
		public override void Log(string message)
		{
			Console.WriteLine (message);
		}
		public new void LogCompleted()
		{
			Console.WriteLine ("Finished");
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			BaseLogger logger = new Logger();
			logger.Log ("Log started");
			logger.Log ("Base: Log continuing");
			//logger.LogCompleted();
			((Logger)logger).LogCompleted ();
		}
	}
}
