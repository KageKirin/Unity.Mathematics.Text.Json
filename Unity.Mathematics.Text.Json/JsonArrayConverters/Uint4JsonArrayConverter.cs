using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Uint4JsonArrayConverter : Uint4JsonConverter
{
    public Uint4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
