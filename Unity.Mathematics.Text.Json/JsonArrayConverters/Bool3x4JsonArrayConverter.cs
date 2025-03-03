using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x4JsonArrayConverter : Bool3x4JsonConverter
{
    public Bool3x4JsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
