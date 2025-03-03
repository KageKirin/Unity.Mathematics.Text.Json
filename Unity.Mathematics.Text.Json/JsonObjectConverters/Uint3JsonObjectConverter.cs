using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint3JsonObjectConverter : Uint3JsonConverter
{
    public Uint3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
