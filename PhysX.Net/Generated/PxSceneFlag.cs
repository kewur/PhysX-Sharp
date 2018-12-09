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

public class PxSceneFlag : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PxSceneFlag(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxSceneFlag obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PxSceneFlag() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          physxPINVOKE.delete_PxSceneFlag(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PxSceneFlag() : this(physxPINVOKE.new_PxSceneFlag(), true) {
  }

  public enum Enum {
    eENABLE_ACTIVE_ACTORS = (1 << 0),
    eENABLE_ACTIVETRANSFORMS = (1 << 1),
    eENABLE_CCD = (1 << 2),
    eDISABLE_CCD_RESWEEP = (1 << 3),
    eADAPTIVE_FORCE = (1 << 4),
    eENABLE_KINEMATIC_STATIC_PAIRS = (1 << 5),
    eENABLE_KINEMATIC_PAIRS = (1 << 6),
    eENABLE_PCM = (1 << 9),
    eDISABLE_CONTACT_REPORT_BUFFER_RESIZE = (1 << 10),
    eDISABLE_CONTACT_CACHE = (1 << 11),
    eREQUIRE_RW_LOCK = (1 << 12),
    eENABLE_STABILIZATION = (1 << 14),
    eENABLE_AVERAGE_POINT = (1 << 15),
    eDEPRECATED_TRIGGER_TRIGGER_REPORTS = (1 << 16),
    eEXCLUDE_KINEMATICS_FROM_ACTIVE_ACTORS = (1 << 17),
    eSUPPRESS_EAGER_SCENE_QUERY_REFIT = (1 << 18),
    eENABLE_GPU_DYNAMICS = (1 << 19),
    eENABLE_ENHANCED_DETERMINISM = (1 << 20),
    eMUTABLE_FLAGS = eENABLE_ACTIVE_ACTORS|eENABLE_ACTIVETRANSFORMS|eEXCLUDE_KINEMATICS_FROM_ACTIVE_ACTORS
  }

}

}