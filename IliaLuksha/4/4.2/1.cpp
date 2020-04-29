//   Important note about DLL memory management when your DLL uses the
//   static version of the RunTime Library:
//


#pragma hdrstop
#pragma argsused

extern "C" double __declspec(dllexport) __stdcall Add(double a, double b )
{
	return a + b;
}

