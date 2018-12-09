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

public class PxModifiableContact : PxExtendedContact {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxModifiableContact(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxModifiableContact_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxModifiableContact obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxModifiableContact() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxModifiableContact(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public float restitution {
    set {
      physxPINVOKE.PxModifiableContact_restitution_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxModifiableContact_restitution_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint32_t materialFlags {
    set {
      physxPINVOKE.PxModifiableContact_materialFlags_set(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxModifiableContact_materialFlags_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint16_t materialIndex0 {
    set {
      physxPINVOKE.PxModifiableContact_materialIndex0_set(swigCPtr, SWIGTYPE_p_uint16_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint16_t ret = new SWIGTYPE_p_uint16_t(physxPINVOKE.PxModifiableContact_materialIndex0_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_uint16_t materialIndex1 {
    set {
      physxPINVOKE.PxModifiableContact_materialIndex1_set(swigCPtr, SWIGTYPE_p_uint16_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint16_t ret = new SWIGTYPE_p_uint16_t(physxPINVOKE.PxModifiableContact_materialIndex1_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float staticFriction {
    set {
      physxPINVOKE.PxModifiableContact_staticFriction_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxModifiableContact_staticFriction_get(swigCPtr);
      return ret;
    } 
  }

  public float dynamicFriction {
    set {
      physxPINVOKE.PxModifiableContact_dynamicFriction_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxModifiableContact_dynamicFriction_get(swigCPtr);
      return ret;
    } 
  }

  public PxModifiableContact() : this(physxPINVOKE.new_PxModifiableContact(), true) {
  }

}

}