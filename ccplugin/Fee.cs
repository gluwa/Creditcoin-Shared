// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Fee.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Fee.proto</summary>
public static partial class FeeReflection {

  #region Descriptor
  /// <summary>File descriptor for Fee.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FeeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CglGZWUucHJvdG8iJQoDRmVlEg8KB3NpZ2hhc2gYASABKAkSDQoFYmxvY2sY",
          "AiABKAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Fee), global::Fee.Parser, new[]{ "Sighash", "Block" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Fee : pb::IMessage<Fee> {
  private static readonly pb::MessageParser<Fee> _parser = new pb::MessageParser<Fee>(() => new Fee());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Fee> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FeeReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Fee() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Fee(Fee other) : this() {
    sighash_ = other.sighash_;
    block_ = other.block_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Fee Clone() {
    return new Fee(this);
  }

  /// <summary>Field number for the "sighash" field.</summary>
  public const int SighashFieldNumber = 1;
  private string sighash_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Sighash {
    get { return sighash_; }
    set {
      sighash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "block" field.</summary>
  public const int BlockFieldNumber = 2;
  private string block_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Block {
    get { return block_; }
    set {
      block_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Fee);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Fee other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Sighash != other.Sighash) return false;
    if (Block != other.Block) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Sighash.Length != 0) hash ^= Sighash.GetHashCode();
    if (Block.Length != 0) hash ^= Block.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Sighash.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Sighash);
    }
    if (Block.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Block);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Sighash.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Sighash);
    }
    if (Block.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Block);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Fee other) {
    if (other == null) {
      return;
    }
    if (other.Sighash.Length != 0) {
      Sighash = other.Sighash;
    }
    if (other.Block.Length != 0) {
      Block = other.Block;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Sighash = input.ReadString();
          break;
        }
        case 18: {
          Block = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
