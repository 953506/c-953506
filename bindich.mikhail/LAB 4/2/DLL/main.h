#ifndef __MAIN_H__
#define __MAIN_H__

#include <windows.h>

/*  To use this exported function of dll, include this header
 *  in your project.
 */

#ifdef BUILD_DLL
    #define DLL_EXPORT __declspec(dllexport) __stdcall
#else
    #define DLL_EXPORT __declspec(dllimport) __stdcall
#endif


#ifdef __cplusplus
extern "C"
{
#endif

double __declspec(dllexport) rec(int b[], int i, int last);

#ifdef __cplusplus
}
#endif

#endif // __MAIN_H__
