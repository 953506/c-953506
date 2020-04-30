#pragma hdrstop
#pragma argsused

#include "MyLib.h"

extern "C" double __declspec(dllexport) __stdcall  Sum(double a, double b)
{
	return a + b;
}

extern "C" double __declspec(dllexport) __stdcall Sub(double a, double b)
{
	return a - b;
}

extern "C"  double __declspec(dllexport) __stdcall Mult(double a, double b)
{
	return a * b;
}

extern "C" double __declspec(dllexport) __stdcall Div(double a, double b)
{
	if(b != 0)	return a / b;
	else return 0;
}

