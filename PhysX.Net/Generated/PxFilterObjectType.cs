//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PhysX.Net {

public class PxFilterObjectType : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxFilterObjectType(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxFilterObjectType obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxFilterObjectType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxFilterObjectType(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxFilterObjectType() : this(physxPINVOKE.new_PxFilterObjectType(), true) {
  }

  public enum Enum {
    eRIGID_STATIC,
    eRIGID_DYNAMIC,
    ePARTICLE_SYSTEM,
    ePARTICLE_FLUID,
    eARTICULATION,
    eCLOTH,
    eMAX_TYPE_COUNT = 16,
    eUNDEFINED = eMAX_TYPE_COUNT-1
  }

}

}
