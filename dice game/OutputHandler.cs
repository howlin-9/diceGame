using System;
using System.Text;
using diceGame;

namespace diceGame
{
    public class OutputHandler
    {
        StringBuilder log = new StringBuilder();

        public void Log(string msg)
        {
            Console.WriteLine(msg);
            log.AppendLine(msg);
            //System.IO.File.AppendAllText("diceGameLog.txt", msg + Environment.NewLine);
        }
        public void WriteLogToFile()
        {
            System.IO.File.WriteAllText("diceGameLog.txt", log.ToString());
        }
        public OutputHandler() => System.IO.File.AppendAllText("diceGameLog.txt", log.ToString());
    }
}