using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab6
{
    static class Sound
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Cmd, StringBuilder StrReturn, int ReturnLength, IntPtr HwndCallback);
        static public void PlaySound(string fileName)
        {
            mciSendString("open \"" + fileName + "\" type waveaudio alias zvuk", null, 0, IntPtr.Zero);
            mciSendString("play zvuk from 0", null, 0, IntPtr.Zero);
        }
    }
}
