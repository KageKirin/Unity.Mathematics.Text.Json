using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x4JsonArrayConverter : Bool3x4JsonConverter
{
    public Bool3x4JsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
