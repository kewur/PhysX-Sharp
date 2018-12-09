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

public class PxConstraint : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxConstraint obj) {
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
    physxPINVOKE.PxConstraint_release(swigCPtr);
  }

  public virtual PxScene getScene() {
    global::System.IntPtr cPtr = physxPINVOKE.PxConstraint_getScene(swigCPtr);
    PxScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxScene(cPtr, false);
    return ret;
  }

  public virtual void getActors(SWIGTYPE_p_p_physx__PxRigidActor actor0, SWIGTYPE_p_p_physx__PxRigidActor actor1) {
    physxPINVOKE.PxConstraint_getActors(swigCPtr, SWIGTYPE_p_p_physx__PxRigidActor.getCPtr(actor0), SWIGTYPE_p_p_physx__PxRigidActor.getCPtr(actor1));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setActors(PxRigidActor actor0, PxRigidActor actor1) {
    physxPINVOKE.PxConstraint_setActors(swigCPtr, PxRigidActor.getCPtr(actor0), PxRigidActor.getCPtr(actor1));
  }

  public virtual void markDirty() {
    physxPINVOKE.PxConstraint_markDirty(swigCPtr);
  }

  public virtual void setFlags(SWIGTYPE_p_physx__PxFlagsT_physx__PxConstraintFlag__Enum_uint16_t_t flags) {
    physxPINVOKE.PxConstraint_setFlags(swigCPtr, SWIGTYPE_p_physx__PxFlagsT_physx__PxConstraintFlag__Enum_uint16_t_t.getCPtr(flags));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_physx__PxFlagsT_physx__PxConstraintFlag__Enum_uint16_t_t getFlags() {
    SWIGTYPE_p_physx__PxFlagsT_physx__PxConstraintFlag__Enum_uint16_t_t ret = new SWIGTYPE_p_physx__PxFlagsT_physx__PxConstraintFlag__Enum_uint16_t_t(physxPINVOKE.PxConstraint_getFlags(swigCPtr), true);
    return ret;
  }

  public virtual void setFlag(PxConstraintFlag.Enum flag, bool value) {
    physxPINVOKE.PxConstraint_setFlag(swigCPtr, (int)flag, value);
  }

  public virtual void getForce(PxVec3 linear, PxVec3 angular) {
    physxPINVOKE.PxConstraint_getForce(swigCPtr, PxVec3.getCPtr(linear), PxVec3.getCPtr(angular));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isValid() {
    bool ret = physxPINVOKE.PxConstraint_isValid(swigCPtr);
    return ret;
  }

  public virtual void setBreakForce(float linear, float angular) {
    physxPINVOKE.PxConstraint_setBreakForce(swigCPtr, linear, angular);
  }

  public virtual void getBreakForce(SWIGTYPE_p_float linear, SWIGTYPE_p_float angular) {
    physxPINVOKE.PxConstraint_getBreakForce(swigCPtr, SWIGTYPE_p_float.getCPtr(linear), SWIGTYPE_p_float.getCPtr(angular));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMinResponseThreshold(float threshold) {
    physxPINVOKE.PxConstraint_setMinResponseThreshold(swigCPtr, threshold);
  }

  public virtual float getMinResponseThreshold() {
    float ret = physxPINVOKE.PxConstraint_getMinResponseThreshold(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_void getExternalReference(SWIGTYPE_p_uint32_t typeID) {
    global::System.IntPtr cPtr = physxPINVOKE.PxConstraint_getExternalReference(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(typeID));
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setConstraintFunctions(PxConstraintConnector connector, PxConstraintShaderTable shaders) {
    physxPINVOKE.PxConstraint_setConstraintFunctions(swigCPtr, PxConstraintConnector.getCPtr(connector), PxConstraintShaderTable.getCPtr(shaders));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string getConcreteTypeName() {
    string ret = physxPINVOKE.PxConstraint_getConcreteTypeName(swigCPtr);
    return ret;
  }

}

}
