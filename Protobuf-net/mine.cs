//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: mine.proto
// Note: requires additional types generated from: team.proto
namespace mine
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MineProtoData")]
  public partial class MineProtoData : global::ProtoBuf.IExtensible
  {
    public MineProtoData() {}
    
    private int _mineNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mineNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int mineNo
    {
      get { return _mineNo; }
      set { _mineNo = value; }
    }
    private int _occNum;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"occNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int occNum
    {
      get { return _occNum; }
      set { _occNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetMineMapResp")]
  public partial class GetMineMapResp : global::ProtoBuf.IExtensible
  {
    public GetMineMapResp() {}
    
    private int _occTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"occTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int occTime
    {
      get { return _occTime; }
      set { _occTime = value; }
    }
    private int _plunderTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"plunderTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int plunderTime
    {
      get { return _plunderTime; }
      set { _plunderTime = value; }
    }

    private int _ownMineNo = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ownMineNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ownMineNo
    {
      get { return _ownMineNo; }
      set { _ownMineNo = value; }
    }

    private long _endTime = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"endTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long endTime
    {
      get { return _endTime; }
      set { _endTime = value; }
    }

    private int _inCome = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"inCome", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int inCome
    {
      get { return _inCome; }
      set { _inCome = value; }
    }
    private readonly global::System.Collections.Generic.List<mine.MineProtoData> _mines = new global::System.Collections.Generic.List<mine.MineProtoData>();
    [global::ProtoBuf.ProtoMember(6, Name=@"mines", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<mine.MineProtoData> mines
    {
      get { return _mines; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MineOccData")]
  public partial class MineOccData : global::ProtoBuf.IExtensible
  {
    public MineOccData() {}
    
    private int _roleId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"roleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int roleId
    {
      get { return _roleId; }
      set { _roleId = value; }
    }
    private string _roleName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"roleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string roleName
    {
      get { return _roleName; }
      set { _roleName = value; }
    }
    private int _fightingPower;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"fightingPower", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightingPower
    {
      get { return _fightingPower; }
      set { _fightingPower = value; }
    }
    private long _endTime;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"endTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long endTime
    {
      get { return _endTime; }
      set { _endTime = value; }
    }
    private int _headNo;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"headNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int headNo
    {
      get { return _headNo; }
      set { _headNo = value; }
    }
    private int _roleLv;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"roleLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int roleLv
    {
      get { return _roleLv; }
      set { _roleLv = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetMineInfoResp")]
  public partial class GetMineInfoResp : global::ProtoBuf.IExtensible
  {
    public GetMineInfoResp() {}
    
    private readonly global::System.Collections.Generic.List<mine.MineOccData> _occRoles = new global::System.Collections.Generic.List<mine.MineOccData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"occRoles", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<mine.MineOccData> occRoles
    {
      get { return _occRoles; }
    }
  

    private int _occNum = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"occNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int occNum
    {
      get { return _occNum; }
      set { _occNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetOccRoleInfoResp")]
  public partial class GetOccRoleInfoResp : global::ProtoBuf.IExtensible
  {
    public GetOccRoleInfoResp() {}
    
    private team.TeamDetailProtoData _team;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamDetailProtoData team
    {
      get { return _team; }
      set { _team = value; }
    }
    private long _lastPlunderTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"lastPlunderTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long lastPlunderTime
    {
      get { return _lastPlunderTime; }
      set { _lastPlunderTime = value; }
    }
    private int _inCome;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"inCome", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int inCome
    {
      get { return _inCome; }
      set { _inCome = value; }
    }
    private int _lineNo;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"lineNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int lineNo
    {
      get { return _lineNo; }
      set { _lineNo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LogProto")]
  public partial class LogProto : global::ProtoBuf.IExtensible
  {
    public LogProto() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private long _time;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _params = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"params", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> @params
    {
      get { return _params; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetOwnInfoResp")]
  public partial class GetOwnInfoResp : global::ProtoBuf.IExtensible
  {
    public GetOwnInfoResp() {}
    
    private int _inCome;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"inCome", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int inCome
    {
      get { return _inCome; }
      set { _inCome = value; }
    }
    private readonly global::System.Collections.Generic.List<mine.LogProto> _logList = new global::System.Collections.Generic.List<mine.LogProto>();
    [global::ProtoBuf.ProtoMember(2, Name=@"logList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<mine.LogProto> logList
    {
      get { return _logList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FightData")]
  public partial class FightData : global::ProtoBuf.IExtensible
  {
    public FightData() {}
    
    private team.TeamFightProtoData _selfTeamData;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"selfTeamData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamFightProtoData selfTeamData
    {
      get { return _selfTeamData; }
      set { _selfTeamData = value; }
    }
    private team.TeamFightProtoData _opponentTeamData;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"opponentTeamData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamFightProtoData opponentTeamData
    {
      get { return _opponentTeamData; }
      set { _opponentTeamData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RobMineResp")]
  public partial class RobMineResp : global::ProtoBuf.IExtensible
  {
    public RobMineResp() {}
    
    private mine.FightData _fightData;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public mine.FightData fightData
    {
      get { return _fightData; }
      set { _fightData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlunderMineResp")]
  public partial class PlunderMineResp : global::ProtoBuf.IExtensible
  {
    public PlunderMineResp() {}
    
    private mine.FightData _fightData;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public mine.FightData fightData
    {
      get { return _fightData; }
      set { _fightData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MineFightOverReq")]
  public partial class MineFightOverReq : global::ProtoBuf.IExtensible
  {
    public MineFightOverReq() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MineFightOverResp")]
  public partial class MineFightOverResp : global::ProtoBuf.IExtensible
  {
    public MineFightOverResp() {}
    

    private int _inCome = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"inCome", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int inCome
    {
      get { return _inCome; }
      set { _inCome = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}