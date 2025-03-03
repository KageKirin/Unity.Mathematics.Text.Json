using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3JsonObjectConverter : Bool3JsonConverter
{
    public Bool3JsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
