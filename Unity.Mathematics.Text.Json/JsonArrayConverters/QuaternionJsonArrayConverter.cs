using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class QuaternionJsonArrayConverter : QuaternionJsonConverter
{
    public QuaternionJsonArrayConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartArray //!< write as array
        ) { }
}
