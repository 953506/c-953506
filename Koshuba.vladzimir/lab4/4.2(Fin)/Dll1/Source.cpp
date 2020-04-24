#pragma once
#include "Header.h"

MathClass::MathClass(double First, double Second)
{
	_One = First;
	_Two = Second;
}

double MathClass::addit()
{
	return _One + _Two;
}

double MathClass::deduction()
{
	return _One - _Two;
}

double MathClass::multiplication()
{
	return _One * _Two;
}

double MathClass::Divide()
{
	return _One / _Two;
}