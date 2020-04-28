#include "stdafx.h"
#include "targetver.h"
#include "Library.h"


extern "C" double __declspec(dllexport) __stdcall SquareRect(double Side1, double Side2)
{
	return Side1 * Side2;
}

extern "C" double __declspec(dllexport) __stdcall SquareTr(double Side, double Height)
{
	return Side * Height * 0.5;
}