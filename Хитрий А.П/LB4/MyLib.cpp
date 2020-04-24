#include "pch.h"
#include "MyHeader.h"

extern "C" __declspec(dllexport) int __stdcall Add(int a,int b)
{
	return a + b;
}

extern "C" __declspec(dllexport) int __stdcall Sub(int a, int b)
{
	return a - b;
}

extern "C" __declspec(dllexport) int __stdcall Mult(int a, int b)
{
	return a * b;
}

extern "C" __declspec(dllexport) int __stdcall Div(int a, int b)
{
	return a / b;
}

extern "C" __declspec(dllexport) int __stdcall Power(int a, int b)
{
	for (int i = 1; i < b; ++i)
		a *= a;
	return a;
}