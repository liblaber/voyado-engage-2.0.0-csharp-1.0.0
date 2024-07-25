// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using VoyadoEngage.Http;
using VoyadoEngage.Http.Serialization;
using VoyadoEngage.Models;

namespace VoyadoEngage.Services;

public class BisnodeService : BaseService
{
    internal BisnodeService(HttpClient httpClient)
        : base(httpClient) { }

    /// <param name="contactId">Contact identifier</param>
    public async Task<List<EnrichmentVariableGroup>> BisnodeVGetEnrichmentsAsync(
        string contactId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(contactId, nameof(contactId));

        var request = new RequestBuilder(HttpMethod.Get, "api/v2/bisnode/{contactId}/enrichments")
            .SetPathParameter("contactId", contactId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<List<EnrichmentVariableGroup>>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
