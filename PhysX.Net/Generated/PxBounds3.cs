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

public class PxBounds3 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxBounds3(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxBounds3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxBounds3() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxBounds3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxBounds3() : this(physxPINVOKE.new_PxBounds3__SWIG_0(), true) {
  }

  public PxBounds3(PxVec3 minimum, PxVec3 maximum) : this(physxPINVOKE.new_PxBounds3__SWIG_1(PxVec3.getCPtr(minimum), PxVec3.getCPtr(maximum)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public static PxBounds3 empty() {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_empty(), true);
    return ret;
  }

  public static PxBounds3 boundsOfPoints(PxVec3 v0, PxVec3 v1) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_boundsOfPoints(PxVec3.getCPtr(v0), PxVec3.getCPtr(v1)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 centerExtents(PxVec3 center, PxVec3 extent) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_centerExtents(PxVec3.getCPtr(center), PxVec3.getCPtr(extent)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 basisExtent(PxVec3 center, PxMat33 basis, PxVec3 extent) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_basisExtent(PxVec3.getCPtr(center), PxMat33.getCPtr(basis), PxVec3.getCPtr(extent)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 poseExtent(PxTransform pose, PxVec3 extent) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_poseExtent(PxTransform.getCPtr(pose), PxVec3.getCPtr(extent)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 transformSafe(PxMat33 matrix, PxBounds3 bounds) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_transformSafe__SWIG_0(PxMat33.getCPtr(matrix), PxBounds3.getCPtr(bounds)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 transformFast(PxMat33 matrix, PxBounds3 bounds) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_transformFast__SWIG_0(PxMat33.getCPtr(matrix), PxBounds3.getCPtr(bounds)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 transformSafe(PxTransform transform, PxBounds3 bounds) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_transformSafe__SWIG_1(PxTransform.getCPtr(transform), PxBounds3.getCPtr(bounds)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static PxBounds3 transformFast(PxTransform transform, PxBounds3 bounds) {
    PxBounds3 ret = new PxBounds3(physxPINVOKE.PxBounds3_transformFast__SWIG_1(PxTransform.getCPtr(transform), PxBounds3.getCPtr(bounds)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setEmpty() {
    physxPINVOKE.PxBounds3_setEmpty(swigCPtr);
  }

  public void setMaximal() {
    physxPINVOKE.PxBounds3_setMaximal(swigCPtr);
  }

  public void include(PxVec3 v) {
    physxPINVOKE.PxBounds3_include__SWIG_0(swigCPtr, PxVec3.getCPtr(v));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public void include(PxBounds3 b) {
    physxPINVOKE.PxBounds3_include__SWIG_1(swigCPtr, PxBounds3.getCPtr(b));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isEmpty() {
    bool ret = physxPINVOKE.PxBounds3_isEmpty(swigCPtr);
    return ret;
  }

  public bool intersects(PxBounds3 b) {
    bool ret = physxPINVOKE.PxBounds3_intersects(swigCPtr, PxBounds3.getCPtr(b));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool intersects1D(PxBounds3 a, SWIGTYPE_p_uint32_t axis) {
    bool ret = physxPINVOKE.PxBounds3_intersects1D(swigCPtr, PxBounds3.getCPtr(a), SWIGTYPE_p_uint32_t.getCPtr(axis));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool contains(PxVec3 v) {
    bool ret = physxPINVOKE.PxBounds3_contains(swigCPtr, PxVec3.getCPtr(v));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isInside(PxBounds3 box) {
    bool ret = physxPINVOKE.PxBounds3_isInside(swigCPtr, PxBounds3.getCPtr(box));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxVec3 getCenter() {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxBounds3_getCenter__SWIG_0(swigCPtr), true);
    return ret;
  }

  public float getCenter(SWIGTYPE_p_uint32_t axis) {
    float ret = physxPINVOKE.PxBounds3_getCenter__SWIG_1(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(axis));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getExtents(SWIGTYPE_p_uint32_t axis) {
    float ret = physxPINVOKE.PxBounds3_getExtents__SWIG_0(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(axis));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxVec3 getDimensions() {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxBounds3_getDimensions(swigCPtr), true);
    return ret;
  }

  public PxVec3 getExtents() {
    PxVec3 ret = new PxVec3(physxPINVOKE.PxBounds3_getExtents__SWIG_1(swigCPtr), true);
    return ret;
  }

  public void scaleSafe(float scale) {
    physxPINVOKE.PxBounds3_scaleSafe(swigCPtr, scale);
  }

  public void scaleFast(float scale) {
    physxPINVOKE.PxBounds3_scaleFast(swigCPtr, scale);
  }

  public void fattenSafe(float distance) {
    physxPINVOKE.PxBounds3_fattenSafe(swigCPtr, distance);
  }

  public void fattenFast(float distance) {
    physxPINVOKE.PxBounds3_fattenFast(swigCPtr, distance);
  }

  public bool isFinite() {
    bool ret = physxPINVOKE.PxBounds3_isFinite(swigCPtr);
    return ret;
  }

  public bool isValid() {
    bool ret = physxPINVOKE.PxBounds3_isValid(swigCPtr);
    return ret;
  }

  public PxVec3 minimum {
    set {
      physxPINVOKE.PxBounds3_minimum_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxBounds3_minimum_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

  public PxVec3 maximum {
    set {
      physxPINVOKE.PxBounds3_maximum_set(swigCPtr, PxVec3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxBounds3_maximum_get(swigCPtr);
      PxVec3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxVec3(cPtr, false);
      return ret;
    } 
  }

}

}
