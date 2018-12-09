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

public class PxContactPairPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxContactPairPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxContactPairPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxContactPairPoint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxContactPairPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxVec3 position {
    set {
      physxPINVOKE.PxContactPairPoint_position_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxContactPairPoint_position_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public float separation {
    set {
      physxPINVOKE.PxContactPairPoint_separation_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxContactPairPoint_separation_get(swigCPtr);
      return ret;
    } 
  }

  public PxVec3 normal {
    set {
      physxPINVOKE.PxContactPairPoint_normal_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxContactPairPoint_normal_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t internalFaceIndex0 {
    set {
      physxPINVOKE.PxContactPairPoint_internalFaceIndex0_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxContactPairPoint_internalFaceIndex0_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxVec3 impulse {
    set {
      physxPINVOKE.PxContactPairPoint_impulse_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxContactPairPoint_impulse_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t internalFaceIndex1 {
    set {
      physxPINVOKE.PxContactPairPoint_internalFaceIndex1_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxContactPairPoint_internalFaceIndex1_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxContactPairPoint() : this(physxPINVOKE.new_PxContactPairPoint(), true) {
  }

}

}