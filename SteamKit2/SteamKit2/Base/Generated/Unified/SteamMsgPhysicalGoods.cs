//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_physicalgoods.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_RegisterSteamController_Request")]
  public partial class CPhysicalGoods_RegisterSteamController_Request : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_RegisterSteamController_Request() {}
    

    private string _serial_number = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_RegisterSteamController_Response")]
  public partial class CPhysicalGoods_RegisterSteamController_Response : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_RegisterSteamController_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IPhysicalGoods
    {
      CPhysicalGoods_RegisterSteamController_Response RegisterSteamController(CPhysicalGoods_RegisterSteamController_Request request);
    
    }
    
    
}
#pragma warning restore 1591
