namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class GetMsgImgRequest : GeneratedMessageLite<GetMsgImgRequest, GetMsgImgRequest.Builder>
    {
        private static readonly string[] _getMsgImgRequestFieldNames = new string[] { "BaseRequest", "CompressType", "DataLen", "FromUserName", "MsgId", "StartPos", "ToUserName", "TotalLen" };
        private static readonly uint[] _getMsgImgRequestFieldTags = new uint[] { 10, 0x40, 0x38, 0x1a, 0x10, 0x30, 0x22, 40 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint compressType_;
        public const int CompressTypeFieldNumber = 8;
        private uint dataLen_;
        public const int DataLenFieldNumber = 7;
        private static readonly GetMsgImgRequest defaultInstance = new GetMsgImgRequest().MakeReadOnly();
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 3;
        private bool hasBaseRequest;
        private bool hasCompressType;
        private bool hasDataLen;
        private bool hasFromUserName;
        private bool hasMsgId;
        private bool hasStartPos;
        private bool hasTotalLen;
        private bool hasToUserName;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 2;
        private uint startPos_;
        public const int StartPosFieldNumber = 6;
        private uint totalLen_;
        public const int TotalLenFieldNumber = 5;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 4;

        static GetMsgImgRequest()
        {

        }

        private GetMsgImgRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetMsgImgRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetMsgImgRequest request = obj as GetMsgImgRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasMsgId != request.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(request.msgId_)))
            {
                return false;
            }
            if ((this.hasFromUserName != request.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(request.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != request.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(request.toUserName_)))
            {
                return false;
            }
            if ((this.hasTotalLen != request.hasTotalLen) || (this.hasTotalLen && !this.totalLen_.Equals(request.totalLen_)))
            {
                return false;
            }
            if ((this.hasStartPos != request.hasStartPos) || (this.hasStartPos && !this.startPos_.Equals(request.startPos_)))
            {
                return false;
            }
            if ((this.hasDataLen != request.hasDataLen) || (this.hasDataLen && !this.dataLen_.Equals(request.dataLen_)))
            {
                return false;
            }
            return ((this.hasCompressType == request.hasCompressType) && (!this.hasCompressType || this.compressType_.Equals(request.compressType_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasTotalLen)
            {
                hashCode ^= this.totalLen_.GetHashCode();
            }
            if (this.hasStartPos)
            {
                hashCode ^= this.startPos_.GetHashCode();
            }
            if (this.hasDataLen)
            {
                hashCode ^= this.dataLen_.GetHashCode();
            }
            if (this.hasCompressType)
            {
                hashCode ^= this.compressType_.GetHashCode();
            }
            return hashCode;
        }

        private GetMsgImgRequest MakeReadOnly()
        {
            return this;
        }

        public static GetMsgImgRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("TotalLen", this.hasTotalLen, this.totalLen_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("StartPos", this.hasStartPos, this.startPos_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("DataLen", this.hasDataLen, this.dataLen_, writer);
            GeneratedMessageLite<GetMsgImgRequest, Builder>.PrintField("CompressType", this.hasCompressType, this.compressType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getMsgImgRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(2, strArray[4], this.MsgId);
            }
            if (this.hasFromUserName)
            {
                output.WriteMessage(3, strArray[3], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(4, strArray[6], this.ToUserName);
            }
            if (this.hasTotalLen)
            {
                output.WriteUInt32(5, strArray[7], this.TotalLen);
            }
            if (this.hasStartPos)
            {
                output.WriteUInt32(6, strArray[5], this.StartPos);
            }
            if (this.hasDataLen)
            {
                output.WriteUInt32(7, strArray[2], this.DataLen);
            }
            if (this.hasCompressType)
            {
                output.WriteUInt32(8, strArray[1], this.CompressType);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public uint CompressType
        {
            get
            {
                return this.compressType_;
            }
        }

        public uint DataLen
        {
            get
            {
                return this.dataLen_;
            }
        }

        public static GetMsgImgRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetMsgImgRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t FromUserName
        {
            get
            {
                return (this.fromUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasFromUserName)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasTotalLen)
                {
                    return false;
                }
                if (!this.hasStartPos)
                {
                    return false;
                }
                if (!this.hasDataLen)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint MsgId
        {
            get
            {
                return this.msgId_;
            }
        }

        public override int SerializedSize
        {
            get
            {
                int memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize == -1)
                {
                    memoizedSerializedSize = 0;
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseRequest);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MsgId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ToUserName);
                    }
                    if (this.hasTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.TotalLen);
                    }
                    if (this.hasStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.StartPos);
                    }
                    if (this.hasDataLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.DataLen);
                    }
                    if (this.hasCompressType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.CompressType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint StartPos
        {
            get
            {
                return this.startPos_;
            }
        }

        protected override GetMsgImgRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TotalLen
        {
            get
            {
                return this.totalLen_;
            }
        }

        public SKBuiltinString_t ToUserName
        {
            get
            {
                return (this.toUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GetMsgImgRequest, GetMsgImgRequest.Builder>
        {
            private GetMsgImgRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetMsgImgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetMsgImgRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetMsgImgRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetMsgImgRequest.Builder Clear()
            {
                this.result = GetMsgImgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetMsgImgRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public GetMsgImgRequest.Builder ClearCompressType()
            {
                this.PrepareBuilder();
                this.result.hasCompressType = false;
                this.result.compressType_ = 0;
                return this;
            }

            public GetMsgImgRequest.Builder ClearDataLen()
            {
                this.PrepareBuilder();
                this.result.hasDataLen = false;
                this.result.dataLen_ = 0;
                return this;
            }

            public GetMsgImgRequest.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public GetMsgImgRequest.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public GetMsgImgRequest.Builder ClearStartPos()
            {
                this.PrepareBuilder();
                this.result.hasStartPos = false;
                this.result.startPos_ = 0;
                return this;
            }

            public GetMsgImgRequest.Builder ClearTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = false;
                this.result.totalLen_ = 0;
                return this;
            }

            public GetMsgImgRequest.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public override GetMsgImgRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetMsgImgRequest.Builder(this.result);
                }
                return new GetMsgImgRequest.Builder().MergeFrom(this.result);
            }

            public GetMsgImgRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != micromsg.BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = micromsg.BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public override GetMsgImgRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetMsgImgRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetMsgImgRequest)
                {
                    return this.MergeFrom((GetMsgImgRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetMsgImgRequest.Builder MergeFrom(GetMsgImgRequest other)
            {
                return this;
            }

            public override GetMsgImgRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetMsgImgRequest._getMsgImgRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetMsgImgRequest._getMsgImgRequestFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x10:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasFromUserName)
                            {
                                builder2.MergeFrom(this.FromUserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.FromUserName = builder2.BuildPartial();
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            micromsg.BaseRequest.Builder builder = micromsg.BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasToUserName)
                            {
                                builder3.MergeFrom(this.ToUserName);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.ToUserName = builder3.BuildPartial();
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasTotalLen = input.ReadUInt32(ref this.result.totalLen_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasStartPos = input.ReadUInt32(ref this.result.startPos_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasDataLen = input.ReadUInt32(ref this.result.dataLen_);
                            continue;
                        }
                        case 0x40:
                            break;

                        default:
                        {
                            if (WireFormat.IsEndGroupTag(num))
                            {
                                return this;
                            }
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    this.result.hasCompressType = input.ReadUInt32(ref this.result.compressType_);
                }
                return this;
            }

            public GetMsgImgRequest.Builder MergeFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasFromUserName && (this.result.fromUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.fromUserName_ = SKBuiltinString_t.CreateBuilder(this.result.fromUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.fromUserName_ = value;
                }
                this.result.hasFromUserName = true;
                return this;
            }

            public GetMsgImgRequest.Builder MergeToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasToUserName && (this.result.toUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.toUserName_ = SKBuiltinString_t.CreateBuilder(this.result.toUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.toUserName_ = value;
                }
                this.result.hasToUserName = true;
                return this;
            }

            private GetMsgImgRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetMsgImgRequest result = this.result;
                    this.result = new GetMsgImgRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetMsgImgRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public GetMsgImgRequest.Builder SetCompressType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCompressType = true;
                this.result.compressType_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetDataLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDataLen = true;
                this.result.dataLen_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public GetMsgImgRequest.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStartPos = true;
                this.result.startPos_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = true;
                this.result.totalLen_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public GetMsgImgRequest.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public micromsg.BaseRequest BaseRequest
            {
                get
                {
                    return this.result.BaseRequest;
                }
                set
                {
                    this.SetBaseRequest(value);
                }
            }

            public uint CompressType
            {
                get
                {
                    return this.result.CompressType;
                }
                set
                {
                    this.SetCompressType(value);
                }
            }

            public uint DataLen
            {
                get
                {
                    return this.result.DataLen;
                }
                set
                {
                    this.SetDataLen(value);
                }
            }

            public override GetMsgImgRequest DefaultInstanceForType
            {
                get
                {
                    return GetMsgImgRequest.DefaultInstance;
                }
            }

            public SKBuiltinString_t FromUserName
            {
                get
                {
                    return this.result.FromUserName;
                }
                set
                {
                    this.SetFromUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetMsgImgRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint MsgId
            {
                get
                {
                    return this.result.MsgId;
                }
                set
                {
                    this.SetMsgId(value);
                }
            }

            public uint StartPos
            {
                get
                {
                    return this.result.StartPos;
                }
                set
                {
                    this.SetStartPos(value);
                }
            }

            protected override GetMsgImgRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TotalLen
            {
                get
                {
                    return this.result.TotalLen;
                }
                set
                {
                    this.SetTotalLen(value);
                }
            }

            public SKBuiltinString_t ToUserName
            {
                get
                {
                    return this.result.ToUserName;
                }
                set
                {
                    this.SetToUserName(value);
                }
            }
        }
    }
}
