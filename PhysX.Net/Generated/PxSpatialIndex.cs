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

public class PxSpatialIndex : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxSpatialIndex(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxSpatialIndex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual SWIGTYPE_p_uint32_t insert(PxSpatialIndexItem item, PxBounds3 bounds) {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxSpatialIndex_insert(swigCPtr, PxSpatialIndexItem.getCPtr(item), PxBounds3.getCPtr(bounds)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void update(SWIGTYPE_p_uint32_t id, PxBounds3 bounds) {
    physxPINVOKE.PxSpatialIndex_update(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(id), PxBounds3.getCPtr(bounds));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void remove(SWIGTYPE_p_uint32_t id) {
    physxPINVOKE.PxSpatialIndex_remove(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(id));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void overlap(PxBounds3 aabb, PxSpatialOverlapCallback callback) {
    physxPINVOKE.PxSpatialIndex_overlap(swigCPtr, PxBounds3.getCPtr(aabb), PxSpatialOverlapCallback.getCPtr(callback));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void raycast(PxVec3 origin, PxVec3 unitDir, float maxDist, PxSpatialLocationCallback callback) {
    physxPINVOKE.PxSpatialIndex_raycast(swigCPtr, PxVec3.getCPtr(origin), PxVec3.getCPtr(unitDir), maxDist, PxSpatialLocationCallback.getCPtr(callback));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void sweep(PxBounds3 aabb, PxVec3 unitDir, float maxDist, PxSpatialLocationCallback callback) {
    physxPINVOKE.PxSpatialIndex_sweep(swigCPtr, PxBounds3.getCPtr(aabb), PxVec3.getCPtr(unitDir), maxDist, PxSpatialLocationCallback.getCPtr(callback));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void flush() {
    physxPINVOKE.PxSpatialIndex_flush(swigCPtr);
  }

  public virtual void rebuildFull() {
    physxPINVOKE.PxSpatialIndex_rebuildFull(swigCPtr);
  }

  public virtual void setIncrementalRebuildRate(SWIGTYPE_p_uint32_t rate) {
    physxPINVOKE.PxSpatialIndex_setIncrementalRebuildRate(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(rate));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rebuildStep() {
    physxPINVOKE.PxSpatialIndex_rebuildStep(swigCPtr);
  }

  public virtual void release() {
    physxPINVOKE.PxSpatialIndex_release(swigCPtr);
  }

}

}
