using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class Bool3JsonObjectConverter : Bool3JsonConverter
{
    public Bool3JsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
