using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3JsonArrayConverter : Bool3JsonConverter
{
    public Bool3JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
