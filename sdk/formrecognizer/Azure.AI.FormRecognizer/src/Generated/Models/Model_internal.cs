// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary> Response to the get custom model operation. </summary>
    internal partial class Model_internal
    {
        /// <summary> Initializes a new instance of Model_internal. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        internal Model_internal(ModelInfo_internal modelInfo)
        {
            if (modelInfo == null)
            {
                throw new ArgumentNullException(nameof(modelInfo));
            }

            ModelInfo = modelInfo;
        }

        /// <summary> Initializes a new instance of Model_internal. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <param name="keys"> Keys extracted by the custom model. </param>
        /// <param name="trainResult"> Custom model training result. </param>
        internal Model_internal(ModelInfo_internal modelInfo, KeysResult_internal keys, TrainResult_internal trainResult)
        {
            ModelInfo = modelInfo;
            Keys = keys;
            TrainResult = trainResult;
        }

        /// <summary> Basic custom model information. </summary>
        public ModelInfo_internal ModelInfo { get; }
        /// <summary> Keys extracted by the custom model. </summary>
        public KeysResult_internal Keys { get; }
        /// <summary> Custom model training result. </summary>
        public TrainResult_internal TrainResult { get; }
    }
}
