using System.Diagnostics;


namespace SilentRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            if (args.Length > 0)
            {
                process.StartInfo.FileName = args[0];
                if (args.Length > 1)
                    process.StartInfo.Arguments = args[1];
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
            }
        }
    }
}
