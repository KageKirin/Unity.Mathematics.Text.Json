using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x3JsonObjectConverter : Bool3x3JsonConverter
{
    public Bool3x3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
