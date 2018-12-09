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

public class PxLocationHit : PxQueryHit {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxLocationHit(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxLocationHit_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxLocationHit obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxLocationHit() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxLocationHit(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PxLocationHit() : this(physxPINVOKE.new_PxLocationHit(), true) {
  }

  public bool hadInitialOverlap() {
    bool ret = physxPINVOKE.PxLocationHit_hadInitialOverlap(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_physx__PxFlagsT_physx__PxHitFlag__Enum_uint16_t_t flags {
    set {
      physxPINVOKE.PxLocationHit_flags_set(swigCPtr, SWIGTYPE_p_physx__PxFlagsT_physx__PxHitFlag__Enum_uint16_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxLocationHit_flags_get(swigCPtr);
      SWIGTYPE_p_physx__PxFlagsT_physx__PxHitFlag__Enum_uint16_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_physx__PxFlagsT_physx__PxHitFlag__Enum_uint16_t_t(cPtr, false);
      return ret;
    } 
  }

  public PxVec3 position {
    set {
      physxPINVOKE.PxLocationHit_position_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxLocationHit_position_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public PxVec3 normal {
    set {
      physxPINVOKE.PxLocationHit_normal_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxLocationHit_normal_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public float distance {
    set {
      physxPINVOKE.PxLocationHit_distance_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxLocationHit_distance_get(swigCPtr);
      return ret;
    } 
  }

}

}
