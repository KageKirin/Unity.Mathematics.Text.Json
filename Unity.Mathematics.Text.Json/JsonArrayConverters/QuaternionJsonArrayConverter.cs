using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class QuaternionJsonArrayConverter : QuaternionJsonConverter
{
    public QuaternionJsonArrayConverter()
        : base(
            readerTokenType: JsonTokenType.None, //!< compatible read
            writerTokenType: JsonTokenType.StartArray //!< write as array
        ) { }
}
