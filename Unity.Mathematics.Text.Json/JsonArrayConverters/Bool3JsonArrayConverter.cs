using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3JsonArrayConverter : Bool3JsonConverter
{
    public Bool3JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
