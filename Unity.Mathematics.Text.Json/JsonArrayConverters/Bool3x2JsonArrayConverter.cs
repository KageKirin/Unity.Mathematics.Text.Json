using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x2JsonArrayConverter : Bool3x2JsonConverter
{
    public Bool3x2JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
