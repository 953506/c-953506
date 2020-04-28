using System;
using System.Runtime.InteropServices;
using System.Text;

namespace lab4
{
    class Program
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Command, StringBuilder ReturnString, int ReturnLength, IntPtr HCallback);
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to .wav file:");
            string fileName = Console.ReadLine();

            mciSendString("open \"" + fileName + "\" type waveaudio alias music", null, 0, IntPtr.Zero);
            mciSendString("play music from 0", null, 0, IntPtr.Zero);
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Enter action (pause/resume/exit):");
                string action = Console.ReadLine();
                if (action == "pause") mciSendString("pause music", null, 0, IntPtr.Zero);
                if (action == "resume") mciSendString("resume music", null, 0, IntPtr.Zero);
                if (action == "exit") Environment.Exit(0);
            }
        }
    }
}
