// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: message_game_login.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MO.Protocol {

  /// <summary>Holder for reflection information generated from message_game_login.proto</summary>
  public static partial class MessageGameLoginReflection {

    #region Descriptor
    /// <summary>File descriptor for message_game_login.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageGameLoginReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhtZXNzYWdlX2dhbWVfbG9naW4ucHJvdG8SC01PLlByb3RvY29sIjIKCEMy",
            "U18xMDAxEhIKCk1vYmlsZVR5cGUYASABKAUSEgoKQ3VyVmVyc2lvbhgCIAEo",
            "CSKNAQoIUzJDXzEwMDESFAoMVmVyc2lvblRvdGFsGAEgASgJEhQKDFZlcnNp",
            "b25QYXRjaBgCIAEoCRIWCg5Jc0FwcFN0b3JlUGFzcxgDIAEoCBIOCgZGaXJV",
            "cmwYBCABKAkSDgoGQXBrVXJsGAUgASgJEg4KBkRvbmFtZRgGIAEoCRINCgVG",
            "aXhJcBgHIAEoCSIwCghDMlNfMTAwMxISCgpNb2JpbGVUeXBlGAEgASgFEhAK",
            "CERldmljZUlkGAIgASgJIo8BCghTMkNfMTAwMxIOCgZVc2VySWQYASABKAMS",
            "DQoFVG9rZW4YAiABKAkSDwoHTG9naW5JUBgDIAEoCRIRCglMb2dpblBvcnQY",
            "BCABKAUSDgoGR2F0ZUlQGAUgASgJEhAKCEdhdGVQb3J0GAYgASgFEg0KBUFw",
            "aUlQGAcgASgJEg8KB0FwaVBvcnQYCCABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MO.Protocol.C2S_1001), global::MO.Protocol.C2S_1001.Parser, new[]{ "MobileType", "CurVersion" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MO.Protocol.S2C_1001), global::MO.Protocol.S2C_1001.Parser, new[]{ "VersionTotal", "VersionPatch", "IsAppStorePass", "FirUrl", "ApkUrl", "Doname", "FixIp" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MO.Protocol.C2S_1003), global::MO.Protocol.C2S_1003.Parser, new[]{ "MobileType", "DeviceId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MO.Protocol.S2C_1003), global::MO.Protocol.S2C_1003.Parser, new[]{ "UserId", "Token", "LoginIP", "LoginPort", "GateIP", "GatePort", "ApiIP", "ApiPort" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///��ȡ������Ϣ
  /// </summary>
  public sealed partial class C2S_1001 : pb::IMessage<C2S_1001> {
    private static readonly pb::MessageParser<C2S_1001> _parser = new pb::MessageParser<C2S_1001>(() => new C2S_1001());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2S_1001> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MO.Protocol.MessageGameLoginReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_1001() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_1001(C2S_1001 other) : this() {
      mobileType_ = other.mobileType_;
      curVersion_ = other.curVersion_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_1001 Clone() {
      return new C2S_1001(this);
    }

    /// <summary>Field number for the "MobileType" field.</summary>
    public const int MobileTypeFieldNumber = 1;
    private int mobileType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MobileType {
      get { return mobileType_; }
      set {
        mobileType_ = value;
      }
    }

    /// <summary>Field number for the "CurVersion" field.</summary>
    public const int CurVersionFieldNumber = 2;
    private string curVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurVersion {
      get { return curVersion_; }
      set {
        curVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C2S_1001);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C2S_1001 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MobileType != other.MobileType) return false;
      if (CurVersion != other.CurVersion) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MobileType != 0) hash ^= MobileType.GetHashCode();
      if (CurVersion.Length != 0) hash ^= CurVersion.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MobileType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MobileType);
      }
      if (CurVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CurVersion);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MobileType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MobileType);
      }
      if (CurVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurVersion);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C2S_1001 other) {
      if (other == null) {
        return;
      }
      if (other.MobileType != 0) {
        MobileType = other.MobileType;
      }
      if (other.CurVersion.Length != 0) {
        CurVersion = other.CurVersion;
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
            MobileType = input.ReadInt32();
            break;
          }
          case 18: {
            CurVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S2C_1001 : pb::IMessage<S2C_1001> {
    private static readonly pb::MessageParser<S2C_1001> _parser = new pb::MessageParser<S2C_1001>(() => new S2C_1001());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C_1001> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MO.Protocol.MessageGameLoginReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_1001() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_1001(S2C_1001 other) : this() {
      versionTotal_ = other.versionTotal_;
      versionPatch_ = other.versionPatch_;
      isAppStorePass_ = other.isAppStorePass_;
      firUrl_ = other.firUrl_;
      apkUrl_ = other.apkUrl_;
      doname_ = other.doname_;
      fixIp_ = other.fixIp_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_1001 Clone() {
      return new S2C_1001(this);
    }

    /// <summary>Field number for the "VersionTotal" field.</summary>
    public const int VersionTotalFieldNumber = 1;
    private string versionTotal_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VersionTotal {
      get { return versionTotal_; }
      set {
        versionTotal_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "VersionPatch" field.</summary>
    public const int VersionPatchFieldNumber = 2;
    private string versionPatch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VersionPatch {
      get { return versionPatch_; }
      set {
        versionPatch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "IsAppStorePass" field.</summary>
    public const int IsAppStorePassFieldNumber = 3;
    private bool isAppStorePass_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsAppStorePass {
      get { return isAppStorePass_; }
      set {
        isAppStorePass_ = value;
      }
    }

    /// <summary>Field number for the "FirUrl" field.</summary>
    public const int FirUrlFieldNumber = 4;
    private string firUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirUrl {
      get { return firUrl_; }
      set {
        firUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ApkUrl" field.</summary>
    public const int ApkUrlFieldNumber = 5;
    private string apkUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApkUrl {
      get { return apkUrl_; }
      set {
        apkUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Doname" field.</summary>
    public const int DonameFieldNumber = 6;
    private string doname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Doname {
      get { return doname_; }
      set {
        doname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FixIp" field.</summary>
    public const int FixIpFieldNumber = 7;
    private string fixIp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FixIp {
      get { return fixIp_; }
      set {
        fixIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S2C_1001);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S2C_1001 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VersionTotal != other.VersionTotal) return false;
      if (VersionPatch != other.VersionPatch) return false;
      if (IsAppStorePass != other.IsAppStorePass) return false;
      if (FirUrl != other.FirUrl) return false;
      if (ApkUrl != other.ApkUrl) return false;
      if (Doname != other.Doname) return false;
      if (FixIp != other.FixIp) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VersionTotal.Length != 0) hash ^= VersionTotal.GetHashCode();
      if (VersionPatch.Length != 0) hash ^= VersionPatch.GetHashCode();
      if (IsAppStorePass != false) hash ^= IsAppStorePass.GetHashCode();
      if (FirUrl.Length != 0) hash ^= FirUrl.GetHashCode();
      if (ApkUrl.Length != 0) hash ^= ApkUrl.GetHashCode();
      if (Doname.Length != 0) hash ^= Doname.GetHashCode();
      if (FixIp.Length != 0) hash ^= FixIp.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (VersionTotal.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VersionTotal);
      }
      if (VersionPatch.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(VersionPatch);
      }
      if (IsAppStorePass != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAppStorePass);
      }
      if (FirUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(FirUrl);
      }
      if (ApkUrl.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ApkUrl);
      }
      if (Doname.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Doname);
      }
      if (FixIp.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(FixIp);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VersionTotal.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VersionTotal);
      }
      if (VersionPatch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VersionPatch);
      }
      if (IsAppStorePass != false) {
        size += 1 + 1;
      }
      if (FirUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirUrl);
      }
      if (ApkUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApkUrl);
      }
      if (Doname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Doname);
      }
      if (FixIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FixIp);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S2C_1001 other) {
      if (other == null) {
        return;
      }
      if (other.VersionTotal.Length != 0) {
        VersionTotal = other.VersionTotal;
      }
      if (other.VersionPatch.Length != 0) {
        VersionPatch = other.VersionPatch;
      }
      if (other.IsAppStorePass != false) {
        IsAppStorePass = other.IsAppStorePass;
      }
      if (other.FirUrl.Length != 0) {
        FirUrl = other.FirUrl;
      }
      if (other.ApkUrl.Length != 0) {
        ApkUrl = other.ApkUrl;
      }
      if (other.Doname.Length != 0) {
        Doname = other.Doname;
      }
      if (other.FixIp.Length != 0) {
        FixIp = other.FixIp;
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
            VersionTotal = input.ReadString();
            break;
          }
          case 18: {
            VersionPatch = input.ReadString();
            break;
          }
          case 24: {
            IsAppStorePass = input.ReadBool();
            break;
          }
          case 34: {
            FirUrl = input.ReadString();
            break;
          }
          case 42: {
            ApkUrl = input.ReadString();
            break;
          }
          case 50: {
            Doname = input.ReadString();
            break;
          }
          case 58: {
            FixIp = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///�ο͵�¼
  /// </summary>
  public sealed partial class C2S_1003 : pb::IMessage<C2S_1003> {
    private static readonly pb::MessageParser<C2S_1003> _parser = new pb::MessageParser<C2S_1003>(() => new C2S_1003());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2S_1003> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MO.Protocol.MessageGameLoginReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_1003() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_1003(C2S_1003 other) : this() {
      mobileType_ = other.mobileType_;
      deviceId_ = other.deviceId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_1003 Clone() {
      return new C2S_1003(this);
    }

    /// <summary>Field number for the "MobileType" field.</summary>
    public const int MobileTypeFieldNumber = 1;
    private int mobileType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MobileType {
      get { return mobileType_; }
      set {
        mobileType_ = value;
      }
    }

    /// <summary>Field number for the "DeviceId" field.</summary>
    public const int DeviceIdFieldNumber = 2;
    private string deviceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C2S_1003);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C2S_1003 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MobileType != other.MobileType) return false;
      if (DeviceId != other.DeviceId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MobileType != 0) hash ^= MobileType.GetHashCode();
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MobileType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MobileType);
      }
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MobileType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MobileType);
      }
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C2S_1003 other) {
      if (other == null) {
        return;
      }
      if (other.MobileType != 0) {
        MobileType = other.MobileType;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
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
            MobileType = input.ReadInt32();
            break;
          }
          case 18: {
            DeviceId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S2C_1003 : pb::IMessage<S2C_1003> {
    private static readonly pb::MessageParser<S2C_1003> _parser = new pb::MessageParser<S2C_1003>(() => new S2C_1003());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C_1003> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MO.Protocol.MessageGameLoginReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_1003() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_1003(S2C_1003 other) : this() {
      userId_ = other.userId_;
      token_ = other.token_;
      loginIP_ = other.loginIP_;
      loginPort_ = other.loginPort_;
      gateIP_ = other.gateIP_;
      gatePort_ = other.gatePort_;
      apiIP_ = other.apiIP_;
      apiPort_ = other.apiPort_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_1003 Clone() {
      return new S2C_1003(this);
    }

    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 1;
    private long userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "Token" field.</summary>
    public const int TokenFieldNumber = 2;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LoginIP" field.</summary>
    public const int LoginIPFieldNumber = 3;
    private string loginIP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LoginIP {
      get { return loginIP_; }
      set {
        loginIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LoginPort" field.</summary>
    public const int LoginPortFieldNumber = 4;
    private int loginPort_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LoginPort {
      get { return loginPort_; }
      set {
        loginPort_ = value;
      }
    }

    /// <summary>Field number for the "GateIP" field.</summary>
    public const int GateIPFieldNumber = 5;
    private string gateIP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GateIP {
      get { return gateIP_; }
      set {
        gateIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "GatePort" field.</summary>
    public const int GatePortFieldNumber = 6;
    private int gatePort_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GatePort {
      get { return gatePort_; }
      set {
        gatePort_ = value;
      }
    }

    /// <summary>Field number for the "ApiIP" field.</summary>
    public const int ApiIPFieldNumber = 7;
    private string apiIP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApiIP {
      get { return apiIP_; }
      set {
        apiIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ApiPort" field.</summary>
    public const int ApiPortFieldNumber = 8;
    private int apiPort_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ApiPort {
      get { return apiPort_; }
      set {
        apiPort_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S2C_1003);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S2C_1003 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (Token != other.Token) return false;
      if (LoginIP != other.LoginIP) return false;
      if (LoginPort != other.LoginPort) return false;
      if (GateIP != other.GateIP) return false;
      if (GatePort != other.GatePort) return false;
      if (ApiIP != other.ApiIP) return false;
      if (ApiPort != other.ApiPort) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (LoginIP.Length != 0) hash ^= LoginIP.GetHashCode();
      if (LoginPort != 0) hash ^= LoginPort.GetHashCode();
      if (GateIP.Length != 0) hash ^= GateIP.GetHashCode();
      if (GatePort != 0) hash ^= GatePort.GetHashCode();
      if (ApiIP.Length != 0) hash ^= ApiIP.GetHashCode();
      if (ApiPort != 0) hash ^= ApiPort.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Token);
      }
      if (LoginIP.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LoginIP);
      }
      if (LoginPort != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(LoginPort);
      }
      if (GateIP.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(GateIP);
      }
      if (GatePort != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(GatePort);
      }
      if (ApiIP.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ApiIP);
      }
      if (ApiPort != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(ApiPort);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (LoginIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LoginIP);
      }
      if (LoginPort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LoginPort);
      }
      if (GateIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GateIP);
      }
      if (GatePort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GatePort);
      }
      if (ApiIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiIP);
      }
      if (ApiPort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ApiPort);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S2C_1003 other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.LoginIP.Length != 0) {
        LoginIP = other.LoginIP;
      }
      if (other.LoginPort != 0) {
        LoginPort = other.LoginPort;
      }
      if (other.GateIP.Length != 0) {
        GateIP = other.GateIP;
      }
      if (other.GatePort != 0) {
        GatePort = other.GatePort;
      }
      if (other.ApiIP.Length != 0) {
        ApiIP = other.ApiIP;
      }
      if (other.ApiPort != 0) {
        ApiPort = other.ApiPort;
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
            UserId = input.ReadInt64();
            break;
          }
          case 18: {
            Token = input.ReadString();
            break;
          }
          case 26: {
            LoginIP = input.ReadString();
            break;
          }
          case 32: {
            LoginPort = input.ReadInt32();
            break;
          }
          case 42: {
            GateIP = input.ReadString();
            break;
          }
          case 48: {
            GatePort = input.ReadInt32();
            break;
          }
          case 58: {
            ApiIP = input.ReadString();
            break;
          }
          case 64: {
            ApiPort = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code