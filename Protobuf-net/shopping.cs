//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: shopping.proto
namespace shopping
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PurchaseGoodsReq")]
  public partial class PurchaseGoodsReq : global::ProtoBuf.IExtensible
  {
    public PurchaseGoodsReq() {}
    
    private int _goodsType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"goodsType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsType
    {
      get { return _goodsType; }
      set { _goodsType = value; }
    }
    private int _goodsNo;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private int _costType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"costType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int costType
    {
      get { return _costType; }
      set { _costType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PurchaseGoodsResp")]
  public partial class PurchaseGoodsResp : global::ProtoBuf.IExtensible
  {
    public PurchaseGoodsResp() {}
    

    private int _goodsType = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"goodsType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int goodsType
    {
      get { return _goodsType; }
      set { _goodsType = value; }
    }

    private int _goodsNo = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private int _costType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"costType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int costType
    {
      get { return _costType; }
      set { _costType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawCardDropProto")]
  public partial class DrawCardDropProto : global::ProtoBuf.IExtensible
  {
    public DrawCardDropProto() {}
    
    private int _no;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"no", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int no
    {
      get { return _no; }
      set { _no = value; }
    }

    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }

    private int _instanceId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"instanceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int instanceId
    {
      get { return _instanceId; }
      set { _instanceId = value; }
    }

    private int _type = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }

    private int _num = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PurchaseDrawCardGoodsResp")]
  public partial class PurchaseDrawCardGoodsResp : global::ProtoBuf.IExtensible
  {
    public PurchaseDrawCardGoodsResp() {}
    
    private int _goodsNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private shopping.DrawCardDropProto _specialGoods = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"specialGoods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public shopping.DrawCardDropProto specialGoods
    {
      get { return _specialGoods; }
      set { _specialGoods = value; }
    }
    private readonly global::System.Collections.Generic.List<shopping.DrawCardDropProto> _commonGoods = new global::System.Collections.Generic.List<shopping.DrawCardDropProto>();
    [global::ProtoBuf.ProtoMember(3, Name=@"commonGoods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.DrawCardDropProto> commonGoods
    {
      get { return _commonGoods; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawCardGoodsReq")]
  public partial class DrawCardGoodsReq : global::ProtoBuf.IExtensible
  {
    public DrawCardGoodsReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawCardGoodsProto")]
  public partial class DrawCardGoodsProto : global::ProtoBuf.IExtensible
  {
    public DrawCardGoodsProto() {}
    
    private int _goodsNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private int _remainFreeTimes = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"remainFreeTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int remainFreeTimes
    {
      get { return _remainFreeTimes; }
      set { _remainFreeTimes = value; }
    }

    private long _freeDrawCoolingOverTime = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"freeDrawCoolingOverTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long freeDrawCoolingOverTime
    {
      get { return _freeDrawCoolingOverTime; }
      set { _freeDrawCoolingOverTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawCardGoodsResp")]
  public partial class DrawCardGoodsResp : global::ProtoBuf.IExtensible
  {
    public DrawCardGoodsResp() {}
    
    private readonly global::System.Collections.Generic.List<shopping.DrawCardGoodsProto> _goods = new global::System.Collections.Generic.List<shopping.DrawCardGoodsProto>();
    [global::ProtoBuf.ProtoMember(1, Name=@"goods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.DrawCardGoodsProto> goods
    {
      get { return _goods; }
    }
  

    private int _purchaseDrawCredit = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"purchaseDrawCredit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int purchaseDrawCredit
    {
      get { return _purchaseDrawCredit; }
      set { _purchaseDrawCredit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawCardGoodsUpdateResp")]
  public partial class DrawCardGoodsUpdateResp : global::ProtoBuf.IExtensible
  {
    public DrawCardGoodsUpdateResp() {}
    
    private shopping.DrawCardGoodsProto _updateGoods;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"updateGoods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public shopping.DrawCardGoodsProto updateGoods
    {
      get { return _updateGoods; }
      set { _updateGoods = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LimitGoodsReq")]
  public partial class LimitGoodsReq : global::ProtoBuf.IExtensible
  {
    public LimitGoodsReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LimitGoodsProto")]
  public partial class LimitGoodsProto : global::ProtoBuf.IExtensible
  {
    public LimitGoodsProto() {}
    
    private int _goodsNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private int _remianPurchaseTimes = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"remianPurchaseTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int remianPurchaseTimes
    {
      get { return _remianPurchaseTimes; }
      set { _remianPurchaseTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LimitGoodsResp")]
  public partial class LimitGoodsResp : global::ProtoBuf.IExtensible
  {
    public LimitGoodsResp() {}
    
    private readonly global::System.Collections.Generic.List<shopping.LimitGoodsProto> _goods = new global::System.Collections.Generic.List<shopping.LimitGoodsProto>();
    [global::ProtoBuf.ProtoMember(1, Name=@"goods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.LimitGoodsProto> goods
    {
      get { return _goods; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LimitGoodsUpdateResp")]
  public partial class LimitGoodsUpdateResp : global::ProtoBuf.IExtensible
  {
    public LimitGoodsUpdateResp() {}
    
    private readonly global::System.Collections.Generic.List<shopping.LimitGoodsProto> _addGoods = new global::System.Collections.Generic.List<shopping.LimitGoodsProto>();
    [global::ProtoBuf.ProtoMember(1, Name=@"addGoods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.LimitGoodsProto> addGoods
    {
      get { return _addGoods; }
    }
  

    private int _delGoods = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"delGoods", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int delGoods
    {
      get { return _delGoods; }
      set { _delGoods = value; }
    }

    private shopping.LimitGoodsProto _updateGoods = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"updateGoods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public shopping.LimitGoodsProto updateGoods
    {
      get { return _updateGoods; }
      set { _updateGoods = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OtherGoodsReq")]
  public partial class OtherGoodsReq : global::ProtoBuf.IExtensible
  {
    public OtherGoodsReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OtherGoodsProto")]
  public partial class OtherGoodsProto : global::ProtoBuf.IExtensible
  {
    public OtherGoodsProto() {}
    
    private int _goodsNo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private int _remianPurchaseTimes = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"remianPurchaseTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int remianPurchaseTimes
    {
      get { return _remianPurchaseTimes; }
      set { _remianPurchaseTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OtherGoodsResp")]
  public partial class OtherGoodsResp : global::ProtoBuf.IExtensible
  {
    public OtherGoodsResp() {}
    
    private readonly global::System.Collections.Generic.List<shopping.OtherGoodsProto> _goods = new global::System.Collections.Generic.List<shopping.OtherGoodsProto>();
    [global::ProtoBuf.ProtoMember(1, Name=@"goods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.OtherGoodsProto> goods
    {
      get { return _goods; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OtherGoodsUpdateResp")]
  public partial class OtherGoodsUpdateResp : global::ProtoBuf.IExtensible
  {
    public OtherGoodsUpdateResp() {}
    

    private shopping.OtherGoodsProto _updateGoods = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"updateGoods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public shopping.OtherGoodsProto updateGoods
    {
      get { return _updateGoods; }
      set { _updateGoods = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BlackMarketReq")]
  public partial class BlackMarketReq : global::ProtoBuf.IExtensible
  {
    public BlackMarketReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BlackMarketGoodsProto")]
  public partial class BlackMarketGoodsProto : global::ProtoBuf.IExtensible
  {
    public BlackMarketGoodsProto() {}
    
    private int _marketId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"marketId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int marketId
    {
      get { return _marketId; }
      set { _marketId = value; }
    }

    private int _goodsNo = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }

    private int _remainBuyTimes = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"remainBuyTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int remainBuyTimes
    {
      get { return _remainBuyTimes; }
      set { _remainBuyTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BlackMarketTabProto")]
  public partial class BlackMarketTabProto : global::ProtoBuf.IExtensible
  {
    public BlackMarketTabProto() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<shopping.BlackMarketGoodsProto> _goods = new global::System.Collections.Generic.List<shopping.BlackMarketGoodsProto>();
    [global::ProtoBuf.ProtoMember(2, Name=@"goods", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.BlackMarketGoodsProto> goods
    {
      get { return _goods; }
    }
  
    private long _nextRefreshTime;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"nextRefreshTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long nextRefreshTime
    {
      get { return _nextRefreshTime; }
      set { _nextRefreshTime = value; }
    }
    private int _dailyRefreshTimes;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"dailyRefreshTimes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dailyRefreshTimes
    {
      get { return _dailyRefreshTimes; }
      set { _dailyRefreshTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BlackMarketResp")]
  public partial class BlackMarketResp : global::ProtoBuf.IExtensible
  {
    public BlackMarketResp() {}
    
    private readonly global::System.Collections.Generic.List<shopping.BlackMarketTabProto> _tabs = new global::System.Collections.Generic.List<shopping.BlackMarketTabProto>();
    [global::ProtoBuf.ProtoMember(1, Name=@"tabs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<shopping.BlackMarketTabProto> tabs
    {
      get { return _tabs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BlackMarketUpdateResp")]
  public partial class BlackMarketUpdateResp : global::ProtoBuf.IExtensible
  {
    public BlackMarketUpdateResp() {}
    
    private shopping.BlackMarketTabProto _tab;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public shopping.BlackMarketTabProto tab
    {
      get { return _tab; }
      set { _tab = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PurchaseBlackGoodsReq")]
  public partial class PurchaseBlackGoodsReq : global::ProtoBuf.IExtensible
  {
    public PurchaseBlackGoodsReq() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _marketId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"marketId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int marketId
    {
      get { return _marketId; }
      set { _marketId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PurchaseBlackGoodsResp")]
  public partial class PurchaseBlackGoodsResp : global::ProtoBuf.IExtensible
  {
    public PurchaseBlackGoodsResp() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DiamondGoodsResp")]
  public partial class DiamondGoodsResp : global::ProtoBuf.IExtensible
  {
    public DiamondGoodsResp() {}
    
    private readonly global::System.Collections.Generic.List<int> _firstChargeGoodsList = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"firstChargeGoodsList", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> firstChargeGoodsList
    {
      get { return _firstChargeGoodsList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AppStoreVerifyReq")]
  public partial class AppStoreVerifyReq : global::ProtoBuf.IExtensible
  {
    public AppStoreVerifyReq() {}
    
    private string _orderId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"orderId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string orderId
    {
      get { return _orderId; }
      set { _orderId = value; }
    }
    private string _info;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string info
    {
      get { return _info; }
      set { _info = value; }
    }
    private int _goodsNo;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"goodsNo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int goodsNo
    {
      get { return _goodsNo; }
      set { _goodsNo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CheckBalanceMidasReq")]
  public partial class CheckBalanceMidasReq : global::ProtoBuf.IExtensible
  {
    public CheckBalanceMidasReq() {}
    
    private string _sessionId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"sessionId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sessionId
    {
      get { return _sessionId; }
      set { _sessionId = value; }
    }
    private string _sessionType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"sessionType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sessionType
    {
      get { return _sessionType; }
      set { _sessionType = value; }
    }
    private string _openId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"openId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string openId
    {
      get { return _openId; }
      set { _openId = value; }
    }
    private string _openKey;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"openKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string openKey
    {
      get { return _openKey; }
      set { _openKey = value; }
    }
    private string _appId;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"appId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string appId
    {
      get { return _appId; }
      set { _appId = value; }
    }
    private string _pf;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"pf", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string pf
    {
      get { return _pf; }
      set { _pf = value; }
    }
    private string _pfKey;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"pfKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string pfKey
    {
      get { return _pfKey; }
      set { _pfKey = value; }
    }
    private string _zoneid;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"zoneid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string zoneid
    {
      get { return _zoneid; }
      set { _zoneid = value; }
    }
    private bool _needContinue;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"needContinue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool needContinue
    {
      get { return _needContinue; }
      set { _needContinue = value; }
    }
    private string _partnerName;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"partnerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string partnerName
    {
      get { return _partnerName; }
      set { _partnerName = value; }
    }
    private int _partnerId;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"partnerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int partnerId
    {
      get { return _partnerId; }
      set { _partnerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GoldHandInfoResp")]
  public partial class GoldHandInfoResp : global::ProtoBuf.IExtensible
  {
    public GoldHandInfoResp() {}
    
    private readonly global::System.Collections.Generic.List<string> _infos = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"infos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> infos
    {
      get { return _infos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}