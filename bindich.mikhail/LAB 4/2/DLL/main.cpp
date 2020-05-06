#include "main.h"
#include <cstdlib>
#include <iostream>
#include <conio.h>
#include <math.h>

using namespace std;

double __declspec(dllexport) rec(int b[], int i, int last) {
    cout<<"\t" << "i = " << i;
    cout<< "\nlast = "<<last;
    getch();
    if (i == (last - 1)) {
        int result = pow(float (b[i]), 2) - cos(float (b[i]));
        cout<< "\nvalue = " << result;
        return result;
    }
    int midArr = (last + i)/2;
    cout << "\nmidArr = " << midArr;

    return rec(b, i, midArr) * rec(b, midArr, last);
}

extern "C" DLL_EXPORT BOOL APIENTRY DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpvReserved)
{
    switch (fdwReason)
    {
        case DLL_PROCESS_ATTACH:
            // attach to process
            // return FALSE to fail DLL load
            break;

        case DLL_PROCESS_DETACH:
            // detach from process
            break;

        case DLL_THREAD_ATTACH:
            // attach to thread
            break;

        case DLL_THREAD_DETACH:
            // detach from thread
            break;
    }
    return TRUE; // succesful
}
