using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class QuaternionJsonObjectConverter : QuaternionJsonConverter
{
    public QuaternionJsonObjectConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartObject //!< write as object
        ) { }
}
