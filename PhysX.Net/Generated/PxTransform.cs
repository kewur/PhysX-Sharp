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

public class PxTransform : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxTransform(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxQuat q {
    set {
      physxPINVOKE.PxTransform_q_set(swigCPtr, PxQuat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTransform_q_get(swigCPtr);
      PxQuat ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxQuat(cPtr, false);
      return ret;
    } 
  }

  public PxVec3 p {
    set {
      physxPINVOKE.PxTransform_p_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxTransform_p_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public PxTransform() : this(physxPINVOKE.new_PxTransform__SWIG_0(), true) {
  }

  public PxTransform(PxVec3 position) : this(physxPINVOKE.new_PxTransform__SWIG_1(PxVec3.getCPtr(position)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public PxTransform(PxIDENTITY r) : this(physxPINVOKE.new_PxTransform__SWIG_2((int)r), true) {
  }

  public PxTransform(PxQuat orientation) : this(physxPINVOKE.new_PxTransform__SWIG_3(PxQuat.getCPtr(orientation)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public PxTransform(float x, float y, float z, PxQuat aQ) : this(physxPINVOKE.new_PxTransform__SWIG_4(x, y, z, PxQuat.getCPtr(aQ)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public PxTransform(float x, float y, float z) : this(physxPINVOKE.new_PxTransform__SWIG_5(x, y, z), true) {
  }

  public PxTransform(PxVec3 p0, PxQuat q0) : this(physxPINVOKE.new_PxTransform__SWIG_6(PxVec3.getCPtr(p0), PxQuat.getCPtr(q0)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public PxTransform(SWIGTYPE_p_physx__PxMat44 m) : this(physxPINVOKE.new_PxTransform__SWIG_7(SWIGTYPE_p_physx__PxMat44.getCPtr(m)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public PxTransform getInverse() {
    PxTransform ret = new PxTransform(physxPINVOKE.PxTransform_getInverse(swigCPtr), true);
    return ret;
  }

  public PxVec3 transform(PxVec3 input) {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxTransform_transform__SWIG_0(swigCPtr, PxVec3.getCPtr(input)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxVec3 transformInv(PxVec3 input) {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxTransform_transformInv__SWIG_0(swigCPtr, PxVec3.getCPtr(input)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxVec3 rotate(PxVec3 input) {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxTransform_rotate(swigCPtr, PxVec3.getCPtr(input)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxVec3 rotateInv(PxVec3 input) {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxTransform_rotateInv(swigCPtr, PxVec3.getCPtr(input)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxTransform transform(PxTransform src) {
    PxTransform ret = new PxTransform(physxPINVOKE.PxTransform_transform__SWIG_1(swigCPtr, PxTransform.getCPtr(src)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isValid() {
    bool ret = physxPINVOKE.PxTransform_isValid(swigCPtr);
    return ret;
  }

  public bool isSane() {
    bool ret = physxPINVOKE.PxTransform_isSane(swigCPtr);
    return ret;
  }

  public bool isFinite() {
    bool ret = physxPINVOKE.PxTransform_isFinite(swigCPtr);
    return ret;
  }

  public PxTransform transformInv(PxTransform src) {
    PxTransform ret = new PxTransform(physxPINVOKE.PxTransform_transformInv__SWIG_1(swigCPtr, PxTransform.getCPtr(src)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxPlane transform(PxPlane plane) {
    PxPlane ret = new PxPlane(physxPINVOKE.PxTransform_transform__SWIG_2(swigCPtr, PxPlane.getCPtr(plane)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxPlane inverseTransform(PxPlane plane) {
    PxPlane ret = new PxPlane(physxPINVOKE.PxTransform_inverseTransform(swigCPtr, PxPlane.getCPtr(plane)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxTransform getNormalized() {
    PxTransform ret = new PxTransform(physxPINVOKE.PxTransform_getNormalized(swigCPtr), true);
    return ret;
  }

}

}