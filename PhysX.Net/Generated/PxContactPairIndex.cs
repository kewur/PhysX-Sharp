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

public class PxContactPairIndex : PxContactPairExtraDataItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxContactPairIndex(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxContactPairIndex_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxContactPairIndex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxContactPairIndex() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxContactPairIndex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PxContactPairIndex() : this(physxPINVOKE.new_PxContactPairIndex(), true) {
  }

  public SWIGTYPE_p_uint16_t index {
    set {
      physxPINVOKE.PxContactPairIndex_index_set(swigCPtr, SWIGTYPE_p_uint16_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint16_t ret = new SWIGTYPE_p_uint16_t(physxPINVOKE.PxContactPairIndex_index_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
