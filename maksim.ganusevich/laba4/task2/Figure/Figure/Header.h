#pragma once
#include "Source.cpp"

extern "C" __declspec(dllexport) double circle(float side, unsigned short parameterNumber);
extern "C" __declspec(dllexport) double square(float side, unsigned short parameterNumber);
extern "C" __declspec(dllexport) double triangle(float side, unsigned short parameterNumber);
extern "C" __declspec(dllexport) double hexagon(float side, unsigned short parameterNumber);