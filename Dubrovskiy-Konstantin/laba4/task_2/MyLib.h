#ifdef _WIN32
#include <tchar.h>
#endif

extern "C" double __declspec(dllexport) __stdcall  Sum(double a, double b);
extern "C" double __declspec(dllexport) __stdcall Sub(double a, double b);
extern "C"  double __declspec(dllexport) __stdcall Mult(double a, double b);
extern "C" double __declspec(dllexport) __stdcall Div(double a, double b);
