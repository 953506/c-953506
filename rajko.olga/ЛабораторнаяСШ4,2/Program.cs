using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using MyLibrary;

namespace ЛабораторнаяСШ4_2
{
	class Program
		{
			static void Main()
			{
				Library.OutputResult("Processor:", Library.GetInfo("Win32_Processor", "Name"));
				Library.OutputResult("Produser:", Library.GetInfo("Win32_Processor", "Manufacturer"));
				Library.OutputResult("Description:", Library.GetInfo("Win32_Processor", "Description"));
				Library.OutputResult("Video card:", Library.GetInfo("Win32_VideoController", "Name"));
				Library.OutputResult("Video processor:", Library.GetInfo("Win32_VideoController", "VideoProcessor"));
				Library.OutputResult("Driver's version:", Library.GetInfo("Win32_VideoController", "DriverVersion"));
				Library.OutputResult("Video card memory size (in bytes):", Library.GetInfo("Win32_VideoController", "AdapterRAM"));
				Library.OutputResult("Volume of RAM (in bytes)):", Library.GetInfo("Win32_PhysicalMemory", "Capacity"));
				Library.OutputResult("Hard drive:", Library.GetInfo("Win32_DiskDrive", "Caption"));
				Library.OutputResult("Volume of hard drive (in bytes):", Library.GetInfo("Win32_DiskDrive", "Size"));
				Console.ReadKey();
			}
		}
	}
}
