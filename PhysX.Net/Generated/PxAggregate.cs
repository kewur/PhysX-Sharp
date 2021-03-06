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

public class PxAggregate : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxAggregate(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxAggregate_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxAggregate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void release() {
    physxPINVOKE.PxAggregate_release(swigCPtr);
  }

  public virtual bool addActor(PxActor actor) {
    bool ret = physxPINVOKE.PxAggregate_addActor(swigCPtr, PxActor.getCPtr(actor));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removeActor(PxActor actor) {
    bool ret = physxPINVOKE.PxAggregate_removeActor(swigCPtr, PxActor.getCPtr(actor));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool addArticulation(PxArticulation articulation) {
    bool ret = physxPINVOKE.PxAggregate_addArticulation(swigCPtr, PxArticulation.getCPtr(articulation));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removeArticulation(PxArticulation articulation) {
    bool ret = physxPINVOKE.PxAggregate_removeArticulation(swigCPtr, PxArticulation.getCPtr(articulation));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_uint32_t getNbActors() {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxAggregate_getNbActors(swigCPtr), true);
    return ret;
  }

  public virtual SWIGTYPE_p_uint32_t getMaxNbActors() {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxAggregate_getMaxNbActors(swigCPtr), true);
    return ret;
  }

  public virtual SWIGTYPE_p_uint32_t getActors(SWIGTYPE_p_p_physx__PxActor userBuffer, SWIGTYPE_p_uint32_t bufferSize, SWIGTYPE_p_uint32_t startIndex) {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxAggregate_getActors__SWIG_0(swigCPtr, SWIGTYPE_p_p_physx__PxActor.getCPtr(userBuffer), SWIGTYPE_p_uint32_t.getCPtr(bufferSize), SWIGTYPE_p_uint32_t.getCPtr(startIndex)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_uint32_t getActors(SWIGTYPE_p_p_physx__PxActor userBuffer, SWIGTYPE_p_uint32_t bufferSize) {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxAggregate_getActors__SWIG_1(swigCPtr, SWIGTYPE_p_p_physx__PxActor.getCPtr(userBuffer), SWIGTYPE_p_uint32_t.getCPtr(bufferSize)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PxScene getScene() {
    global::System.IntPtr cPtr = physxPINVOKE.PxAggregate_getScene(swigCPtr);
    PxScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxScene(cPtr, false);
    return ret;
  }

  public virtual bool getSelfCollision() {
    bool ret = physxPINVOKE.PxAggregate_getSelfCollision(swigCPtr);
    return ret;
  }

  public override string getConcreteTypeName() {
    string ret = physxPINVOKE.PxAggregate_getConcreteTypeName(swigCPtr);
    return ret;
  }

}

}
