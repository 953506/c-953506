#pragma once
#include "Header.h"
#include "pch.h"
#include <math.h>

extern "C" __declspec(dllexport) double circle(float side, unsigned short parameterNumber)
{
	if (side <= 0)
		return 0;
	switch (parameterNumber)
	{
	case 1: return side * 2;
	case 2: return side * 3.14;
	case 3: return side * side * 3.14;
	default: return 0;
	}
}

extern "C" __declspec(dllexport) double square(float side, unsigned short parameterNumber)
{
	if (side <= 0)
		return 0;
	switch (parameterNumber)
	{
	case 1: return (side * sqrt(2));
	case 2: return side * 4;
	case 3: return side * side;
	default: return 0;
	}
}

extern "C" __declspec(dllexport) double triangle(float side, unsigned short parameterNumber)
{
	if (side <= 0)
		return 0;
	switch (parameterNumber)
	{
	case 1: return (side * sqrt(3) * 0.5);
	case 2: return side * 3;
	case 3: return (side * side * sqrt(3) * 0.25);
	default: return 0;
	}
}

extern "C" __declspec(dllexport) double hexagon(float side, unsigned short parameterNumber)
{
	if (side <= 0)
		return 0;
	switch (parameterNumber)
	{
	case 1: return (side * sqrt(3));
	case 2: return side * 6;
	case 3: return (side * side * 3 * sqrt(3) / 2);
	default: return 0;
	}
}