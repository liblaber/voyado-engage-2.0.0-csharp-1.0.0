// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using VoyadoEngage.Http;
using VoyadoEngage.Http.Serialization;
using VoyadoEngage.Models;

namespace VoyadoEngage.Services;

public class ChallengesService : BaseService
{
    internal ChallengesService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Get an challenge assignment by id.</summary>
    /// <param name="id">Assignment id</param>
    public async Task<ChallengeAssignmentModel> ChallengeGetChallengeByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(id, nameof(id));

        var request = new RequestBuilder(HttpMethod.Get, "api/v2/challenges/{id}")
            .SetPathParameter("id", id)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ChallengeAssignmentModel>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get a challenge definition by id.</summary>
    /// <param name="id">Definition id</param>
    public async Task<ChallengeDefinitionModel> ChallengeGetChallengeDefinitionByIdAsync(
        string id,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(id, nameof(id));

        var request = new RequestBuilder(HttpMethod.Get, "api/v2/challenges/definitions/{id}")
            .SetPathParameter("id", id)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ChallengeDefinitionModel>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Get a list of all the challenge definitions.</summary>
    /// <param name="offset">Defaults to 0</param>
    /// <param name="count">Defaults to 100</param>
    /// <param name="status">All, Active, Draft or Ended. If not specified it will default to All</param>
    public async Task<ChallengeDefinitionModelsResult> ChallengeGetChallengeDefinitionsAsync(
        long? offset = null,
        long? count = null,
        ChallengeGetChallengeDefinitionsStatus? status = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "api/v2/challenges/definitions")
            .SetOptionalQueryParameter("offset", offset)
            .SetOptionalQueryParameter("count", count)
            .SetOptionalQueryParameter("status", status?.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ChallengeDefinitionModelsResult>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Search for challenges for a contact.</summary>
    /// <param name="contactId">Contact id</param>
    /// <param name="definitionId">Definition id - Optional to limit to a certain challenge definition</param>
    /// <param name="offset">Defaults to 0</param>
    /// <param name="count">Defaults to 100</param>
    /// <param name="filter">All, Active, Completed or NotCompleted. If not specified it will default to All</param>
    public async Task<ChallengeAssignmentModelsResult> ChallengeGetChallengesAsync(
        string contactId,
        string? definitionId = null,
        long? offset = null,
        long? count = null,
        ChallengeGetChallengesFilter? filter = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(contactId, nameof(contactId));

        var request = new RequestBuilder(HttpMethod.Get, "api/v2/challenges")
            .SetQueryParameter("contactId", contactId)
            .SetOptionalQueryParameter("definitionId", definitionId)
            .SetOptionalQueryParameter("offset", offset)
            .SetOptionalQueryParameter("count", count)
            .SetOptionalQueryParameter("filter", filter?.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ChallengeAssignmentModelsResult>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Send in a list of checkpoints to be assigned to a some challenge for a number of contacts,
    /// the endpoint will able to take max 1000 checkpoint rows.
    ///
    /// ### The following fields should be provided:
    ///
    /// - definitionId: Must be a Guid
    /// - contactId: Must be a Guid
    /// - checkPointAmount: Number of checkpoints to assign to the challenge
    ///
    /// ### Important info:
    /// If some rows are not correct it will still result in an accepted response code and be skipped. Please
    /// check the response for NotAccepted items
    /// </summary>
    /// <param name="input">The JSON object which contains the checkpoint transactions.</param>
    public async Task<AddCheckpointToChallengeAssignmentResult> ChallengeAddChallengeCheckPointsAsync(
        List<ChallengeCheckPointDto> input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "api/v2/challenges/checkpoints")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<AddCheckpointToChallengeAssignmentResult>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Will assign the challenge for the contact and return true. If the contact already
    /// has been assigned for the challenge it will also return true.
    /// </summary>
    /// <param name="id">Definition id</param>
    /// <param name="contactId">Contact id</param>
    public async Task<bool> ChallengeConsentAsync(
        string id,
        string contactId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(id, nameof(id));
        ArgumentNullException.ThrowIfNull(contactId, nameof(contactId));

        var request = new RequestBuilder(
            HttpMethod.Post,
            "api/v2/challenges/definitions/{id}/assign"
        )
            .SetPathParameter("id", id)
            .SetQueryParameter("contactId", contactId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
            .Content.ReadFromJsonAsync<bool>(_jsonSerializerOptions, cancellationToken)
            .ConfigureAwait(false);
    }
}
