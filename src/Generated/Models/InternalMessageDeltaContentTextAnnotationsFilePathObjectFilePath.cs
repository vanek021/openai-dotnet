// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath()
        {
        }

        internal InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath(string fileId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileId = fileId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string FileId { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
