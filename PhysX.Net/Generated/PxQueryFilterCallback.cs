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

public class PxQueryFilterCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxQueryFilterCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxQueryFilterCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxQueryFilterCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxQueryFilterCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual PxQueryHitType.Enum preFilter(PxFilterData filterData, PxShape shape, PxRigidActor actor, SWIGTYPE_p_physx__PxFlagsT_physx__PxHitFlag__Enum_uint16_t_t queryFlags) {
    PxQueryHitType.Enum ret = (PxQueryHitType.Enum)physxPINVOKE.PxQueryFilterCallback_preFilter(swigCPtr, PxFilterData.getCPtr(filterData), PxShape.getCPtr(shape), PxRigidActor.getCPtr(actor), SWIGTYPE_p_physx__PxFlagsT_physx__PxHitFlag__Enum_uint16_t_t.getCPtr(queryFlags));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PxQueryHitType.Enum postFilter(PxFilterData filterData, PxQueryHit hit) {
    PxQueryHitType.Enum ret = (PxQueryHitType.Enum)physxPINVOKE.PxQueryFilterCallback_postFilter(swigCPtr, PxFilterData.getCPtr(filterData), PxQueryHit.getCPtr(hit));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
