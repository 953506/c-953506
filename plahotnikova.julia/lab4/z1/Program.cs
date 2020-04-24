using System;
using System.Runtime.InteropServices;
using System.Text;

namespace lab4
{
    class Program
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Command, StringBuilder ReturnString, int ReturnLength, IntPtr HCallback);
        //mcisendstring - функция mci
        //string cmd - дальний указатель на текстовую управляющую строку
        //stringbuilder returnstring - указатель на буфер, в который будет записан результат выполнения команды (в текстовом виде). 
        //Этот параметр можно указать как NULL, если приложение не интересуется результатом выполнения команды
        //int returnlength - размер буфера для записи результата выполнения команды
        //intptr hcallback - идентификатор окна, которое получит извещение (сообщение MM_MCINOTIFY) 
        //после того как устройство завершит операцию.
        //Этот параметр можно указать как NULL, если извещение не используется
        //alias - параметр, альтернативное имя для работы с устройством
        //type waveaudio - тип устройства, через параметр device передается имя файла
        //это позволит использовать имена файлов с нестандартными расширениями
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