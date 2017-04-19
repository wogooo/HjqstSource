﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: player.proto
// Note: requires additional types generated from: hero.proto
namespace Logic.Protocol.Model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetAllPlayerReq")]
  public partial class GetAllPlayerReq : global::ProtoBuf.IExtensible
  {
    public GetAllPlayerReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentProto")]
  public partial class TalentProto : global::ProtoBuf.IExtensible
  {
    public TalentProto() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }

    private int _lv = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }

    private int _exp = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerProtoData")]
  public partial class PlayerProtoData : global::ProtoBuf.IExtensible
  {
    public PlayerProtoData() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }

    private int _modelId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"modelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int modelId
    {
      get { return _modelId; }
      set { _modelId = value; }
    }

    private int _lv = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }

    private int _exp = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }

    private int _hairCutId = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"hairCutId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hairCutId
    {
      get { return _hairCutId; }
      set { _hairCutId = value; }
    }

    private int _hairColorId = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"hairColorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hairColorId
    {
      get { return _hairColorId; }
      set { _hairColorId = value; }
    }

    private int _faceId = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"faceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int faceId
    {
      get { return _faceId; }
      set { _faceId = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _wearEquips = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(8, Name=@"wearEquips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> wearEquips
    {
      get { return _wearEquips; }
    }
  

    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }

    private int _aggrLv = (int)-1;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"aggrLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int aggrLv
    {
      get { return _aggrLv; }
      set { _aggrLv = value; }
    }

    private int _aggrExp = (int)-1;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"aggrExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int aggrExp
    {
      get { return _aggrExp; }
      set { _aggrExp = value; }
    }

    private int _breakLayer = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"breakLayer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int breakLayer
    {
      get { return _breakLayer; }
      set { _breakLayer = value; }
    }
    private readonly global::System.Collections.Generic.List<Logic.Protocol.Model.TalentProto> _talnets = new global::System.Collections.Generic.List<Logic.Protocol.Model.TalentProto>();
    [global::ProtoBuf.ProtoMember(13, Name=@"talnets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Logic.Protocol.Model.TalentProto> talnets
    {
      get { return _talnets; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _selectedTalnet = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(14, Name=@"selectedTalnet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> selectedTalnet
    {
      get { return _selectedTalnet; }
    }
  
    private readonly global::System.Collections.Generic.List<Logic.Protocol.Model.HeroRelationProto> _relations = new global::System.Collections.Generic.List<Logic.Protocol.Model.HeroRelationProto>();
    [global::ProtoBuf.ProtoMember(15, Name=@"relations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Logic.Protocol.Model.HeroRelationProto> relations
    {
      get { return _relations; }
    }
  

    private int _skinId = default(int);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"skinId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int skinId
    {
      get { return _skinId; }
      set { _skinId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetAllPlayerResp")]
  public partial class GetAllPlayerResp : global::ProtoBuf.IExtensible
  {
    public GetAllPlayerResp() {}
    
    private int _currPlayerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"currPlayerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int currPlayerId
    {
      get { return _currPlayerId; }
      set { _currPlayerId = value; }
    }
    private readonly global::System.Collections.Generic.List<Logic.Protocol.Model.PlayerProtoData> _players = new global::System.Collections.Generic.List<Logic.Protocol.Model.PlayerProtoData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"players", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Logic.Protocol.Model.PlayerProtoData> players
    {
      get { return _players; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerUpdateResp")]
  public partial class PlayerUpdateResp : global::ProtoBuf.IExtensible
  {
    public PlayerUpdateResp() {}
    
    private Logic.Protocol.Model.PlayerProtoData _player;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Logic.Protocol.Model.PlayerProtoData player
    {
      get { return _player; }
      set { _player = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerTransferReq")]
  public partial class PlayerTransferReq : global::ProtoBuf.IExtensible
  {
    public PlayerTransferReq() {}
    
    private int _desProfessionId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"desProfessionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int desProfessionId
    {
      get { return _desProfessionId; }
      set { _desProfessionId = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _srcMaterialNos = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"srcMaterialNos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> srcMaterialNos
    {
      get { return _srcMaterialNos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerTransferResp")]
  public partial class PlayerTransferResp : global::ProtoBuf.IExtensible
  {
    public PlayerTransferResp() {}
    
    private Logic.Protocol.Model.PlayerProtoData _newPlayer;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"newPlayer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Logic.Protocol.Model.PlayerProtoData newPlayer
    {
      get { return _newPlayer; }
      set { _newPlayer = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerChangeReq")]
  public partial class PlayerChangeReq : global::ProtoBuf.IExtensible
  {
    public PlayerChangeReq() {}
    
    private int _desInstanceId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"desInstanceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int desInstanceId
    {
      get { return _desInstanceId; }
      set { _desInstanceId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerChangeResp")]
  public partial class PlayerChangeResp : global::ProtoBuf.IExtensible
  {
    public PlayerChangeResp() {}
    
    private int _desInstanceId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"desInstanceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int desInstanceId
    {
      get { return _desInstanceId; }
      set { _desInstanceId = value; }
    }
    private Logic.Protocol.Model.PlayerProtoData _newPlayer;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"newPlayer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Logic.Protocol.Model.PlayerProtoData newPlayer
    {
      get { return _newPlayer; }
      set { _newPlayer = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerAggrReq")]
  public partial class PlayerAggrReq : global::ProtoBuf.IExtensible
  {
    public PlayerAggrReq() {}
    
    private int _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _consumeIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"consumeIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> consumeIds
    {
      get { return _consumeIds; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerAggrResp")]
  public partial class PlayerAggrResp : global::ProtoBuf.IExtensible
  {
    public PlayerAggrResp() {}
    
    private bool _isCrit;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"isCrit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isCrit
    {
      get { return _isCrit; }
      set { _isCrit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerBreakReq")]
  public partial class PlayerBreakReq : global::ProtoBuf.IExtensible
  {
    public PlayerBreakReq() {}
    
    private int _costIndex;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"costIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int costIndex
    {
      get { return _costIndex; }
      set { _costIndex = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerBreakResp")]
  public partial class PlayerBreakResp : global::ProtoBuf.IExtensible
  {
    public PlayerBreakResp() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentActivateReq")]
  public partial class TalentActivateReq : global::ProtoBuf.IExtensible
  {
    public TalentActivateReq() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentActivateResp")]
  public partial class TalentActivateResp : global::ProtoBuf.IExtensible
  {
    public TalentActivateResp() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentUpgradeReq")]
  public partial class TalentUpgradeReq : global::ProtoBuf.IExtensible
  {
    public TalentUpgradeReq() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentUpgradeResp")]
  public partial class TalentUpgradeResp : global::ProtoBuf.IExtensible
  {
    public TalentUpgradeResp() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentChooseRep")]
  public partial class TalentChooseRep : global::ProtoBuf.IExtensible
  {
    public TalentChooseRep() {}
    
    private readonly global::System.Collections.Generic.List<int> _selectedTalnet = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"selectedTalnet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> selectedTalnet
    {
      get { return _selectedTalnet; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentChooseResp")]
  public partial class TalentChooseResp : global::ProtoBuf.IExtensible
  {
    public TalentChooseResp() {}
    
    private readonly global::System.Collections.Generic.List<int> _selectedTalnet = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"selectedTalnet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> selectedTalnet
    {
      get { return _selectedTalnet; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentSynResp")]
  public partial class TalentSynResp : global::ProtoBuf.IExtensible
  {
    public TalentSynResp() {}
    
    private readonly global::System.Collections.Generic.List<Logic.Protocol.Model.TalentProto> _talnets = new global::System.Collections.Generic.List<Logic.Protocol.Model.TalentProto>();
    [global::ProtoBuf.ProtoMember(1, Name=@"talnets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Logic.Protocol.Model.TalentProto> talnets
    {
      get { return _talnets; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerAdvanceReq")]
  public partial class PlayerAdvanceReq : global::ProtoBuf.IExtensible
  {
    public PlayerAdvanceReq() {}
    
    private int _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerAdvanceResp")]
  public partial class PlayerAdvanceResp : global::ProtoBuf.IExtensible
  {
    public PlayerAdvanceResp() {}
    

    private int _result = (int)1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}