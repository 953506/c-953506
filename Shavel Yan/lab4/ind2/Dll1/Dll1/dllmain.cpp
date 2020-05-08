#pragma once
#include "pch.h"

__declspec(dllexport)
double __stdcall Add(double lo, double ro)
{
	return (lo + ro);
}

__declspec(dllexport)
double __stdcall Sub(double lo, double ro)
{
	return (lo - ro);
}

__declspec(dllexport)
double __stdcall Multiply(double lo, double ro)
{
	return (lo * ro);
}

__declspec(dllexport)
double __stdcall Divide(double lo, double ro)
{
	return (lo / (ro == 0.0) ? 1.0 : ro);
}