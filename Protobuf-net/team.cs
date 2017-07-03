//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: team.proto
// Note: requires additional types generated from: player.proto
namespace team
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupProtoData")]
  public partial class LineupProtoData : global::ProtoBuf.IExtensible
  {
    public LineupProtoData() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }

    private int _lv = (int)1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }

    private bool _attrIsActive = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"attrIsActive", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool attrIsActive
    {
      get { return _attrIsActive; }
      set { _attrIsActive = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PosProtoData")]
  public partial class PosProtoData : global::ProtoBuf.IExtensible
  {
    public PosProtoData() {}
    
    private int _posIndex;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"posIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int posIndex
    {
      get { return _posIndex; }
      set { _posIndex = value; }
    }
    private int _heroId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"heroId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int heroId
    {
      get { return _heroId; }
      set { _heroId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamProtoData")]
  public partial class TeamProtoData : global::ProtoBuf.IExtensible
  {
    public TeamProtoData() {}
    
    private int _teamNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"teamNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int teamNo
    {
      get { return _teamNo; }
      set { _teamNo = value; }
    }
    private int _lineupNo;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"lineupNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int lineupNo
    {
      get { return _lineupNo; }
      set { _lineupNo = value; }
    }
    private readonly global::System.Collections.Generic.List<team.PosProtoData> _posList = new global::System.Collections.Generic.List<team.PosProtoData>();
    [global::ProtoBuf.ProtoMember(3, Name=@"posList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.PosProtoData> posList
    {
      get { return _posList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamPlayerProtoData")]
  public partial class TeamPlayerProtoData : global::ProtoBuf.IExtensible
  {
    public TeamPlayerProtoData() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }

    private int _posIndex = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"posIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int posIndex
    {
      get { return _posIndex; }
      set { _posIndex = value; }
    }

    private int _playerNo = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playerNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int playerNo
    {
      get { return _playerNo; }
      set { _playerNo = value; }
    }

    private int _lv = (int)1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }

    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }

    private int _aggrLv = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"aggrLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int aggrLv
    {
      get { return _aggrLv; }
      set { _aggrLv = value; }
    }

    private int _breakLayer = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"breakLayer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int breakLayer
    {
      get { return _breakLayer; }
      set { _breakLayer = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamHeroProtoData")]
  public partial class TeamHeroProtoData : global::ProtoBuf.IExtensible
  {
    public TeamHeroProtoData() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }

    private int _posIndex = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"posIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int posIndex
    {
      get { return _posIndex; }
      set { _posIndex = value; }
    }

    private int _heroNo = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"heroNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int heroNo
    {
      get { return _heroNo; }
      set { _heroNo = value; }
    }

    private int _lv = (int)1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1)]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }

    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }

    private int _aggrLv = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"aggrLv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int aggrLv
    {
      get { return _aggrLv; }
      set { _aggrLv = value; }
    }

    private int _breakLayer = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"breakLayer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int breakLayer
    {
      get { return _breakLayer; }
      set { _breakLayer = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamDetailProtoData")]
  public partial class TeamDetailProtoData : global::ProtoBuf.IExtensible
  {
    public TeamDetailProtoData() {}
    
    private team.TeamPlayerProtoData _player;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamPlayerProtoData player
    {
      get { return _player; }
      set { _player = value; }
    }
    private readonly global::System.Collections.Generic.List<team.TeamHeroProtoData> _heros = new global::System.Collections.Generic.List<team.TeamHeroProtoData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"heros", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.TeamHeroProtoData> heros
    {
      get { return _heros; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroAttrProtoData")]
  public partial class HeroAttrProtoData : global::ProtoBuf.IExtensible
  {
    public HeroAttrProtoData() {}
    

    private int _hp = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hp
    {
      get { return _hp; }
      set { _hp = value; }
    }

    private int _normal_atk = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"normal_atk", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int normal_atk
    {
      get { return _normal_atk; }
      set { _normal_atk = value; }
    }

    private int _magic_atk = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"magic_atk", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int magic_atk
    {
      get { return _magic_atk; }
      set { _magic_atk = value; }
    }

    private int _normal_def = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"normal_def", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int normal_def
    {
      get { return _normal_def; }
      set { _normal_def = value; }
    }

    private int _magic_def = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"magic_def", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int magic_def
    {
      get { return _magic_def; }
      set { _magic_def = value; }
    }

    private int _speed = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int speed
    {
      get { return _speed; }
      set { _speed = value; }
    }

    private float _hit = default(float);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"hit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float hit
    {
      get { return _hit; }
      set { _hit = value; }
    }

    private float _dodge = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"dodge", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float dodge
    {
      get { return _dodge; }
      set { _dodge = value; }
    }

    private float _crit = default(float);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"crit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float crit
    {
      get { return _crit; }
      set { _crit = value; }
    }

    private float _anti_crit = default(float);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"anti_crit", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float anti_crit
    {
      get { return _anti_crit; }
      set { _anti_crit = value; }
    }

    private float _block = default(float);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"block", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float block
    {
      get { return _block; }
      set { _block = value; }
    }

    private float _anti_block = default(float);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"anti_block", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float anti_block
    {
      get { return _anti_block; }
      set { _anti_block = value; }
    }

    private float _counter_atk = default(float);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"counter_atk", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float counter_atk
    {
      get { return _counter_atk; }
      set { _counter_atk = value; }
    }

    private float _crit_hurt_add = default(float);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"crit_hurt_add", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float crit_hurt_add
    {
      get { return _crit_hurt_add; }
      set { _crit_hurt_add = value; }
    }

    private float _crit_hurt_dec = default(float);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"crit_hurt_dec", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float crit_hurt_dec
    {
      get { return _crit_hurt_dec; }
      set { _crit_hurt_dec = value; }
    }

    private float _armor = default(float);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"armor", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float armor
    {
      get { return _armor; }
      set { _armor = value; }
    }

    private float _damage_dec = default(float);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"damage_dec", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float damage_dec
    {
      get { return _damage_dec; }
      set { _damage_dec = value; }
    }

    private float _damage_add = default(float);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"damage_add", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float damage_add
    {
      get { return _damage_add; }
      set { _damage_add = value; }
    }

    private int _hpUp = default(int);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"hpUp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hpUp
    {
      get { return _hpUp; }
      set { _hpUp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerFightProtoData")]
  public partial class PlayerFightProtoData : global::ProtoBuf.IExtensible
  {
    public PlayerFightProtoData() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _posIndex;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"posIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int posIndex
    {
      get { return _posIndex; }
      set { _posIndex = value; }
    }
    private team.HeroAttrProtoData _attr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.HeroAttrProtoData attr
    {
      get { return _attr; }
      set { _attr = value; }
    }

    private int _aeonId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"aeonId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int aeonId
    {
      get { return _aeonId; }
      set { _aeonId = value; }
    }

    private int _modelId = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"modelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int modelId
    {
      get { return _modelId; }
      set { _modelId = value; }
    }

    private int _hairCutId = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"hairCutId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hairCutId
    {
      get { return _hairCutId; }
      set { _hairCutId = value; }
    }

    private int _hairColorId = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"hairColorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int hairColorId
    {
      get { return _hairColorId; }
      set { _hairColorId = value; }
    }

    private int _faceId = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"faceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int faceId
    {
      get { return _faceId; }
      set { _faceId = value; }
    }

    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private readonly global::System.Collections.Generic.List<player.TalentProto> _talnets = new global::System.Collections.Generic.List<player.TalentProto>();
    [global::ProtoBuf.ProtoMember(10, Name=@"talnets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<player.TalentProto> talnets
    {
      get { return _talnets; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _selectedTalnet = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(11, Name=@"selectedTalnet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> selectedTalnet
    {
      get { return _selectedTalnet; }
    }
  

    private int _skinId = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"skinId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroFightProtoData")]
  public partial class HeroFightProtoData : global::ProtoBuf.IExtensible
  {
    public HeroFightProtoData() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _posIndex;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"posIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int posIndex
    {
      get { return _posIndex; }
      set { _posIndex = value; }
    }
    private team.HeroAttrProtoData _attr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"attr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.HeroAttrProtoData attr
    {
      get { return _attr; }
      set { _attr = value; }
    }

    private int _modelId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"modelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int modelId
    {
      get { return _modelId; }
      set { _modelId = value; }
    }

    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamFightProtoData")]
  public partial class TeamFightProtoData : global::ProtoBuf.IExtensible
  {
    public TeamFightProtoData() {}
    

    private team.PlayerFightProtoData _player = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public team.PlayerFightProtoData player
    {
      get { return _player; }
      set { _player = value; }
    }
    private readonly global::System.Collections.Generic.List<team.HeroFightProtoData> _heros = new global::System.Collections.Generic.List<team.HeroFightProtoData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"heros", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.HeroFightProtoData> heros
    {
      get { return _heros; }
    }
  
    private team.LineupProtoData _lineup;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"lineup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.LineupProtoData lineup
    {
      get { return _lineup; }
      set { _lineup = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamInfoReq")]
  public partial class TeamInfoReq : global::ProtoBuf.IExtensible
  {
    public TeamInfoReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamInfoResp")]
  public partial class TeamInfoResp : global::ProtoBuf.IExtensible
  {
    public TeamInfoResp() {}
    
    private readonly global::System.Collections.Generic.List<team.LineupProtoData> _lineupList = new global::System.Collections.Generic.List<team.LineupProtoData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"lineupList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.LineupProtoData> lineupList
    {
      get { return _lineupList; }
    }
  
    private readonly global::System.Collections.Generic.List<team.TeamProtoData> _teamList = new global::System.Collections.Generic.List<team.TeamProtoData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"teamList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.TeamProtoData> teamList
    {
      get { return _teamList; }
    }
  

    private int _bringUpPointPurcasedTimes = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bringUpPointPurcasedTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bringUpPointPurcasedTimes
    {
      get { return _bringUpPointPurcasedTimes; }
      set { _bringUpPointPurcasedTimes = value; }
    }
    private int _currTeamNo;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"currTeamNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int currTeamNo
    {
      get { return _currTeamNo; }
      set { _currTeamNo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupUpgradeReq")]
  public partial class LineupUpgradeReq : global::ProtoBuf.IExtensible
  {
    public LineupUpgradeReq() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupUpgradeResp")]
  public partial class LineupUpgradeResp : global::ProtoBuf.IExtensible
  {
    public LineupUpgradeResp() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }
    private int _lv;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupAddResp")]
  public partial class LineupAddResp : global::ProtoBuf.IExtensible
  {
    public LineupAddResp() {}
    
    private readonly global::System.Collections.Generic.List<team.LineupProtoData> _newLineupList = new global::System.Collections.Generic.List<team.LineupProtoData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"newLineupList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.LineupProtoData> newLineupList
    {
      get { return _newLineupList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamChangeReq")]
  public partial class TeamChangeReq : global::ProtoBuf.IExtensible
  {
    public TeamChangeReq() {}
    
    private team.TeamProtoData _team;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public team.TeamProtoData team
    {
      get { return _team; }
      set { _team = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamChangeResp")]
  public partial class TeamChangeResp : global::ProtoBuf.IExtensible
  {
    public TeamChangeResp() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TeamAddResp")]
  public partial class TeamAddResp : global::ProtoBuf.IExtensible
  {
    public TeamAddResp() {}
    
    private readonly global::System.Collections.Generic.List<team.TeamProtoData> _newTeamList = new global::System.Collections.Generic.List<team.TeamProtoData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"newTeamList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<team.TeamProtoData> newTeamList
    {
      get { return _newTeamList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupPointBuyReq")]
  public partial class LineupPointBuyReq : global::ProtoBuf.IExtensible
  {
    public LineupPointBuyReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupPointBuyResp")]
  public partial class LineupPointBuyResp : global::ProtoBuf.IExtensible
  {
    public LineupPointBuyResp() {}
    

    private int _bringUpPointPurcasedTimes = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bringUpPointPurcasedTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bringUpPointPurcasedTimes
    {
      get { return _bringUpPointPurcasedTimes; }
      set { _bringUpPointPurcasedTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupPointSynReq")]
  public partial class LineupPointSynReq : global::ProtoBuf.IExtensible
  {
    public LineupPointSynReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LineupPointSynResp")]
  public partial class LineupPointSynResp : global::ProtoBuf.IExtensible
  {
    public LineupPointSynResp() {}
    
    private int _point;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int point
    {
      get { return _point; }
      set { _point = value; }
    }
    private int _recoverUpperLimit;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"recoverUpperLimit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int recoverUpperLimit
    {
      get { return _recoverUpperLimit; }
      set { _recoverUpperLimit = value; }
    }

    private long _nextRecoverTime = (long)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"nextRecoverTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long nextRecoverTime
    {
      get { return _nextRecoverTime; }
      set { _nextRecoverTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}