using System;
using System.Runtime.InteropServices;
class SystemInfo
{
    [DllImport("kernel32.dll")]
    public static extern bool GetComputerName(char[] lpBuffer, ref int nSize);

    [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
    public static extern bool GetUserName(char[] lpBuffer, ref int nSize);

    [DllImport("kernel32.dll")]
    public static extern int GetVersion();

    [DllImport("user32.dll")]
    public static extern int GetSystemMetrics(int nIndex);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern int GetSystemDirectory(char[] lpBuffer, int uSize);

    [DllImport("kernel32.dll")]
    public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern int GetTempPath(int nBufferLength, [Out] char[] lpBuffer);

    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        public ushort wProcessorArchitecture;
        public ushort wReserved;
        public uint dwPageSize;
        public IntPtr lpMinimumApplicationAddress;
        public IntPtr lpMaximumApplicationAddress;
        public IntPtr ActiveProcessorAffinityMask;
        public uint dwNumberOfProcessors;
    }

    public static void Main()
    {
        char[] computerName = new char[256];
        int size = 256;
        GetComputerName(computerName, ref size);
        string computerNameStr = new string(computerName, 0, size);

        char[] userName = new char[256];
        int userSize = 256;
        GetUserName(userName, ref userSize);
        string userNameStr = new string(userName, 0, userSize);

        int version = GetVersion();
        int majorVersion = version & 0xFF;
        int minorVersion = (version >> 8) & 0xFF;
        int buildNumber = (version >> 16) & 0xFFFF;

        char[] systemDir = new char[256];
        int sysDirSize = 256;
        GetSystemDirectory(systemDir, sysDirSize);
        string systemDirStr = new string(systemDir);

        int screenWidth = GetSystemMetrics(0);
        int screenHeight = GetSystemMetrics(1);

        SYSTEM_INFO sysInfo = new SYSTEM_INFO();
        GetSystemInfo(ref sysInfo);

        string dateTime = DateTime.Now.ToString();

        Console.WriteLine("Имя компьютера: " + computerNameStr);
        Console.WriteLine("Имя пользователя: " + userNameStr);
        Console.WriteLine("Системная директория: " + systemDirStr);
        Console.WriteLine("Версия ОС: " + majorVersion + "." + minorVersion + "." + buildNumber);
        Console.WriteLine("Разрешение экрана: " + screenWidth + "x" + screenHeight);
        Console.WriteLine("Количество процессоров: " + sysInfo.dwNumberOfProcessors);
        Console.WriteLine("Текущая дата и время: " + dateTime);
    }
}