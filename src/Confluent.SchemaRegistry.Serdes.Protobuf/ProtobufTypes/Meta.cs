// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: confluent/meta.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Confluent.SchemaRegistry.Serdes.Protobuf {

  /// <summary>Holder for reflection information generated from confluent/meta.proto</summary>
  public static partial class MetaReflection {

    #region Descriptor
    /// <summary>File descriptor for confluent/meta.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRjb25mbHVlbnQvbWV0YS5wcm90bxIJY29uZmx1ZW50GiBnb29nbGUvcHJv",
            "dG9idWYvZGVzY3JpcHRvci5wcm90byJ9CgRNZXRhEgsKA2RvYxgBIAEoCRIr",
            "CgZwYXJhbXMYAiADKAsyGy5jb25mbHVlbnQuTWV0YS5QYXJhbXNFbnRyeRIM",
            "CgR0YWdzGAMgAygJGi0KC1BhcmFtc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2",
            "YWx1ZRgCIAEoCToCOAE6QQoJZmlsZV9tZXRhEhwuZ29vZ2xlLnByb3RvYnVm",
            "LkZpbGVPcHRpb25zGMAIIAEoCzIPLmNvbmZsdWVudC5NZXRhOkcKDG1lc3Nh",
            "Z2VfbWV0YRIfLmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxjACCAB",
            "KAsyDy5jb25mbHVlbnQuTWV0YTpDCgpmaWVsZF9tZXRhEh0uZ29vZ2xlLnBy",
            "b3RvYnVmLkZpZWxkT3B0aW9ucxjACCABKAsyDy5jb25mbHVlbnQuTWV0YTpB",
            "CgllbnVtX21ldGESHC5nb29nbGUucHJvdG9idWYuRW51bU9wdGlvbnMYwAgg",
            "ASgLMg8uY29uZmx1ZW50Lk1ldGE6TAoPZW51bV92YWx1ZV9tZXRhEiEuZ29v",
            "Z2xlLnByb3RvYnVmLkVudW1WYWx1ZU9wdGlvbnMYwAggASgLMg8uY29uZmx1",
            "ZW50Lk1ldGFCK6oCKENvbmZsdWVudC5TY2hlbWFSZWdpc3RyeS5TZXJkZXMu",
            "UHJvdG9idWZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { MetaExtensions.FileMeta, MetaExtensions.MessageMeta, MetaExtensions.FieldMeta, MetaExtensions.EnumMeta, MetaExtensions.EnumValueMeta }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta), global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta.Parser, new[]{ "Doc", "Params", "Tags" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of confluent/meta.proto</summary>
  public static partial class MetaExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta> FileMeta =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta>(1088, pb::FieldCodec.ForMessage(8706, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta> MessageMeta =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta>(1088, pb::FieldCodec.ForMessage(8706, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta> FieldMeta =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta>(1088, pb::FieldCodec.ForMessage(8706, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta> EnumMeta =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta>(1088, pb::FieldCodec.ForMessage(8706, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumValueOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta> EnumValueMeta =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumValueOptions, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta>(1088, pb::FieldCodec.ForMessage(8706, global::Confluent.SchemaRegistry.Serdes.Protobuf.Meta.Parser));
  }

  #region Messages
  public sealed partial class Meta : pb::IMessage<Meta>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Meta> _parser = new pb::MessageParser<Meta>(() => new Meta());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Meta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Confluent.SchemaRegistry.Serdes.Protobuf.MetaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Meta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Meta(Meta other) : this() {
      doc_ = other.doc_;
      params_ = other.params_.Clone();
      tags_ = other.tags_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Meta Clone() {
      return new Meta(this);
    }

    /// <summary>Field number for the "doc" field.</summary>
    public const int DocFieldNumber = 1;
    private string doc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Doc {
      get { return doc_; }
      set {
        doc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_params_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> params_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Params {
      get { return params_; }
    }

    /// <summary>Field number for the "tags" field.</summary>
    public const int TagsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_tags_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> tags_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Tags {
      get { return tags_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Meta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Meta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Doc != other.Doc) return false;
      if (!Params.Equals(other.Params)) return false;
      if(!tags_.Equals(other.tags_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Doc.Length != 0) hash ^= Doc.GetHashCode();
      hash ^= Params.GetHashCode();
      hash ^= tags_.GetHashCode();
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
      if (Doc.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Doc);
      }
      params_.WriteTo(output, _map_params_codec);
      tags_.WriteTo(output, _repeated_tags_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Doc.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Doc);
      }
      params_.WriteTo(ref output, _map_params_codec);
      tags_.WriteTo(ref output, _repeated_tags_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Doc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Doc);
      }
      size += params_.CalculateSize(_map_params_codec);
      size += tags_.CalculateSize(_repeated_tags_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Meta other) {
      if (other == null) {
        return;
      }
      if (other.Doc.Length != 0) {
        Doc = other.Doc;
      }
      params_.Add(other.params_);
      tags_.Add(other.tags_);
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
            Doc = input.ReadString();
            break;
          }
          case 18: {
            params_.AddEntriesFrom(input, _map_params_codec);
            break;
          }
          case 26: {
            tags_.AddEntriesFrom(input, _repeated_tags_codec);
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
            Doc = input.ReadString();
            break;
          }
          case 18: {
            params_.AddEntriesFrom(ref input, _map_params_codec);
            break;
          }
          case 26: {
            tags_.AddEntriesFrom(ref input, _repeated_tags_codec);
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