// Client.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "Client.h"


// This is an example of an exported variable
CLIENT_API int nClient=0;

// This is an example of an exported function.
CLIENT_API int fnClient(void)
{
    return 42;
}

// This is the constructor of a class that has been exported.
// see Client.h for the class definition
CClient::CClient()
{
    return;
}
