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

public class PxContact : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxContact(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxContact obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxContact() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxContact(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxVec3 contact {
    set {
      physxPINVOKE.PxContact_contact_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxContact_contact_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public float separation {
    set {
      physxPINVOKE.PxContact_separation_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxContact_separation_get(swigCPtr);
      return ret;
    } 
  }

  public PxContact() : this(physxPINVOKE.new_PxContact(), true) {
  }

}

}
