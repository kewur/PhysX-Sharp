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

public class PxSimulationEventCallback : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxSimulationEventCallback(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxSimulationEventCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxSimulationEventCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxSimulationEventCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void onConstraintBreak(PxConstraintInfo constraints, SWIGTYPE_p_uint32_t count) {
    physxPINVOKE.PxSimulationEventCallback_onConstraintBreak(swigCPtr, PxConstraintInfo.getCPtr(constraints), SWIGTYPE_p_uint32_t.getCPtr(count));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onWake(SWIGTYPE_p_p_physx__PxActor actors, SWIGTYPE_p_uint32_t count) {
    physxPINVOKE.PxSimulationEventCallback_onWake(swigCPtr, SWIGTYPE_p_p_physx__PxActor.getCPtr(actors), SWIGTYPE_p_uint32_t.getCPtr(count));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onSleep(SWIGTYPE_p_p_physx__PxActor actors, SWIGTYPE_p_uint32_t count) {
    physxPINVOKE.PxSimulationEventCallback_onSleep(swigCPtr, SWIGTYPE_p_p_physx__PxActor.getCPtr(actors), SWIGTYPE_p_uint32_t.getCPtr(count));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onContact(PxContactPairHeader pairHeader, PxContactPair pairs, SWIGTYPE_p_uint32_t nbPairs) {
    physxPINVOKE.PxSimulationEventCallback_onContact(swigCPtr, PxContactPairHeader.getCPtr(pairHeader), PxContactPair.getCPtr(pairs), SWIGTYPE_p_uint32_t.getCPtr(nbPairs));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onTrigger(PxTriggerPair pairs, SWIGTYPE_p_uint32_t count) {
    physxPINVOKE.PxSimulationEventCallback_onTrigger(swigCPtr, PxTriggerPair.getCPtr(pairs), SWIGTYPE_p_uint32_t.getCPtr(count));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onAdvance(SWIGTYPE_p_p_physx__PxRigidBody bodyBuffer, PxTransform poseBuffer, SWIGTYPE_p_uint32_t count) {
    physxPINVOKE.PxSimulationEventCallback_onAdvance(swigCPtr, SWIGTYPE_p_p_physx__PxRigidBody.getCPtr(bodyBuffer), PxTransform.getCPtr(poseBuffer), SWIGTYPE_p_uint32_t.getCPtr(count));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

}

}