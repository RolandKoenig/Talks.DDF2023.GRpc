// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MyTestMessage_DifferentNames.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HappyCoding.ProtobufSerialization.UsingGoogleProtobuf.Data {

  /// <summary>Holder for reflection information generated from MyTestMessage_DifferentNames.proto</summary>
  public static partial class MyTestMessageDifferentNamesReflection {

    #region Descriptor
    /// <summary>File descriptor for MyTestMessage_DifferentNames.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MyTestMessageDifferentNamesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJNeVRlc3RNZXNzYWdlX0RpZmZlcmVudE5hbWVzLnByb3RvImAKHE15VGVz",
            "dE1lc3NhZ2VfRGlmZmVyZW50TmFtZXMSDwoHdm9yTmFtZRgBIAEoCRIQCghu",
            "YWNoTmFtZRgCIAEoCRINCgVhbHRlchgDIAEoBRIOCgZlbWFpbHMYBCADKAlC",
            "PaoCOkhhcHB5Q29kaW5nLlByb3RvYnVmU2VyaWFsaXphdGlvbi5Vc2luZ0dv",
            "b2dsZVByb3RvYnVmLkRhdGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HappyCoding.ProtobufSerialization.UsingGoogleProtobuf.Data.MyTestMessage_DifferentNames), global::HappyCoding.ProtobufSerialization.UsingGoogleProtobuf.Data.MyTestMessage_DifferentNames.Parser, new[]{ "VorName", "NachName", "Alter", "Emails" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MyTestMessage_DifferentNames : pb::IMessage<MyTestMessage_DifferentNames>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MyTestMessage_DifferentNames> _parser = new pb::MessageParser<MyTestMessage_DifferentNames>(() => new MyTestMessage_DifferentNames());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MyTestMessage_DifferentNames> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HappyCoding.ProtobufSerialization.UsingGoogleProtobuf.Data.MyTestMessageDifferentNamesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MyTestMessage_DifferentNames() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MyTestMessage_DifferentNames(MyTestMessage_DifferentNames other) : this() {
      vorName_ = other.vorName_;
      nachName_ = other.nachName_;
      alter_ = other.alter_;
      emails_ = other.emails_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MyTestMessage_DifferentNames Clone() {
      return new MyTestMessage_DifferentNames(this);
    }

    /// <summary>Field number for the "vorName" field.</summary>
    public const int VorNameFieldNumber = 1;
    private string vorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string VorName {
      get { return vorName_; }
      set {
        vorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nachName" field.</summary>
    public const int NachNameFieldNumber = 2;
    private string nachName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NachName {
      get { return nachName_; }
      set {
        nachName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "alter" field.</summary>
    public const int AlterFieldNumber = 3;
    private int alter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Alter {
      get { return alter_; }
      set {
        alter_ = value;
      }
    }

    /// <summary>Field number for the "emails" field.</summary>
    public const int EmailsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_emails_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> emails_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Emails {
      get { return emails_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MyTestMessage_DifferentNames);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MyTestMessage_DifferentNames other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VorName != other.VorName) return false;
      if (NachName != other.NachName) return false;
      if (Alter != other.Alter) return false;
      if(!emails_.Equals(other.emails_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (VorName.Length != 0) hash ^= VorName.GetHashCode();
      if (NachName.Length != 0) hash ^= NachName.GetHashCode();
      if (Alter != 0) hash ^= Alter.GetHashCode();
      hash ^= emails_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (VorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VorName);
      }
      if (NachName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NachName);
      }
      if (Alter != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Alter);
      }
      emails_.WriteTo(output, _repeated_emails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (VorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VorName);
      }
      if (NachName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NachName);
      }
      if (Alter != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Alter);
      }
      emails_.WriteTo(ref output, _repeated_emails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (VorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VorName);
      }
      if (NachName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NachName);
      }
      if (Alter != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Alter);
      }
      size += emails_.CalculateSize(_repeated_emails_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MyTestMessage_DifferentNames other) {
      if (other == null) {
        return;
      }
      if (other.VorName.Length != 0) {
        VorName = other.VorName;
      }
      if (other.NachName.Length != 0) {
        NachName = other.NachName;
      }
      if (other.Alter != 0) {
        Alter = other.Alter;
      }
      emails_.Add(other.emails_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            VorName = input.ReadString();
            break;
          }
          case 18: {
            NachName = input.ReadString();
            break;
          }
          case 24: {
            Alter = input.ReadInt32();
            break;
          }
          case 34: {
            emails_.AddEntriesFrom(input, _repeated_emails_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            VorName = input.ReadString();
            break;
          }
          case 18: {
            NachName = input.ReadString();
            break;
          }
          case 24: {
            Alter = input.ReadInt32();
            break;
          }
          case 34: {
            emails_.AddEntriesFrom(ref input, _repeated_emails_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
