using System;
using System.Management;
using ClassLibrary1;

namespace ConsoleApplication12
{
	class Program
	{
		static void Main()
		{
			Library.OutputResult("Процессор:", Library.GetInfo("Win32_Processor", "Name"));
			Library.OutputResult("Описание:", Library.GetInfo("Win32_Processor", "Description"));
			Library.OutputResult("Видеокарта:", Library.GetInfo("Win32_VideoController", "Name"));
			Library.OutputResult("Видеопроцессор:", Library.GetInfo("Win32_VideoController", "VideoProcessor"));
			Library.OutputResult("Объем памяти видеокарты (в байтах):", Library.GetInfo("Win32_VideoController", "AdapterRAM"));
			Library.OutputResult("Объем оперативной памяти (в байтах):", Library.GetInfo("Win32_PhysicalMemory", "Capacity"));
			Library.OutputResult("Жесткий диск:", Library.GetInfo("Win32_DiskDrive", "Caption"));
			Library.OutputResult("Объем жесткого диска (в байтах):", Library.GetInfo("Win32_DiskDrive", "Size"));
			Console.ReadKey();
		}
	}
}