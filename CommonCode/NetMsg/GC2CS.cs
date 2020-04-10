// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GC2CS.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GC2CS {

  /// <summary>Holder for reflection information generated from GC2CS.proto</summary>
  public static partial class GC2CSReflection {

    #region Descriptor
    /// <summary>File descriptor for GC2CS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GC2CSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtHQzJDUy5wcm90bxIFR0MyQ1MaEFJlc3VsdENvZGUucHJvdG8iNQoTcmVx",
            "RW50ZXJHYW1lU2VydmljZRIPCgdhY2NvdW50GAEgASgJEg0KBXRva2VuGAIg",
            "ASgJIkMKFHJlc3BFbnRlckdhbWVTZXJ2aWNlEhgKA2VychgBIAEoDjILLlJl",
            "c3VsdENvZGUSEQoJaXNTdWNjZXNzGAIgASgIIg0KC3JlcUhlcm9MaXN0IjEK",
            "DHJlc3BIZXJvTGlzdBIhCghoZXJvTGlzdBgBIAMoCzIPLkdDMkNTLkhlcm9J",
            "bmZvIiEKD3JlcUFkZEhlcm9MZXZlbBIOCgZoZXJvSWQYASABKAUiLAoQcmVz",
            "cEFkZEhlcm9MZXZlbBIYCgNlcnIYASABKA4yCy5SZXN1bHRDb2RlIhcKFXJl",
            "cU5vdGlmeVVwZGF0ZUhlcm9lcyI/ChZyZXNwTm90aWZ5VXBkYXRlSGVyb2Vz",
            "EiUKDGhlcm9JbmZvTGlzdBgBIAMoCzIPLkdDMkNTLkhlcm9JbmZvIjcKCEhl",
            "cm9JbmZvEgoKAmlkGAEgASgFEhAKCGNvbmZpZ0lkGAIgASgFEg0KBWxldmVs",
            "GAMgASgFKpIBCgVNc2dJZBIJCgVGaXJzdBAAEgoKBUJlZ2luEMhlEhsKFkdD",
            "MkNTX0VudGVyR2FtZVNlcnZpY2UQyWUSEwoOR0MyQ1NfSGVyb0xpc3QQymUS",
            "FwoSR0MyQ1NfQWRkSGVyb0xldmVsEMtlEh0KGEdDMkNTX05vdGlmeVVwZGF0",
            "ZUhlcm9lcxDMZRIICgNFbmQQrGZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::ResultCodeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GC2CS.MsgId), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.reqEnterGameService), global::GC2CS.reqEnterGameService.Parser, new[]{ "Account", "Token" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.respEnterGameService), global::GC2CS.respEnterGameService.Parser, new[]{ "Err", "IsSuccess" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.reqHeroList), global::GC2CS.reqHeroList.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.respHeroList), global::GC2CS.respHeroList.Parser, new[]{ "HeroList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.reqAddHeroLevel), global::GC2CS.reqAddHeroLevel.Parser, new[]{ "HeroId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.respAddHeroLevel), global::GC2CS.respAddHeroLevel.Parser, new[]{ "Err" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.reqNotifyUpdateHeroes), global::GC2CS.reqNotifyUpdateHeroes.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.respNotifyUpdateHeroes), global::GC2CS.respNotifyUpdateHeroes.Parser, new[]{ "HeroInfoList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GC2CS.HeroInfo), global::GC2CS.HeroInfo.Parser, new[]{ "Id", "ConfigId", "Level" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MsgId {
    [pbr::OriginalName("First")] First = 0,
    [pbr::OriginalName("Begin")] Begin = 13000,
    /// <summary>
    /// 登录成功后 需要请求进入真正的游戏服务 也就是通过 发送到 GS 转发到 CS 验证后即可进入真正的游戏服务
    /// </summary>
    [pbr::OriginalName("GC2CS_EnterGameService")] Gc2CsEnterGameService = 13001,
    [pbr::OriginalName("GC2CS_HeroList")] Gc2CsHeroList = 13002,
    [pbr::OriginalName("GC2CS_AddHeroLevel")] Gc2CsAddHeroLevel = 13003,
    [pbr::OriginalName("GC2CS_NotifyUpdateHeroes")] Gc2CsNotifyUpdateHeroes = 13004,
    [pbr::OriginalName("End")] End = 13100,
  }

  #endregion

  #region Messages
  public sealed partial class reqEnterGameService : pb::IMessage<reqEnterGameService> {
    private static readonly pb::MessageParser<reqEnterGameService> _parser = new pb::MessageParser<reqEnterGameService>(() => new reqEnterGameService());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<reqEnterGameService> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqEnterGameService() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqEnterGameService(reqEnterGameService other) : this() {
      account_ = other.account_;
      token_ = other.token_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqEnterGameService Clone() {
      return new reqEnterGameService(this);
    }

    /// <summary>Field number for the "account" field.</summary>
    public const int AccountFieldNumber = 1;
    private string account_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 2;
    private string token_ = "";
    /// <summary>
    /// 之后验证再用
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as reqEnterGameService);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(reqEnterGameService other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Account != other.Account) return false;
      if (Token != other.Token) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Account.Length != 0) hash ^= Account.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Account.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Account);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Token);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(reqEnterGameService other) {
      if (other == null) {
        return;
      }
      if (other.Account.Length != 0) {
        Account = other.Account;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Account = input.ReadString();
            break;
          }
          case 18: {
            Token = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class respEnterGameService : pb::IMessage<respEnterGameService> {
    private static readonly pb::MessageParser<respEnterGameService> _parser = new pb::MessageParser<respEnterGameService>(() => new respEnterGameService());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<respEnterGameService> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respEnterGameService() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respEnterGameService(respEnterGameService other) : this() {
      err_ = other.err_;
      isSuccess_ = other.isSuccess_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respEnterGameService Clone() {
      return new respEnterGameService(this);
    }

    /// <summary>Field number for the "err" field.</summary>
    public const int ErrFieldNumber = 1;
    private global::ResultCode err_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ResultCode Err {
      get { return err_; }
      set {
        err_ = value;
      }
    }

    /// <summary>Field number for the "isSuccess" field.</summary>
    public const int IsSuccessFieldNumber = 2;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as respEnterGameService);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(respEnterGameService other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Err != other.Err) return false;
      if (IsSuccess != other.IsSuccess) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Err != 0) hash ^= Err.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Err != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Err);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsSuccess);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Err != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Err);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(respEnterGameService other) {
      if (other == null) {
        return;
      }
      if (other.Err != 0) {
        Err = other.Err;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            err_ = (global::ResultCode) input.ReadEnum();
            break;
          }
          case 16: {
            IsSuccess = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class reqHeroList : pb::IMessage<reqHeroList> {
    private static readonly pb::MessageParser<reqHeroList> _parser = new pb::MessageParser<reqHeroList>(() => new reqHeroList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<reqHeroList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqHeroList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqHeroList(reqHeroList other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqHeroList Clone() {
      return new reqHeroList(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as reqHeroList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(reqHeroList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(reqHeroList other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class respHeroList : pb::IMessage<respHeroList> {
    private static readonly pb::MessageParser<respHeroList> _parser = new pb::MessageParser<respHeroList>(() => new respHeroList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<respHeroList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respHeroList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respHeroList(respHeroList other) : this() {
      heroList_ = other.heroList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respHeroList Clone() {
      return new respHeroList(this);
    }

    /// <summary>Field number for the "heroList" field.</summary>
    public const int HeroListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GC2CS.HeroInfo> _repeated_heroList_codec
        = pb::FieldCodec.ForMessage(10, global::GC2CS.HeroInfo.Parser);
    private readonly pbc::RepeatedField<global::GC2CS.HeroInfo> heroList_ = new pbc::RepeatedField<global::GC2CS.HeroInfo>();
    /// <summary>
    /// heroList
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GC2CS.HeroInfo> HeroList {
      get { return heroList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as respHeroList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(respHeroList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!heroList_.Equals(other.heroList_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= heroList_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      heroList_.WriteTo(output, _repeated_heroList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += heroList_.CalculateSize(_repeated_heroList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(respHeroList other) {
      if (other == null) {
        return;
      }
      heroList_.Add(other.heroList_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            heroList_.AddEntriesFrom(input, _repeated_heroList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class reqAddHeroLevel : pb::IMessage<reqAddHeroLevel> {
    private static readonly pb::MessageParser<reqAddHeroLevel> _parser = new pb::MessageParser<reqAddHeroLevel>(() => new reqAddHeroLevel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<reqAddHeroLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqAddHeroLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqAddHeroLevel(reqAddHeroLevel other) : this() {
      heroId_ = other.heroId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqAddHeroLevel Clone() {
      return new reqAddHeroLevel(this);
    }

    /// <summary>Field number for the "heroId" field.</summary>
    public const int HeroIdFieldNumber = 1;
    private int heroId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HeroId {
      get { return heroId_; }
      set {
        heroId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as reqAddHeroLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(reqAddHeroLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HeroId != other.HeroId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HeroId != 0) hash ^= HeroId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HeroId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(HeroId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HeroId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HeroId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(reqAddHeroLevel other) {
      if (other == null) {
        return;
      }
      if (other.HeroId != 0) {
        HeroId = other.HeroId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            HeroId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class respAddHeroLevel : pb::IMessage<respAddHeroLevel> {
    private static readonly pb::MessageParser<respAddHeroLevel> _parser = new pb::MessageParser<respAddHeroLevel>(() => new respAddHeroLevel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<respAddHeroLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respAddHeroLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respAddHeroLevel(respAddHeroLevel other) : this() {
      err_ = other.err_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respAddHeroLevel Clone() {
      return new respAddHeroLevel(this);
    }

    /// <summary>Field number for the "err" field.</summary>
    public const int ErrFieldNumber = 1;
    private global::ResultCode err_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ResultCode Err {
      get { return err_; }
      set {
        err_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as respAddHeroLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(respAddHeroLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Err != other.Err) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Err != 0) hash ^= Err.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Err != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Err);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Err != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Err);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(respAddHeroLevel other) {
      if (other == null) {
        return;
      }
      if (other.Err != 0) {
        Err = other.Err;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            err_ = (global::ResultCode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 目前只要到了下行
  /// </summary>
  public sealed partial class reqNotifyUpdateHeroes : pb::IMessage<reqNotifyUpdateHeroes> {
    private static readonly pb::MessageParser<reqNotifyUpdateHeroes> _parser = new pb::MessageParser<reqNotifyUpdateHeroes>(() => new reqNotifyUpdateHeroes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<reqNotifyUpdateHeroes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqNotifyUpdateHeroes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqNotifyUpdateHeroes(reqNotifyUpdateHeroes other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public reqNotifyUpdateHeroes Clone() {
      return new reqNotifyUpdateHeroes(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as reqNotifyUpdateHeroes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(reqNotifyUpdateHeroes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(reqNotifyUpdateHeroes other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class respNotifyUpdateHeroes : pb::IMessage<respNotifyUpdateHeroes> {
    private static readonly pb::MessageParser<respNotifyUpdateHeroes> _parser = new pb::MessageParser<respNotifyUpdateHeroes>(() => new respNotifyUpdateHeroes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<respNotifyUpdateHeroes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respNotifyUpdateHeroes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respNotifyUpdateHeroes(respNotifyUpdateHeroes other) : this() {
      heroInfoList_ = other.heroInfoList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public respNotifyUpdateHeroes Clone() {
      return new respNotifyUpdateHeroes(this);
    }

    /// <summary>Field number for the "heroInfoList" field.</summary>
    public const int HeroInfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GC2CS.HeroInfo> _repeated_heroInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::GC2CS.HeroInfo.Parser);
    private readonly pbc::RepeatedField<global::GC2CS.HeroInfo> heroInfoList_ = new pbc::RepeatedField<global::GC2CS.HeroInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GC2CS.HeroInfo> HeroInfoList {
      get { return heroInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as respNotifyUpdateHeroes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(respNotifyUpdateHeroes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!heroInfoList_.Equals(other.heroInfoList_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= heroInfoList_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      heroInfoList_.WriteTo(output, _repeated_heroInfoList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += heroInfoList_.CalculateSize(_repeated_heroInfoList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(respNotifyUpdateHeroes other) {
      if (other == null) {
        return;
      }
      heroInfoList_.Add(other.heroInfoList_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            heroInfoList_.AddEntriesFrom(input, _repeated_heroInfoList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HeroInfo : pb::IMessage<HeroInfo> {
    private static readonly pb::MessageParser<HeroInfo> _parser = new pb::MessageParser<HeroInfo>(() => new HeroInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HeroInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GC2CS.GC2CSReflection.Descriptor.MessageTypes[8]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HeroInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HeroInfo(HeroInfo other) : this() {
      id_ = other.id_;
      configId_ = other.configId_;
      level_ = other.level_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HeroInfo Clone() {
      return new HeroInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "configId" field.</summary>
    public const int ConfigIdFieldNumber = 2;
    private int configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HeroInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HeroInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ConfigId != other.ConfigId) return false;
      if (Level != other.Level) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ConfigId);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Level);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ConfigId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HeroInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadInt32();
            break;
          }
          case 24: {
            Level = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
