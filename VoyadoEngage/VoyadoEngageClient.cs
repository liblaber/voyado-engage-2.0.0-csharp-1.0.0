// This file was generated by liblab | https://liblab.com/

using VoyadoEngage.Config;
using VoyadoEngage.Http.Handlers;
using VoyadoEngage.Services;
using Environment = VoyadoEngage.Http.Environment;

namespace VoyadoEngage;

public class VoyadoEngageClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly TokenHandler _accessTokenHandler;

    public AchievementsService Achievements { get; private set; }
    public AutomationService Automation { get; private set; }
    public BisnodeService Bisnode { get; private set; }
    public BonuschecksService Bonuschecks { get; private set; }
    public ChallengesService Challenges { get; private set; }
    public ConsentsService Consents { get; private set; }
    public ContactoverviewService Contactoverview { get; private set; }
    public ContactsService Contacts { get; private set; }
    public InteractionsService Interactions { get; private set; }
    public InteractionschemasService Interactionschemas { get; private set; }
    public InventoryService Inventory { get; private set; }
    public MemberstatusService Memberstatus { get; private set; }
    public OrdersService Orders { get; private set; }
    public PersonlookupService Personlookup { get; private set; }
    public PointAccountsService PointAccounts { get; private set; }
    public PosoffersService Posoffers { get; private set; }
    public PromotionsService Promotions { get; private set; }
    public SmsService Sms { get; private set; }
    public StoresService Stores { get; private set; }
    public TargetAudiencesService TargetAudiences { get; private set; }
    public TrackingService Tracking { get; private set; }
    public TransactionsService Transactions { get; private set; }

    public VoyadoEngageClient(VoyadoEngageConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _accessTokenHandler = new TokenHandler(retryHandler)
        {
            Header = "Authorization",
            Prefix = "Bearer",
            Token = config?.AccessToken
        };

        _httpClient = new HttpClient(_accessTokenHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

        Achievements = new AchievementsService(_httpClient);
        Automation = new AutomationService(_httpClient);
        Bisnode = new BisnodeService(_httpClient);
        Bonuschecks = new BonuschecksService(_httpClient);
        Challenges = new ChallengesService(_httpClient);
        Consents = new ConsentsService(_httpClient);
        Contactoverview = new ContactoverviewService(_httpClient);
        Contacts = new ContactsService(_httpClient);
        Interactions = new InteractionsService(_httpClient);
        Interactionschemas = new InteractionschemasService(_httpClient);
        Inventory = new InventoryService(_httpClient);
        Memberstatus = new MemberstatusService(_httpClient);
        Orders = new OrdersService(_httpClient);
        Personlookup = new PersonlookupService(_httpClient);
        PointAccounts = new PointAccountsService(_httpClient);
        Posoffers = new PosoffersService(_httpClient);
        Promotions = new PromotionsService(_httpClient);
        Sms = new SmsService(_httpClient);
        Stores = new StoresService(_httpClient);
        TargetAudiences = new TargetAudiencesService(_httpClient);
        Tracking = new TrackingService(_httpClient);
        Transactions = new TransactionsService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    /// <summary>
    /// Sets the access token for the entire SDK.
    /// </summary>
    public void SetAccessToken(string token)
    {
        _accessTokenHandler.Token = token;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
