using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x2JsonObjectConverter : Bool3x2JsonConverter
{
    public Bool3x2JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
