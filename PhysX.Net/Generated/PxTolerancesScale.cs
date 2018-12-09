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

public class PxTolerancesScale : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxTolerancesScale(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxTolerancesScale obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxTolerancesScale() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxTolerancesScale(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float length {
    set {
      physxPINVOKE.PxTolerancesScale_length_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxTolerancesScale_length_get(swigCPtr);
      return ret;
    } 
  }

  public float mass {
    set {
      physxPINVOKE.PxTolerancesScale_mass_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxTolerancesScale_mass_get(swigCPtr);
      return ret;
    } 
  }

  public float speed {
    set {
      physxPINVOKE.PxTolerancesScale_speed_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxTolerancesScale_speed_get(swigCPtr);
      return ret;
    } 
  }

  public PxTolerancesScale() : this(physxPINVOKE.new_PxTolerancesScale(), true) {
  }

  public bool isValid() {
    bool ret = physxPINVOKE.PxTolerancesScale_isValid(swigCPtr);
    return ret;
  }

}

}
