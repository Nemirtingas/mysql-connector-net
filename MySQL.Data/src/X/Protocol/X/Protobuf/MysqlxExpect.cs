// Copyright (c) 2023, Oracle and/or its affiliates.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License, version 2.0, as
// published by the Free Software Foundation.
//
// This program is also distributed with certain software (including
// but not limited to OpenSSL) that is licensed under separate terms,
// as designated in a particular file or component or in included license
// documentation. The authors of MySQL hereby grant you an
// additional permission to link the program and your derivative works
// with the separately licensed software that they have included with
// MySQL.
//
// Without limiting anything contained in the foregoing, this file,
// which is part of MySQL Connector/NET, is also subject to the
// Universal FOSS Exception, version 1.0, a copy of which can be found at
// http://oss.oracle.com/licenses/universal-foss-exception.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License, version 2.0, for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mysqlx_expect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mysqlx.Expect
{

  /// <summary>Holder for reflection information generated from mysqlx_expect.proto</summary>
  public static partial class MysqlxExpectReflection
  {

    #region Descriptor
    /// <summary>File descriptor for mysqlx_expect.proto</summary>
    public static pbr::FileDescriptor Descriptor
    {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MysqlxExpectReflection()
    {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNteXNxbHhfZXhwZWN0LnByb3RvEg1NeXNxbHguRXhwZWN0GgxteXNxbHgu",
            "cHJvdG8i1gMKBE9wZW4SQgoCb3AYASABKA4yIC5NeXNxbHguRXhwZWN0Lk9w",
            "ZW4uQ3R4T3BlcmF0aW9uOhRFWFBFQ1RfQ1RYX0NPUFlfUFJFVhIrCgRjb25k",
            "GAIgAygLMh0uTXlzcWx4LkV4cGVjdC5PcGVuLkNvbmRpdGlvbhqWAgoJQ29u",
            "ZGl0aW9uEhUKDWNvbmRpdGlvbl9rZXkYASACKA0SFwoPY29uZGl0aW9uX3Zh",
            "bHVlGAIgASgMEksKAm9wGAMgASgOMjAuTXlzcWx4LkV4cGVjdC5PcGVuLkNv",
            "bmRpdGlvbi5Db25kaXRpb25PcGVyYXRpb246DUVYUEVDVF9PUF9TRVQiTgoD",
            "S2V5EhMKD0VYUEVDVF9OT19FUlJPUhABEhYKEkVYUEVDVF9GSUVMRF9FWElT",
            "VBACEhoKFkVYUEVDVF9ET0NJRF9HRU5FUkFURUQQAyI8ChJDb25kaXRpb25P",
            "cGVyYXRpb24SEQoNRVhQRUNUX09QX1NFVBAAEhMKD0VYUEVDVF9PUF9VTlNF",
            "VBABIj4KDEN0eE9wZXJhdGlvbhIYChRFWFBFQ1RfQ1RYX0NPUFlfUFJFVhAA",
            "EhQKEEVYUEVDVF9DVFhfRU1QVFkQAToEiOowGCINCgVDbG9zZToEiOowGUIZ",
            "Chdjb20ubXlzcWwuY2oueC5wcm90b2J1Zg=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mysqlx.MysqlxReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Expect.Open), global::Mysqlx.Expect.Open.Parser, new[]{ "Op", "Cond" }, null, new[]{ typeof(global::Mysqlx.Expect.Open.Types.CtxOperation) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Expect.Open.Types.Condition), global::Mysqlx.Expect.Open.Types.Condition.Parser, new[]{ "ConditionKey", "ConditionValue", "Op" }, null, new[]{ typeof(global::Mysqlx.Expect.Open.Types.Condition.Types.Key), typeof(global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation) }, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Expect.Close), global::Mysqlx.Expect.Close.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  ///Open an Expect block and set/unset the conditions that have to
  ///be fulfilled.
  ///
  ///If any of the conditions fail, all enclosed messages will fail
  ///with a ``Mysqlx::Error`` message.
  ///
  ///@returns @ref Mysqlx::Ok on success, @ref Mysqlx::Error on error
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Open : pb::IMessage<Open>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
  {
    private static readonly pb::MessageParser<Open> _parser = new pb::MessageParser<Open>(() => new Open());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Open> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
      get { return global::Mysqlx.Expect.MysqlxExpectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Open()
    {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Open(Open other) : this()
    {
      _hasBits0 = other._hasBits0;
      op_ = other.op_;
      cond_ = other.cond_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Open Clone()
    {
      return new Open(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private readonly static global::Mysqlx.Expect.Open.Types.CtxOperation OpDefaultValue = global::Mysqlx.Expect.Open.Types.CtxOperation.ExpectCtxCopyPrev;

    private global::Mysqlx.Expect.Open.Types.CtxOperation op_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mysqlx.Expect.Open.Types.CtxOperation Op
    {
      get { if ((_hasBits0 & 1) != 0) { return op_; } else { return OpDefaultValue; } }
      set
      {
        _hasBits0 |= 1;
        op_ = value;
      }
    }
    /// <summary>Gets whether the "op" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOp
    {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "op" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOp()
    {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "cond" field.</summary>
    public const int CondFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Mysqlx.Expect.Open.Types.Condition> _repeated_cond_codec
        = pb::FieldCodec.ForMessage(18, global::Mysqlx.Expect.Open.Types.Condition.Parser);
    private readonly pbc::RepeatedField<global::Mysqlx.Expect.Open.Types.Condition> cond_ = new pbc::RepeatedField<global::Mysqlx.Expect.Open.Types.Condition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Mysqlx.Expect.Open.Types.Condition> Cond
    {
      get { return cond_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
      return Equals(other as Open);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Open other)
    {
      if (ReferenceEquals(other, null))
      {
        return false;
      }
      if (ReferenceEquals(other, this))
      {
        return true;
      }
      if (Op != other.Op) return false;
      if (!cond_.Equals(other.cond_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
      int hash = 1;
      if (HasOp) hash ^= Op.GetHashCode();
      hash ^= cond_.GetHashCode();
      if (_unknownFields != null)
      {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
#else
      if (HasOp) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Op);
      }
      cond_.WriteTo(output, _repeated_cond_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
      if (HasOp)
      {
        output.WriteRawTag(8);
        output.WriteEnum((int)Op);
      }
      cond_.WriteTo(ref output, _repeated_cond_codec);
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(ref output);
      }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
      int size = 0;
      if (HasOp)
      {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Op);
      }
      size += cond_.CalculateSize(_repeated_cond_codec);
      if (_unknownFields != null)
      {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Open other)
    {
      if (other == null)
      {
        return;
      }
      if (other.HasOp)
      {
        Op = other.Op;
      }
      cond_.Add(other.cond_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Op = (global::Mysqlx.Expect.Open.Types.CtxOperation) input.ReadEnum();
            break;
          }
          case 18: {
            cond_.AddEntriesFrom(input, _repeated_cond_codec);
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
      uint tag;
      while ((tag = input.ReadTag()) != 0)
      {
        switch (tag)
        {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8:
            {
              Op = (global::Mysqlx.Expect.Open.Types.CtxOperation)input.ReadEnum();
              break;
            }
          case 18:
            {
              cond_.AddEntriesFrom(ref input, _repeated_cond_codec);
              break;
            }
        }
      }
    }
#endif

    #region Nested types
    /// <summary>Container for nested types declared in the Open message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types
    {
      public enum CtxOperation
      {
        /// <summary>
        ///* copy the operations from the parent Expect-block 
        /// </summary>
        [pbr::OriginalName("EXPECT_CTX_COPY_PREV")] ExpectCtxCopyPrev = 0,
        /// <summary>
        ///* start with a empty set of operations 
        /// </summary>
        [pbr::OriginalName("EXPECT_CTX_EMPTY")] ExpectCtxEmpty = 1,
      }

      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class Condition : pb::IMessage<Condition>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
#endif
      {
        private static readonly pb::MessageParser<Condition> _parser = new pb::MessageParser<Condition>(() => new Condition());
        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Condition> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
          get { return global::Mysqlx.Expect.Open.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Condition()
        {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Condition(Condition other) : this()
        {
          _hasBits0 = other._hasBits0;
          conditionKey_ = other.conditionKey_;
          conditionValue_ = other.conditionValue_;
          op_ = other.op_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Condition Clone()
        {
          return new Condition(this);
        }

        /// <summary>Field number for the "condition_key" field.</summary>
        public const int ConditionKeyFieldNumber = 1;
        private readonly static uint ConditionKeyDefaultValue = 0;

        private uint conditionKey_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint ConditionKey
        {
          get { if ((_hasBits0 & 1) != 0) { return conditionKey_; } else { return ConditionKeyDefaultValue; } }
          set
          {
            _hasBits0 |= 1;
            conditionKey_ = value;
          }
        }
        /// <summary>Gets whether the "condition_key" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasConditionKey
        {
          get { return (_hasBits0 & 1) != 0; }
        }
        /// <summary>Clears the value of the "condition_key" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearConditionKey()
        {
          _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "condition_value" field.</summary>
        public const int ConditionValueFieldNumber = 2;
        private readonly static pb::ByteString ConditionValueDefaultValue = pb::ByteString.Empty;

        private pb::ByteString conditionValue_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pb::ByteString ConditionValue
        {
          get { return conditionValue_ ?? ConditionValueDefaultValue; }
          set
          {
            conditionValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }
        /// <summary>Gets whether the "condition_value" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasConditionValue
        {
          get { return conditionValue_ != null; }
        }
        /// <summary>Clears the value of the "condition_value" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearConditionValue()
        {
          conditionValue_ = null;
        }

        /// <summary>Field number for the "op" field.</summary>
        public const int OpFieldNumber = 3;
        private readonly static global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation OpDefaultValue = global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation.ExpectOpSet;

        private global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation op_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation Op
        {
          get { if ((_hasBits0 & 2) != 0) { return op_; } else { return OpDefaultValue; } }
          set
          {
            _hasBits0 |= 2;
            op_ = value;
          }
        }
        /// <summary>Gets whether the "op" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasOp
        {
          get { return (_hasBits0 & 2) != 0; }
        }
        /// <summary>Clears the value of the "op" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearOp()
        {
          _hasBits0 &= ~2;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
          return Equals(other as Condition);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Condition other)
        {
          if (ReferenceEquals(other, null))
          {
            return false;
          }
          if (ReferenceEquals(other, this))
          {
            return true;
          }
          if (ConditionKey != other.ConditionKey) return false;
          if (ConditionValue != other.ConditionValue) return false;
          if (Op != other.Op) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
          int hash = 1;
          if (HasConditionKey) hash ^= ConditionKey.GetHashCode();
          if (HasConditionValue) hash ^= ConditionValue.GetHashCode();
          if (HasOp) hash ^= Op.GetHashCode();
          if (_unknownFields != null)
          {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
#else
          if (HasConditionKey) {
            output.WriteRawTag(8);
            output.WriteUInt32(ConditionKey);
          }
          if (HasConditionValue) {
            output.WriteRawTag(18);
            output.WriteBytes(ConditionValue);
          }
          if (HasOp) {
            output.WriteRawTag(24);
            output.WriteEnum((int) Op);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
          if (HasConditionKey)
          {
            output.WriteRawTag(8);
            output.WriteUInt32(ConditionKey);
          }
          if (HasConditionValue)
          {
            output.WriteRawTag(18);
            output.WriteBytes(ConditionValue);
          }
          if (HasOp)
          {
            output.WriteRawTag(24);
            output.WriteEnum((int)Op);
          }
          if (_unknownFields != null)
          {
            _unknownFields.WriteTo(ref output);
          }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
          int size = 0;
          if (HasConditionKey)
          {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConditionKey);
          }
          if (HasConditionValue)
          {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(ConditionValue);
          }
          if (HasOp)
          {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Op);
          }
          if (_unknownFields != null)
          {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Condition other)
        {
          if (other == null)
          {
            return;
          }
          if (other.HasConditionKey)
          {
            ConditionKey = other.ConditionKey;
          }
          if (other.HasConditionValue)
          {
            ConditionValue = other.ConditionValue;
          }
          if (other.HasOp)
          {
            Op = other.Op;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
#else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                ConditionKey = input.ReadUInt32();
                break;
              }
              case 18: {
                ConditionValue = input.ReadBytes();
                break;
              }
              case 24: {
                Op = (global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation) input.ReadEnum();
                break;
              }
            }
          }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
          uint tag;
          while ((tag = input.ReadTag()) != 0)
          {
            switch (tag)
            {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 8:
                {
                  ConditionKey = input.ReadUInt32();
                  break;
                }
              case 18:
                {
                  ConditionValue = input.ReadBytes();
                  break;
                }
              case 24:
                {
                  Op = (global::Mysqlx.Expect.Open.Types.Condition.Types.ConditionOperation)input.ReadEnum();
                  break;
                }
            }
          }
        }
#endif

        #region Nested types
        /// <summary>Container for nested types declared in the Condition message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types
        {
          public enum Key
          {
            /// <summary>
            ///* Change error propagation behaviour 
            /// </summary>
            [pbr::OriginalName("EXPECT_NO_ERROR")] ExpectNoError = 1,
            /// <summary>
            ///* Check if X Protocol field exists 
            /// </summary>
            [pbr::OriginalName("EXPECT_FIELD_EXIST")] ExpectFieldExist = 2,
            /// <summary>
            ///* Check if X Protocol supports document _id generation 
            /// </summary>
            [pbr::OriginalName("EXPECT_DOCID_GENERATED")] ExpectDocidGenerated = 3,
          }

          public enum ConditionOperation
          {
            /// <summary>
            ///* set the condition; set, if not set; overwrite, if set 
            /// </summary>
            [pbr::OriginalName("EXPECT_OP_SET")] ExpectOpSet = 0,
            /// <summary>
            ///* unset the condition 
            /// </summary>
            [pbr::OriginalName("EXPECT_OP_UNSET")] ExpectOpUnset = 1,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  /// <summary>
  ///*
  ///Close a Expect block.
  ///
  ///Closing a Expect block restores the state of the previous Expect
  ///block for the following messages.
  ///
  ///@returns @ref Mysqlx::Ok on success,  @ref Mysqlx::Error on error
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Close : pb::IMessage<Close>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
  {
    private static readonly pb::MessageParser<Close> _parser = new pb::MessageParser<Close>(() => new Close());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Close> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
      get { return global::Mysqlx.Expect.MysqlxExpectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Close()
    {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Close(Close other) : this()
    {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Close Clone()
    {
      return new Close(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
      return Equals(other as Close);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Close other)
    {
      if (ReferenceEquals(other, null))
      {
        return false;
      }
      if (ReferenceEquals(other, this))
      {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
      int hash = 1;
      if (_unknownFields != null)
      {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
#else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
      if (_unknownFields != null)
      {
        _unknownFields.WriteTo(ref output);
      }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
      int size = 0;
      if (_unknownFields != null)
      {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Close other)
    {
      if (other == null)
      {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
      uint tag;
      while ((tag = input.ReadTag()) != 0)
      {
        switch (tag)
        {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
#endif

  }

  #endregion

}

#endregion Designer generated code
