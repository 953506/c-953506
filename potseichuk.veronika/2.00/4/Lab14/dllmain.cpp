// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "framework.h"

extern "C" double __declspec(dllexport) __stdcall Circumference(double radius)
{
	return 2*3.14*radius;
}
extern "C" double __declspec(dllexport) __stdcall CircleArea(double radius)
{
	return 3.14*radius*radius;
}