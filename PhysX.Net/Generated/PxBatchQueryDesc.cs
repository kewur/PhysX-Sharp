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

public class PxBatchQueryDesc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxBatchQueryDesc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxBatchQueryDesc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxBatchQueryDesc() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxBatchQueryDesc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_void filterShaderData {
    set {
      physxPINVOKE.PxBatchQueryDesc_filterShaderData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxBatchQueryDesc_filterShaderData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t filterShaderDataSize {
    set {
      physxPINVOKE.PxBatchQueryDesc_filterShaderDataSize_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxBatchQueryDesc_filterShaderDataSize_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_physx__PxHitFlags__physx__PxQueryHitType__Enum preFilterShader {
    set {
      physxPINVOKE.PxBatchQueryDesc_preFilterShader_set(swigCPtr, SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_physx__PxHitFlags__physx__PxQueryHitType__Enum.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxBatchQueryDesc_preFilterShader_get(swigCPtr);
      SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_physx__PxHitFlags__physx__PxQueryHitType__Enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_physx__PxHitFlags__physx__PxQueryHitType__Enum(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_q_const__physx__PxQueryHit__physx__PxQueryHitType__Enum postFilterShader {
    set {
      physxPINVOKE.PxBatchQueryDesc_postFilterShader_set(swigCPtr, SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_q_const__physx__PxQueryHit__physx__PxQueryHitType__Enum.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxBatchQueryDesc_postFilterShader_get(swigCPtr);
      SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_q_const__physx__PxQueryHit__physx__PxQueryHitType__Enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_physx__PxFilterData_physx__PxFilterData_p_q_const__void_physx__PxU32_r_q_const__physx__PxQueryHit__physx__PxQueryHitType__Enum(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint8_t ownerClient {
    set {
      physxPINVOKE.PxBatchQueryDesc_ownerClient_set(swigCPtr, SWIGTYPE_p_uint8_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint8_t ret = new SWIGTYPE_p_uint8_t(physxPINVOKE.PxBatchQueryDesc_ownerClient_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PxBatchQueryMemory queryMemory {
    set {
      physxPINVOKE.PxBatchQueryDesc_queryMemory_set(swigCPtr, PxBatchQueryMemory.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxBatchQueryDesc_queryMemory_get(swigCPtr);
      PxBatchQueryMemory ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxBatchQueryMemory(cPtr, false);
      return ret;
    } 
  }

  public PxBatchQueryDesc(SWIGTYPE_p_uint32_t maxRaycastsPerExecute, SWIGTYPE_p_uint32_t maxSweepsPerExecute, SWIGTYPE_p_uint32_t maxOverlapsPerExecute) : this(physxPINVOKE.new_PxBatchQueryDesc(SWIGTYPE_p_uint32_t.getCPtr(maxRaycastsPerExecute), SWIGTYPE_p_uint32_t.getCPtr(maxSweepsPerExecute), SWIGTYPE_p_uint32_t.getCPtr(maxOverlapsPerExecute)), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = physxPINVOKE.PxBatchQueryDesc_isValid(swigCPtr);
    return ret;
  }

}

}
