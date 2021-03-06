using System;

namespace TestableSample3.Lib
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public string ReadLine(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.Write(message);
            }
            
            return Console.ReadLine();
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
