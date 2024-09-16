// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using VoyadoEngage.Http;
using VoyadoEngage.Http.Exceptions;
using VoyadoEngage.Http.Extensions;
using VoyadoEngage.Http.Serialization;

namespace VoyadoEngage.Services;

public class ContactoverviewService : BaseService
{
    internal ContactoverviewService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Get all information about a single contact by specifying either:
    /// - contactId
    /// - email and contactType
    /// - socialSecurityNumber and contactType
    /// - mobilePhone and contactType
    /// - customKey and contactType (the customKey must be configured by your supplier)
    /// - any and contactType - the any field can contain email, socialSecurityNumber, mobilePhone or the custom key (and are checked in that order)
    ///
    /// The dynamic fields of the response depend on your current Voyado configuration.
    /// </summary>
    public async Task<object> ContactOverviewGetContactOverviewAsyncAsync(
        string? contactType = null,
        string? contactId = null,
        string? email = null,
        string? socialSecurityNumber = null,
        string? mobilePhone = null,
        string? customKey = null,
        string? any = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "api/v2/contactoverview")
            .SetOptionalQueryParameter("contactType", contactType)
            .SetOptionalQueryParameter("contactId", contactId)
            .SetOptionalQueryParameter("email", email)
            .SetOptionalQueryParameter("socialSecurityNumber", socialSecurityNumber)
            .SetOptionalQueryParameter("mobilePhone", mobilePhone)
            .SetOptionalQueryParameter("customKey", customKey)
            .SetOptionalQueryParameter("any", any)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
