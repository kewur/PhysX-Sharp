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

public class PxClothParticleMotionConstraint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxClothParticleMotionConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxClothParticleMotionConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxClothParticleMotionConstraint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxClothParticleMotionConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxVec3 pos {
    set {
      physxPINVOKE.PxClothParticleMotionConstraint_pos_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxClothParticleMotionConstraint_pos_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public float radius {
    set {
      physxPINVOKE.PxClothParticleMotionConstraint_radius_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxClothParticleMotionConstraint_radius_get(swigCPtr);
      return ret;
    } 
  }

  public PxClothParticleMotionConstraint() : this(physxPINVOKE.new_PxClothParticleMotionConstraint__SWIG_0(), true) {
  }

  public PxClothParticleMotionConstraint(PxVec3 p, float r) : this(physxPINVOKE.new_PxClothParticleMotionConstraint__SWIG_1(PxVec3.getCPtr(p), r), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
