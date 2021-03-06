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

public class PxVisualizationParameter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxVisualizationParameter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxVisualizationParameter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxVisualizationParameter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxVisualizationParameter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxVisualizationParameter() : this(physxPINVOKE.new_PxVisualizationParameter(), true) {
  }

  public enum Enum {
    eSCALE,
    eWORLD_AXES,
    eBODY_AXES,
    eBODY_MASS_AXES,
    eBODY_LIN_VELOCITY,
    eBODY_ANG_VELOCITY,
    eDEPRECATED_BODY_JOINT_GROUPS,
    eCONTACT_POINT,
    eCONTACT_NORMAL,
    eCONTACT_ERROR,
    eCONTACT_FORCE,
    eACTOR_AXES,
    eCOLLISION_AABBS,
    eCOLLISION_SHAPES,
    eCOLLISION_AXES,
    eCOLLISION_COMPOUNDS,
    eCOLLISION_FNORMALS,
    eCOLLISION_EDGES,
    eCOLLISION_STATIC,
    eCOLLISION_DYNAMIC,
    eDEPRECATED_COLLISION_PAIRS,
    eJOINT_LOCAL_FRAMES,
    eJOINT_LIMITS,
    ePARTICLE_SYSTEM_POSITION,
    ePARTICLE_SYSTEM_VELOCITY,
    ePARTICLE_SYSTEM_COLLISION_NORMAL,
    ePARTICLE_SYSTEM_BOUNDS,
    ePARTICLE_SYSTEM_GRID,
    ePARTICLE_SYSTEM_BROADPHASE_BOUNDS,
    ePARTICLE_SYSTEM_MAX_MOTION_DISTANCE,
    eCULL_BOX,
    eCLOTH_VERTICAL,
    eCLOTH_HORIZONTAL,
    eCLOTH_BENDING,
    eCLOTH_SHEARING,
    eCLOTH_VIRTUAL_PARTICLES,
    eMBP_REGIONS,
    eNUM_VALUES,
    eFORCE_DWORD = 0x7fffffff
  }

}

}
