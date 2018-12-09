#!/bin/sh

SWIG=~/Programs/GithubProjects/Swig/swig
PHYSX_INC=~/Programs/PhysxSdk/PhysX_3.4/Include
PHYSX_SHARED_INC=~/Programs/PhysxSdk/PxShared/include

rm -rf PhysX.Net/Generated
mkdir PhysX.Net/Generated
$SWIG -features autodoc=1 -csharp -c++ -namespace PhysX.Net -I$PHYSX_INC -I$PHYSX_SHARED_INC -outdir PhysX.Net/Generated PhysX.i


#DEFINES=/D "WIN32" /D "WIN64" /D "_CRT_SECURE_NO_DEPRECATE" /D "_CRT_NONSTDC_NO_DEPRECATE" /D "_WINSOCK_DEPRECATED_NO_WARNINGS" /D "NDEBUG"
#INCLUDES=/I $PHYSX_INC

#cl /RTC1 /ZI /Zc:forScope /MT /EHs $DEFINES $INCLUDES /LD physx_wrap.cxx /Fe_physx.dll
