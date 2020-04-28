#include "pch.h"
#include "Header.h"

extern "C" __declspec(dllexport) int __stdcall Square(int a)
{
	return a * a;
}