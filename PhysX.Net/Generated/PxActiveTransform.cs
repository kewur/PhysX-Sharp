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

public class PxActiveTransform : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxActiveTransform(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxActiveTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxActiveTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxActiveTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxActor actor {
    set {
      physxPINVOKE.PxActiveTransform_actor_set(swigCPtr, PxActor.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxActiveTransform_actor_get(swigCPtr);
      PxActor ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxActor(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void userData {
    set {
      physxPINVOKE.PxActiveTransform_userData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxActiveTransform_userData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public PxTransform actor2World {
    set {
      physxPINVOKE.PxActiveTransform_actor2World_set(swigCPtr, PxTransform.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxActiveTransform_actor2World_get(swigCPtr);
      PxTransform ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxTransform(cPtr, false);
      return ret;
    } 
  }

  public PxActiveTransform() : this(physxPINVOKE.new_PxActiveTransform(), true) {
  }

}

}