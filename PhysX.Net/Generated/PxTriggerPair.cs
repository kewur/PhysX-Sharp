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

public class PxTriggerPair : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxTriggerPair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxTriggerPair obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxTriggerPair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxTriggerPair(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxTriggerPair() : this(physxPINVOKE.new_PxTriggerPair(), true) {
  }

  public PxShape triggerShape {
    set {
      physxPINVOKE.PxTriggerPair_triggerShape_set(swigCPtr, PxShape.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTriggerPair_triggerShape_get(swigCPtr);
      PxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxShape(cPtr, false);
      return ret;
    } 
  }

  public PxRigidActor triggerActor {
    set {
      physxPINVOKE.PxTriggerPair_triggerActor_set(swigCPtr, PxRigidActor.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTriggerPair_triggerActor_get(swigCPtr);
      PxRigidActor ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxRigidActor(cPtr, false);
      return ret;
    } 
  }

  public PxShape otherShape {
    set {
      physxPINVOKE.PxTriggerPair_otherShape_set(swigCPtr, PxShape.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTriggerPair_otherShape_get(swigCPtr);
      PxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxShape(cPtr, false);
      return ret;
    } 
  }

  public PxRigidActor otherActor {
    set {
      physxPINVOKE.PxTriggerPair_otherActor_set(swigCPtr, PxRigidActor.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTriggerPair_otherActor_get(swigCPtr);
      PxRigidActor ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxRigidActor(cPtr, false);
      return ret;
    } 
  }

  public PxPairFlag.Enum status {
    set {
      physxPINVOKE.PxTriggerPair_status_set(swigCPtr, (int)value);
    } 
    get {
      PxPairFlag.Enum ret = (PxPairFlag.Enum)physxPINVOKE.PxTriggerPair_status_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_physx__PxFlagsT_physx__PxTriggerPairFlag__Enum_uint8_t_t flags {
    set {
      physxPINVOKE.PxTriggerPair_flags_set(swigCPtr, SWIGTYPE_p_physx__PxFlagsT_physx__PxTriggerPairFlag__Enum_uint8_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTriggerPair_flags_get(swigCPtr);
      SWIGTYPE_p_physx__PxFlagsT_physx__PxTriggerPairFlag__Enum_uint8_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_physx__PxFlagsT_physx__PxTriggerPairFlag__Enum_uint8_t_t(cPtr, false);
      return ret;
    } 
  }

}

}
