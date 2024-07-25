// This file was generated by liblab | https://liblab.com/

using System.Text.Json;
using VoyadoEngage.Json;

namespace VoyadoEngage.Services;

public class BaseService
{
    protected readonly HttpClient _httpClient;
    protected readonly JsonSerializerOptions _jsonSerializerOptions;

    public BaseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            Converters = { new ValueEnumJsonConverterFactory() }
        };
    }
}
