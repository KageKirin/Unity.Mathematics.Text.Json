using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x3JsonArrayConverter : Bool3x3JsonConverter
{
    public Bool3x3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
