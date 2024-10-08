// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using VoyadoEngage.Http;
using VoyadoEngage.Http.Exceptions;
using VoyadoEngage.Http.Extensions;
using VoyadoEngage.Http.Serialization;
using VoyadoEngage.Models;

namespace VoyadoEngage.Services;

public class ConsentsService : BaseService
{
    internal ConsentsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Get all consents definitions
    ///
    /// Example of metaData for a Consent:```
    ///
    /// "metaData": {
    ///   "conditionText": {
    ///     "sv-SE": "Svensk villkorstext",
    ///     "en-GB": "English text to show for condition"
    ///   },
    ///   "displayText": {
    ///     "sv-SE": "Svensk text att visa",
    ///     "en-GB": "English text to display"
    ///   },
    ///   "linkText": {
    ///     "sv-SE": "Svensk text att visa pÃƒÆ’Ã‚Â¥ lÃƒÆ’Ã‚Â¤nk",
    ///     "en-GB": "English text to show on link"
    ///   }
    /// }```
    /// </summary>
    public async Task<List<ApiConsentDefinition>> ConsentsGetConsentsAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "api/v2/consents").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<List<ApiConsentDefinition>>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
