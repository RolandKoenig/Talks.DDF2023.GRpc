// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeFieldType/MyTestMessageUpdated.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HappyCoding.ProtobufSerialization.CompatibleModificationsTests.ChangeFieldType {

  /// <summary>Holder for reflection information generated from ChangeFieldType/MyTestMessageUpdated.proto</summary>
  public static partial class MyTestMessageUpdatedReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeFieldType/MyTestMessageUpdated.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MyTestMessageUpdatedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipDaGFuZ2VGaWVsZFR5cGUvTXlUZXN0TWVzc2FnZVVwZGF0ZWQucHJvdG8i",
            "WAoUTXlUZXN0TWVzc2FnZVVwZGF0ZWQSEQoJZmlyc3ROYW1lGAEgASgJEhAK",
            "CGxhc3ROYW1lGAIgASgJEgsKA2FnZRgDIAEoCRIOCgZlbWFpbHMYBCADKAlC",
            "UaoCTkhhcHB5Q29kaW5nLlByb3RvYnVmU2VyaWFsaXphdGlvbi5Db21wYXRp",
            "YmxlTW9kaWZpY2F0aW9uc1Rlc3RzLkNoYW5nZUZpZWxkVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HappyCoding.ProtobufSerialization.CompatibleModificationsTests.ChangeFieldType.MyTestMessageUpdated), global::HappyCoding.ProtobufSerialization.CompatibleModificationsTests.ChangeFieldType.MyTestMessageUpdated.Parser, new[]{ "FirstName", "LastName", "Age", "Emails" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MyTestMessageUpdated : pb::IMessage<MyTestMessageUpdated>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MyTestMessageUpdated> _parser = new pb::MessageParser<MyTestMessageUpdated>(() => new MyTestMessageUpdated());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MyTestMessageUpdated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HappyCoding.ProtobufSerialization.CompatibleModificationsTests.ChangeFieldType.MyTestMessageUpdatedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MyTestMessageUpdated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MyTestMessageUpdated(MyTestMessageUpdated other) : this() {
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      age_ = other.age_;
      emails_ = other.emails_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MyTestMessageUpdated Clone() {
      return new MyTestMessageUpdated(this);
    }

    /// <summary>Field number for the "firstName" field.</summary>
    public const int FirstNameFieldNumber = 1;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastName" field.</summary>
    public const int LastNameFieldNumber = 2;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 3;
    private string age_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Age {
      get { return age_; }
      set {
        age_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      return Equals(other as MyTestMessageUpdated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MyTestMessageUpdated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (Age != other.Age) return false;
      if(!emails_.Equals(other.emails_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (Age.Length != 0) hash ^= Age.GetHashCode();
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
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LastName);
      }
      if (Age.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Age);
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
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LastName);
      }
      if (Age.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Age);
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
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (Age.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Age);
      }
      size += emails_.CalculateSize(_repeated_emails_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MyTestMessageUpdated other) {
      if (other == null) {
        return;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.Age.Length != 0) {
        Age = other.Age;
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            LastName = input.ReadString();
            break;
          }
          case 26: {
            Age = input.ReadString();
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            LastName = input.ReadString();
            break;
          }
          case 26: {
            Age = input.ReadString();
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
