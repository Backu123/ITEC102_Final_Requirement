using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public class SetLayout
    {
        // Control the console whole setting
        public void Set()
        {
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);               // Remove the console both scroll bars

            IntPtr hConsole = FullScreen.GetStdHandle(-11);                                                // Get console handle
            FullScreen.COORD xy = new FullScreen.COORD(100, 100);
            FullScreen.SetConsoleDisplayMode(hConsole, 1, out xy);                                       // Set the console to fullscreen

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);        //  Set to not show the "Press any key to continue"

            Console.CursorVisible = false;                                                           // Remove the cursor from the console
        }

        // Handler Method to remove the "Press any key to continue........."
        void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            FullScreen.ShowWindow(FullScreen.ThisConsole, 0);
        }
    }

    // Class is setting the console window full screen
    internal static class FullScreen
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct COORD
        {
            public short X;
            public short Y;
            public COORD(short x, short y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetStdHandle(int handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleDisplayMode(IntPtr ConsoleOutput, uint Flags, out COORD NewScreenBufferDimensions);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern IntPtr GetConsoleWindow();
        public static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}
