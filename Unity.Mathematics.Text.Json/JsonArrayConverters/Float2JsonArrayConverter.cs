using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Unity.Mathematics;

namespace Unity.Mathematics.Text.Json;

public class Float2JsonArrayConverter : Float2JsonConverter
{
    public Float2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
