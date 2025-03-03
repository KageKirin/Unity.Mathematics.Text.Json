using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x2JsonArrayConverter : Bool3x2JsonConverter
{
    public Bool3x2JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
