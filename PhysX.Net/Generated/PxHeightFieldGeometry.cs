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

public class PxHeightFieldGeometry : PxGeometry {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxHeightFieldGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxHeightFieldGeometry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxHeightFieldGeometry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxHeightFieldGeometry() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxHeightFieldGeometry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PxHeightFieldGeometry() : this(physxPINVOKE.new_PxHeightFieldGeometry__SWIG_0(), true) {
  }

  public PxHeightFieldGeometry(SWIGTYPE_p_physx__PxHeightField hf, SWIGTYPE_p_physx__PxFlagsT_physx__PxMeshGeometryFlag__Enum_uint8_t_t flags, float heightScale_, float rowScale_, float columnScale_) : this(physxPINVOKE.new_PxHeightFieldGeometry__SWIG_1(SWIGTYPE_p_physx__PxHeightField.getCPtr(hf), SWIGTYPE_p_physx__PxFlagsT_physx__PxMeshGeometryFlag__Enum_uint8_t_t.getCPtr(flags), heightScale_, rowScale_, columnScale_), true) {
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = physxPINVOKE.PxHeightFieldGeometry_isValid(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_physx__PxHeightField heightField {
    set {
      physxPINVOKE.PxHeightFieldGeometry_heightField_set(swigCPtr, SWIGTYPE_p_physx__PxHeightField.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxHeightFieldGeometry_heightField_get(swigCPtr);
      SWIGTYPE_p_physx__PxHeightField ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_physx__PxHeightField(cPtr, false);
      return ret;
    } 
  }

  public float heightScale {
    set {
      physxPINVOKE.PxHeightFieldGeometry_heightScale_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxHeightFieldGeometry_heightScale_get(swigCPtr);
      return ret;
    } 
  }

  public float rowScale {
    set {
      physxPINVOKE.PxHeightFieldGeometry_rowScale_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxHeightFieldGeometry_rowScale_get(swigCPtr);
      return ret;
    } 
  }

  public float columnScale {
    set {
      physxPINVOKE.PxHeightFieldGeometry_columnScale_set(swigCPtr, value);
    } 
    get {
      float ret = physxPINVOKE.PxHeightFieldGeometry_columnScale_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_physx__PxFlagsT_physx__PxMeshGeometryFlag__Enum_uint8_t_t heightFieldFlags {
    set {
      physxPINVOKE.PxHeightFieldGeometry_heightFieldFlags_set(swigCPtr, SWIGTYPE_p_physx__PxFlagsT_physx__PxMeshGeometryFlag__Enum_uint8_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxHeightFieldGeometry_heightFieldFlags_get(swigCPtr);
      SWIGTYPE_p_physx__PxFlagsT_physx__PxMeshGeometryFlag__Enum_uint8_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_physx__PxFlagsT_physx__PxMeshGeometryFlag__Enum_uint8_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_PxPaddingT_3_t paddingFromFlags {
    set {
      physxPINVOKE.PxHeightFieldGeometry_paddingFromFlags_set(swigCPtr, SWIGTYPE_p_PxPaddingT_3_t.getCPtr(value));
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_PxPaddingT_3_t ret = new SWIGTYPE_p_PxPaddingT_3_t(physxPINVOKE.PxHeightFieldGeometry_paddingFromFlags_get(swigCPtr), true);
      if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}