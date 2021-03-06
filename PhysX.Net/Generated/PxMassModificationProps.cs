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

public class PxMassModificationProps : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxMassModificationProps(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxMassModificationProps obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxMassModificationProps() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxMassModificationProps(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float mInvMassScale0 {
    set {
      physxPINVOKE.PxMassModificationProps_mInvMassScale0_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxMassModificationProps_mInvMassScale0_get(swigCPtr);
      return ret;
    } 
  }

  public float mInvInertiaScale0 {
    set {
      physxPINVOKE.PxMassModificationProps_mInvInertiaScale0_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxMassModificationProps_mInvInertiaScale0_get(swigCPtr);
      return ret;
    } 
  }

  public float mInvMassScale1 {
    set {
      physxPINVOKE.PxMassModificationProps_mInvMassScale1_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxMassModificationProps_mInvMassScale1_get(swigCPtr);
      return ret;
    } 
  }

  public float mInvInertiaScale1 {
    set {
      physxPINVOKE.PxMassModificationProps_mInvInertiaScale1_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxMassModificationProps_mInvInertiaScale1_get(swigCPtr);
      return ret;
    } 
  }

  public PxMassModificationProps() : this(physxPINVOKE.new_PxMassModificationProps(), true) {
  }

}

}
