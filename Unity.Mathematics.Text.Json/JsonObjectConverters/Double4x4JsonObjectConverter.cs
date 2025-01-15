using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Double4x4JsonObjectConverter : Double4x4JsonConverter
{
    public Double4x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
