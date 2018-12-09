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

public class PxCapsuleGeometry : PxGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxCapsuleGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxCapsuleGeometry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxCapsuleGeometry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxCapsuleGeometry() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxCapsuleGeometry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PxCapsuleGeometry() : this(physxPINVOKE.new_PxCapsuleGeometry__SWIG_0(), true) {
  }

  public PxCapsuleGeometry(float radius_, float halfHeight_) : this(physxPINVOKE.new_PxCapsuleGeometry__SWIG_1(radius_, halfHeight_), true) {
  }

  public bool isValid() {
    bool ret = physxPINVOKE.PxCapsuleGeometry_isValid(swigCPtr);
    return ret;
  }

  public float radius {
    set {
      physxPINVOKE.PxCapsuleGeometry_radius_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxCapsuleGeometry_radius_get(swigCPtr);
      return ret;
    } 
  }

  public float halfHeight {
    set {
      physxPINVOKE.PxCapsuleGeometry_halfHeight_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxCapsuleGeometry_halfHeight_get(swigCPtr);
      return ret;
    } 
  }

}

}
