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

public class PxExtendedContact : PxContact {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxExtendedContact(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxExtendedContact_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxExtendedContact obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxExtendedContact() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxExtendedContact(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public float maxImpulse {
    set {
      physxPINVOKE.PxExtendedContact_maxImpulse_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxExtendedContact_maxImpulse_get(swigCPtr);
      return ret;
    } 
  }

  public PxExtendedContact() : this(physxPINVOKE.new_PxExtendedContact(), true) {
  }

}

}
