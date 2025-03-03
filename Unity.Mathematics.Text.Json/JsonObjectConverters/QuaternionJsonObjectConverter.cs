using System.Text.Json;

namespace Unity.Mathematics.Text.Json;

public class QuaternionJsonObjectConverter : QuaternionJsonConverter
{
    public QuaternionJsonObjectConverter()
        : base(
            JsonTokenType.None, //!< compatible read
            JsonTokenType.StartObject //!< write as object
        ) { }
}
