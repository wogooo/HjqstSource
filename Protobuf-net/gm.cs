//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: gm.proto
namespace gm
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendDiamondReq")]
  public partial class SendDiamondReq : global::ProtoBuf.IExtensible
  {
    public SendDiamondReq() {}
    
    private readonly global::System.Collections.Generic.List<int> _roleIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"roleIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> roleIds
    {
      get { return _roleIds; }
    }
  
    private int _num;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private string _gmAccount;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"gmAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gmAccount
    {
      get { return _gmAccount; }
      set { _gmAccount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NoticeInfo")]
  public partial class NoticeInfo : global::ProtoBuf.IExtensible
  {
    public NoticeInfo() {}
    
    private string _notice;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"notice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string notice
    {
      get { return _notice; }
      set { _notice = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendNoticeReq")]
  public partial class SendNoticeReq : global::ProtoBuf.IExtensible
  {
    public SendNoticeReq() {}
    
    private readonly global::System.Collections.Generic.List<gm.NoticeInfo> _noticeInfos = new global::System.Collections.Generic.List<gm.NoticeInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"noticeInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<gm.NoticeInfo> noticeInfos
    {
      get { return _noticeInfos; }
    }
  
    private string _gmAccount;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"gmAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gmAccount
    {
      get { return _gmAccount; }
      set { _gmAccount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"KickRoleReq")]
  public partial class KickRoleReq : global::ProtoBuf.IExtensible
  {
    public KickRoleReq() {}
    
    private readonly global::System.Collections.Generic.List<int> _roleIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"roleIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> roleIds
    {
      get { return _roleIds; }
    }
  
    private string _gmAccount;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"gmAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gmAccount
    {
      get { return _gmAccount; }
      set { _gmAccount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BanRoleReq")]
  public partial class BanRoleReq : global::ProtoBuf.IExtensible
  {
    public BanRoleReq() {}
    
    private readonly global::System.Collections.Generic.List<int> _roleIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"roleIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> roleIds
    {
      get { return _roleIds; }
    }
  
    private int _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private string _gmAccount;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"gmAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gmAccount
    {
      get { return _gmAccount; }
      set { _gmAccount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendItemReq")]
  public partial class SendItemReq : global::ProtoBuf.IExtensible
  {
    public SendItemReq() {}
    
    private readonly global::System.Collections.Generic.List<string> _items = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> items
    {
      get { return _items; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _roleIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"roleIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> roleIds
    {
      get { return _roleIds; }
    }
  
    private int _type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private string _gmAccount;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"gmAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gmAccount
    {
      get { return _gmAccount; }
      set { _gmAccount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendMailReq")]
  public partial class SendMailReq : global::ProtoBuf.IExtensible
  {
    public SendMailReq() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _title;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private string _context;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"context", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string context
    {
      get { return _context; }
      set { _context = value; }
    }

    private string _attachment = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"attachment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string attachment
    {
      get { return _attachment; }
      set { _attachment = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _roleIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"roleIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> roleIds
    {
      get { return _roleIds; }
    }
  
    private int _type;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private long _time = default(long);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long time
    {
      get { return _time; }
      set { _time = value; }
    }
    private string _gmAccount;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"gmAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gmAccount
    {
      get { return _gmAccount; }
      set { _gmAccount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}