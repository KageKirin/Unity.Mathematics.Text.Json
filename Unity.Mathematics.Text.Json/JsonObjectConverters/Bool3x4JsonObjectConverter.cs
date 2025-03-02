using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3x4JsonObjectConverter : Bool3x4JsonConverter
{
    public Bool3x4JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
