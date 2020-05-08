#pragma once

#include <stdexcept>
using namespace std;


extern "C" { __declspec(dllexport) double __stdcall Add(double a, double b); }
extern "C" { __declspec(dllexport) double __stdcall Sub(double a, double b); }
extern "C" { __declspec(dllexport) double __stdcall Multiply(double a, double b); }
extern "C" { __declspec(dllexport) double __stdcall Divide(double a, double b); }