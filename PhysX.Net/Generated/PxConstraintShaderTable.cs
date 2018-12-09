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

public class PxConstraintShaderTable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxConstraintShaderTable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxConstraintShaderTable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxConstraintShaderTable() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxConstraintShaderTable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_p_physx__Px1DConstraint_r_physx__PxVec3_uint32_t_r_physx__PxConstraintInvMassScale_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform__uint32_t solverPrep {
    set {
      physxPINVOKE.PxConstraintShaderTable_solverPrep_set(swigCPtr, SWIGTYPE_p_f_p_physx__Px1DConstraint_r_physx__PxVec3_uint32_t_r_physx__PxConstraintInvMassScale_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform__uint32_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxConstraintShaderTable_solverPrep_get(swigCPtr);
      SWIGTYPE_p_f_p_physx__Px1DConstraint_r_physx__PxVec3_uint32_t_r_physx__PxConstraintInvMassScale_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform__uint32_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_physx__Px1DConstraint_r_physx__PxVec3_uint32_t_r_physx__PxConstraintInvMassScale_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform__uint32_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_q_const__void_r_physx__PxTransform_r_physx__PxTransform_bool__void project {
    set {
      physxPINVOKE.PxConstraintShaderTable_project_set(swigCPtr, SWIGTYPE_p_f_p_q_const__void_r_physx__PxTransform_r_physx__PxTransform_bool__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxConstraintShaderTable_project_get(swigCPtr);
      SWIGTYPE_p_f_p_q_const__void_r_physx__PxTransform_r_physx__PxTransform_bool__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_q_const__void_r_physx__PxTransform_r_physx__PxTransform_bool__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_r_physx__PxConstraintVisualizer_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform_uint32_t__void visualize {
    set {
      physxPINVOKE.PxConstraintShaderTable_visualize_set(swigCPtr, SWIGTYPE_p_f_r_physx__PxConstraintVisualizer_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform_uint32_t__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxConstraintShaderTable_visualize_get(swigCPtr);
      SWIGTYPE_p_f_r_physx__PxConstraintVisualizer_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform_uint32_t__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_r_physx__PxConstraintVisualizer_p_q_const__void_r_q_const__physx__PxTransform_r_q_const__physx__PxTransform_uint32_t__void(cPtr, false);
      return ret;
    } 
  }

  public PxConstraintFlag.Enum flag {
    set {
      physxPINVOKE.PxConstraintShaderTable_flag_set(swigCPtr, (int)value);
    } 
    get {
      PxConstraintFlag.Enum ret = (PxConstraintFlag.Enum)physxPINVOKE.PxConstraintShaderTable_flag_get(swigCPtr);
      return ret;
    } 
  }

  public PxConstraintShaderTable() : this(physxPINVOKE.new_PxConstraintShaderTable(), true) {
  }

  public static readonly int eMAX_SOLVERPRPEP_DATASIZE = physxPINVOKE.PxConstraintShaderTable_eMAX_SOLVERPRPEP_DATASIZE_get();

}

}
