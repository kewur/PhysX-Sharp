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

public class PxShape : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(physxPINVOKE.PxShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void release() {
    physxPINVOKE.PxShape_release(swigCPtr);
  }

  public virtual void acquireReference() {
    physxPINVOKE.PxShape_acquireReference(swigCPtr);
  }

  public virtual PxGeometryType.Enum getGeometryType() {
    PxGeometryType.Enum ret = (PxGeometryType.Enum)physxPINVOKE.PxShape_getGeometryType(swigCPtr);
    return ret;
  }

  public virtual void setGeometry(PxGeometry geometry) {
    physxPINVOKE.PxShape_setGeometry(swigCPtr, PxGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual PxGeometryHolder getGeometry() {
    PxGeometryHolder ret = new PxGeometryHolder(physxPINVOKE.PxShape_getGeometry(swigCPtr), true);
    return ret;
  }

  public virtual bool getBoxGeometry(PxBoxGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getBoxGeometry(swigCPtr, PxBoxGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getSphereGeometry(PxSphereGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getSphereGeometry(swigCPtr, PxSphereGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getCapsuleGeometry(PxCapsuleGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getCapsuleGeometry(swigCPtr, PxCapsuleGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getPlaneGeometry(PxPlaneGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getPlaneGeometry(swigCPtr, PxPlaneGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getConvexMeshGeometry(PxConvexMeshGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getConvexMeshGeometry(swigCPtr, PxConvexMeshGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getTriangleMeshGeometry(PxTriangleMeshGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getTriangleMeshGeometry(swigCPtr, PxTriangleMeshGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getHeightFieldGeometry(PxHeightFieldGeometry geometry) {
    bool ret = physxPINVOKE.PxShape_getHeightFieldGeometry(swigCPtr, PxHeightFieldGeometry.getCPtr(geometry));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PxRigidActor getActor() {
    global::System.IntPtr cPtr = physxPINVOKE.PxShape_getActor(swigCPtr);
    PxRigidActor ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxRigidActor(cPtr, false);
    return ret;
  }

  public virtual void setLocalPose(PxTransform pose) {
    physxPINVOKE.PxShape_setLocalPose(swigCPtr, PxTransform.getCPtr(pose));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual PxTransform getLocalPose() {
    PxTransform ret = new PxTransform(physxPINVOKE.PxShape_getLocalPose(swigCPtr), true);
    return ret;
  }

  public virtual void setSimulationFilterData(PxFilterData data) {
    physxPINVOKE.PxShape_setSimulationFilterData(swigCPtr, PxFilterData.getCPtr(data));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual PxFilterData getSimulationFilterData() {
    PxFilterData ret = new PxFilterData(physxPINVOKE.PxShape_getSimulationFilterData(swigCPtr), true);
    return ret;
  }

  public virtual void setQueryFilterData(PxFilterData data) {
    physxPINVOKE.PxShape_setQueryFilterData(swigCPtr, PxFilterData.getCPtr(data));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual PxFilterData getQueryFilterData() {
    PxFilterData ret = new PxFilterData(physxPINVOKE.PxShape_getQueryFilterData(swigCPtr), true);
    return ret;
  }

  public virtual void setMaterials(SWIGTYPE_p_p_physx__PxMaterial materials, SWIGTYPE_p_uint16_t materialCount) {
    physxPINVOKE.PxShape_setMaterials(swigCPtr, SWIGTYPE_p_p_physx__PxMaterial.getCPtr(materials), SWIGTYPE_p_uint16_t.getCPtr(materialCount));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_uint16_t getNbMaterials() {
    SWIGTYPE_p_uint16_t ret = new SWIGTYPE_p_uint16_t(physxPINVOKE.PxShape_getNbMaterials(swigCPtr), true);
    return ret;
  }

  public virtual SWIGTYPE_p_uint32_t getMaterials(SWIGTYPE_p_p_physx__PxMaterial userBuffer, SWIGTYPE_p_uint32_t bufferSize, SWIGTYPE_p_uint32_t startIndex) {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxShape_getMaterials__SWIG_0(swigCPtr, SWIGTYPE_p_p_physx__PxMaterial.getCPtr(userBuffer), SWIGTYPE_p_uint32_t.getCPtr(bufferSize), SWIGTYPE_p_uint32_t.getCPtr(startIndex)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_uint32_t getMaterials(SWIGTYPE_p_p_physx__PxMaterial userBuffer, SWIGTYPE_p_uint32_t bufferSize) {
    SWIGTYPE_p_uint32_t ret = new SWIGTYPE_p_uint32_t(physxPINVOKE.PxShape_getMaterials__SWIG_1(swigCPtr, SWIGTYPE_p_p_physx__PxMaterial.getCPtr(userBuffer), SWIGTYPE_p_uint32_t.getCPtr(bufferSize)), true);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual PxMaterial getMaterialFromInternalFaceIndex(SWIGTYPE_p_uint32_t faceIndex) {
    global::System.IntPtr cPtr = physxPINVOKE.PxShape_getMaterialFromInternalFaceIndex(swigCPtr, SWIGTYPE_p_uint32_t.getCPtr(faceIndex));
    PxMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new PxMaterial(cPtr, false);
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setContactOffset(float contactOffset) {
    physxPINVOKE.PxShape_setContactOffset(swigCPtr, contactOffset);
  }

  public virtual float getContactOffset() {
    float ret = physxPINVOKE.PxShape_getContactOffset(swigCPtr);
    return ret;
  }

  public virtual void setRestOffset(float restOffset) {
    physxPINVOKE.PxShape_setRestOffset(swigCPtr, restOffset);
  }

  public virtual float getRestOffset() {
    float ret = physxPINVOKE.PxShape_getRestOffset(swigCPtr);
    return ret;
  }

  public virtual void setFlag(PxShapeFlag.Enum flag, bool value) {
    physxPINVOKE.PxShape_setFlag(swigCPtr, (int)flag, value);
  }

  public virtual void setFlags(SWIGTYPE_p_physx__PxFlagsT_physx__PxShapeFlag__Enum_uint8_t_t inFlags) {
    physxPINVOKE.PxShape_setFlags(swigCPtr, SWIGTYPE_p_physx__PxFlagsT_physx__PxShapeFlag__Enum_uint8_t_t.getCPtr(inFlags));
    if (physxPINVOKE.SWIGPendingException.Pending) throw physxPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_physx__PxFlagsT_physx__PxShapeFlag__Enum_uint8_t_t getFlags() {
    SWIGTYPE_p_physx__PxFlagsT_physx__PxShapeFlag__Enum_uint8_t_t ret = new SWIGTYPE_p_physx__PxFlagsT_physx__PxShapeFlag__Enum_uint8_t_t(physxPINVOKE.PxShape_getFlags(swigCPtr), true);
    return ret;
  }

  public virtual bool isExclusive() {
    bool ret = physxPINVOKE.PxShape_isExclusive(swigCPtr);
    return ret;
  }

  public virtual void setName(string name) {
    physxPINVOKE.PxShape_setName(swigCPtr, name);
  }

  public virtual string getName() {
    string ret = physxPINVOKE.PxShape_getName(swigCPtr);
    return ret;
  }

  public override string getConcreteTypeName() {
    string ret = physxPINVOKE.PxShape_getConcreteTypeName(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_void userData {
    set {
      physxPINVOKE.PxShape_userData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = physxPINVOKE.PxShape_userData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

}

}
