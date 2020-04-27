#pragma hdrstop
#pragma argsused

extern "C" double __declspec(dllexport) __stdcall boddyMassIndex(double weight, double heigth)
{
	return weight / heigth / heigth;
}