using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FenixAlliance.Options
{
    public partial class PlatformOptions
    {
        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        [JsonProperty("Modules")]
        public Modules Modules { get; set; }

        [JsonProperty("Integrations")]
        public Integrations Integrations { get; set; }

        [JsonProperty("Functionalities")]
        public Functionalities Functionalities { get; set; }
    }

    public partial class Functionalities
    {
        [JsonProperty("MVC")]
        public Blazor Mvc { get; set; }

        [JsonProperty("CORS")]
        public Cors Cors { get; set; }

        [JsonProperty("HTTP")]
        public Http Http { get; set; }

        [JsonProperty("GDPR")]
        public Gdpr Gdpr { get; set; }

        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        [JsonProperty("Blazor")]
        public Blazor Blazor { get; set; }

        [JsonProperty("RestAPI")]
        public RestApi RestApi { get; set; }

        [JsonProperty("SignalR")]
        public SignalR SignalR { get; set; }

        [JsonProperty("Routing")]
        public Routing Routing { get; set; }

        [JsonProperty("Recaptcha")]
        public Recaptcha Recaptcha { get; set; }

        [JsonProperty("Endpoints")]
        public Endpoints Endpoints { get; set; }

        [JsonProperty("AutoMapper")]
        public AutoMapper AutoMapper { get; set; }

        [JsonProperty("RazorPages")]
        public RazorPages RazorPages { get; set; }

        [JsonProperty("WebSockets")]
        public WebSockets WebSockets { get; set; }

        [JsonProperty("HttpClient")]
        public HttpClient HttpClient { get; set; }

        [JsonProperty("GraphQlAPI")]
        public GraphQlApi GraphQlApi { get; set; }

        [JsonProperty("StaticFiles")]
        public StaticFiles StaticFiles { get; set; }

        [JsonProperty("AppInsights")]
        public AppInsights AppInsights { get; set; }

        [JsonProperty("CookiePolicy")]
        public CookiePolicy CookiePolicy { get; set; }

        [JsonProperty("HealthChecks")]
        public HealthChecks HealthChecks { get; set; }

        [JsonProperty("Localization")]
        public Localization Localization { get; set; }

        [JsonProperty("Redirections")]
        public Redirections Redirections { get; set; }

        [JsonProperty("IpRateLimiting")]
        public IpRateLimiting IpRateLimiting { get; set; }

        [JsonProperty("RequestLogging")]
        public RequestLogging RequestLogging { get; set; }

        [JsonProperty("ResponseCaching")]
        public ResponseCaching ResponseCaching { get; set; }

        [JsonProperty("ServerSideBlazor")]
        public ServerSideBlazor ServerSideBlazor { get; set; }

        [JsonProperty("HTTPSRedirection")]
        public HttpsRedirection HttpsRedirection { get; set; }

        [JsonProperty("CloudBlobStorage")]
        public CloudBlobStorage CloudBlobStorage { get; set; }

        [JsonProperty("ApplicationInsights")]
        public ApplicationInsights ApplicationInsights { get; set; }

        [JsonProperty("ControllersWithViews")]
        public ControllersWithViews ControllersWithViews { get; set; }

        [JsonProperty("AndyCognitiveServices")]
        public AndyCognitiveServices AndyCognitiveServices { get; set; }

        [JsonProperty("AllianceBusinessModel")]
        public AllianceBusinessModel AllianceBusinessModel { get; set; }

        [JsonProperty("AlliancePassportServices")]
        public AlliancePassportServices AlliancePassportServices { get; set; }

        [JsonProperty("StatusCodePagesWithRedirects")]
        public AndyCognitiveServices StatusCodePagesWithRedirects { get; set; }
    }

    public class RazorPages
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class AutoMapper
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class Gdpr
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class SignalR
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class WebSockets
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class HttpClient
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class StaticFiles
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class AppInsights
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class CookiePolicy
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class Localization
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class Redirections
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class RequestLogging
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class ResponseCaching
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class ServerSideBlazor
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class HttpsRedirection
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public class ControllersWithViews
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public partial class AllianceBusinessModel
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Provider")]
        public string Provider { get; set; }

        [JsonProperty("Providers")]
        public Provider[] Providers { get; set; }

        [JsonProperty("InstrumentationKey")]
        public Guid InstrumentationKey { get; set; }
    }

    public partial class Provider
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("Environment")]
        public string Environment { get; set; }

        [JsonProperty("ConnectionString")]
        public string ConnectionString { get; set; }
    }

    public partial class AlliancePassportServices
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Provider")]
        public string Provider { get; set; }

        [JsonProperty("AzureADB2C")]
        public AzureAdb2C AzureAdb2C { get; set; }

        [JsonProperty("AzureAD")]
        public AzureAd AzureAd { get; set; }

        [JsonProperty("ADSecurityGroup")]
        public AdSecurityGroup AdSecurityGroup { get; set; }
    }

    public partial class AdSecurityGroup
    {
        [JsonProperty("Admins")]
        public Guid Admins { get; set; }
    }

    public partial class AzureAd
    {
        [JsonProperty("DefaultProvider")]
        public bool DefaultProvider { get; set; }

        [JsonProperty("Instance")]
        public Uri Instance { get; set; }

        [JsonProperty("CallbackPath")]
        public string CallbackPath { get; set; }

        [JsonProperty("BaseUrl")]
        public Uri BaseUrl { get; set; }

        [JsonProperty("ClientId")]
        public Guid ClientId { get; set; }

        [JsonProperty("ClientSecret")]
        public string ClientSecret { get; set; }

        [JsonProperty("Scopes")]
        public string Scopes { get; set; }

        [JsonProperty("GraphResourceId")]
        public Uri GraphResourceId { get; set; }

        [JsonProperty("GraphScopes")]
        public string GraphScopes { get; set; }

        [JsonProperty("TenantID")]
        public Guid TenantId { get; set; }

        [JsonProperty("Tenant")]
        public string Tenant { get; set; }
    }

    public partial class AzureAdb2C
    {
        [JsonProperty("DefaultProvider")]
        public bool DefaultProvider { get; set; }

        [JsonProperty("Instance")]
        public Uri Instance { get; set; }

        [JsonProperty("InstanceId")]
        public Uri InstanceId { get; set; }

        [JsonProperty("ResourceId")]
        public Uri ResourceId { get; set; }

        [JsonProperty("ClientId")]
        public Guid ClientId { get; set; }

        [JsonProperty("TenantId")]
        public Guid TenantId { get; set; }

        [JsonProperty("Domain")]
        public string Domain { get; set; }

        [JsonProperty("SignUpSignInPolicyId")]
        public string SignUpSignInPolicyId { get; set; }

        [JsonProperty("ResetPasswordPolicyId")]
        public string ResetPasswordPolicyId { get; set; }

        [JsonProperty("EditProfilePolicyId")]
        public string EditProfilePolicyId { get; set; }

        [JsonProperty("CallbackPath")]
        public string CallbackPath { get; set; }
    }

    public partial class AndyCognitiveServices
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public partial class ApplicationInsights
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("InstrumentationKey")]
        public Guid InstrumentationKey { get; set; }
    }

    public partial class Blazor
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("MapBlazorHub")]
        public bool MapBlazorHub { get; set; }


        [JsonProperty("FallbackPages")]
        public List<BlazorFallbackPage> BlazorFallbackPages { get; set; }
    }

    public partial class BlazorFallbackPage
    {
        [JsonProperty("Pattern")]
        public bool Pattern { get; set; }

        [JsonProperty("Page")]
        public bool Page { get; set; }
    }
    public partial class Syncfusion
    {
        [JsonProperty("LicenseKey")]
        public string LicenseKey { get; set; }
    }

    public partial class CloudBlobStorage
    {
        [JsonProperty("AccountName")]
        public string AccountName { get; set; }

        [JsonProperty("UploadsBlobPath")]
        public string UploadsBlobPath { get; set; }

        [JsonProperty("UploadsFilePath")]
        public string UploadsFilePath { get; set; }

        [JsonProperty("UploadsContainerName")]
        public string UploadsContainerName { get; set; }

        [JsonProperty("AndyContainerName")]
        public string AndyContainerName { get; set; }

        [JsonProperty("ConnectionString")]
        public string ConnectionString { get; set; }

        [JsonProperty("AccountKey")]
        public string AccountKey { get; set; }
    }

    public partial class Cors
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Policies")]
        public Policy[] Policies { get; set; }
    }

    public partial class Policy
    {
    }

    public partial class Endpoints
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("MapChatHub")]
        public bool MapChatHub { get; set; }

        [JsonProperty("MapRazorPages")]
        public bool MapRazorPages { get; set; }



        [JsonProperty("AreaControllerRoutes")]
        public AreaControllerRoute[] AreaControllerRoutes { get; set; }

        [JsonProperty("ControllerRoutes")]
        public ControllerRoute[] ControllerRoutes { get; set; }
    }

    public partial class AreaControllerRoute
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("AreaName")]
        public string AreaName { get; set; }

        [JsonProperty("Pattern")]
        public string Pattern { get; set; }
    }

    public partial class ControllerRoute
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Pattern")]
        public string Pattern { get; set; }
    }

    public partial class GraphQlApi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("GraphQlMiddleware")]
        public Graph GraphQlMiddleware { get; set; }

        [JsonProperty("GraphQLPlayground")]
        public Graph GraphQlPlayground { get; set; }

        [JsonProperty("GraphiQLServer")]
        public Graph GraphiQlServer { get; set; }

        [JsonProperty("GraphQLVoyager")]
        public Graph GraphQlVoyager { get; set; }
    }

    public partial class Graph
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Path")]
        public string Path { get; set; }
    }

    public partial class HealthChecks
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("MapHealthChecks")]
        public bool MapHealthChecks { get; set; }

        [JsonProperty("HealthChecksUI")]
        public HealthChecksUi HealthChecksUi { get; set; }
    }

    public partial class HealthChecksUi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Styles")]
        public Style[] Styles { get; set; }
    }

    public partial class Style
    {
        [JsonProperty("Path")]
        public string Path { get; set; }
    }

    public partial class Http
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("HSTS")]
        public Hsts Hsts { get; set; }

        [JsonProperty("SessionConfiguration")]
        public SessionConfiguration SessionConfiguration { get; set; }

        [JsonProperty("EnableContextAccessor")]
        public bool EnableContextAccessor { get; set; }

        [JsonProperty("Headers")]
        public Header[] Headers { get; set; }

        [JsonProperty("Redirections")]
        public Redirection[] Redirections { get; set; }

        [JsonProperty("PhysicalFileProviderPath")]
        public string PhysicalFileProviderPath { get; set; }

        [JsonProperty("KestrelServerOptions")]
        public ServerOptions KestrelServerOptions { get; set; }

        [JsonProperty("IISServerOptions")]
        public ServerOptions IisServerOptions { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }

    public partial class Hsts
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("MaxAge")]
        public long MaxAge { get; set; }

        [JsonProperty("IncludeSubDomains")]
        public bool IncludeSubDomains { get; set; }
    }

    public partial class ServerOptions
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("AllowSynchronousIO")]
        public bool AllowSynchronousIo { get; set; }
    }

    public partial class Redirection
    {
        [JsonProperty("Contains")]
        public string Contains { get; set; }

        [JsonProperty("NotContains")]
        public string NotContains { get; set; }

        [JsonProperty("RedirectTo")]
        public Uri RedirectTo { get; set; }
    }

    public partial class SessionConfiguration
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("IdleTimeout")]
        public long IdleTimeout { get; set; }

        [JsonProperty("DevIdleTimeout")]
        public long DevIdleTimeout { get; set; }

        [JsonProperty("HttpOnlyCookie")]
        public bool HttpOnlyCookie { get; set; }
    }

    public partial class IpRateLimiting
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("EnableEndpointRateLimiting")]
        public bool EnableEndpointRateLimiting { get; set; }

        [JsonProperty("StackBlockedRequests")]
        public bool StackBlockedRequests { get; set; }

        [JsonProperty("RealIPHeader")]
        public string RealIpHeader { get; set; }

        [JsonProperty("ClientIdHeader")]
        public string ClientIdHeader { get; set; }

        [JsonProperty("HttpStatusCode")]
        public long HttpStatusCode { get; set; }

        [JsonProperty("GeneralRules")]
        public GeneralRule[] GeneralRules { get; set; }
    }

    public partial class GeneralRule
    {
        [JsonProperty("Endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("Period")]
        public string Period { get; set; }

        [JsonProperty("Limit")]
        public long Limit { get; set; }
    }

    public partial class Logging
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Serilog", NullValueHandling = NullValueHandling.Ignore)]
        public Serilog Serilog { get; set; }

        [JsonProperty("IncludeScopes")]
        public bool IncludeScopes { get; set; }

        [JsonProperty("LogLevel")]
        public LogLevel LogLevel { get; set; }
    }

    public partial class Routing
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("IncludeScopes")]
        public bool IncludeScopes { get; set; }

        [JsonProperty("LogLevel")]
        public LogLevel LogLevel { get; set; }
    }

    public partial class LogLevel
    {
        [JsonProperty("Default")]
        public string Default { get; set; }
    }

    public partial class Serilog
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Using")]
        public string[] Using { get; set; }

        [JsonProperty("LevelSwitches")]
        public LevelSwitches LevelSwitches { get; set; }

        [JsonProperty("MinimumLevel")]
        public MinimumLevel MinimumLevel { get; set; }

        [JsonProperty("Enrich")]
        public string[] Enrich { get; set; }

        [JsonProperty("WriteTo")]
        public WriteTo[] WriteTo { get; set; }
    }

    public partial class LevelSwitches
    {
        [JsonProperty("$controlSwitch")]
        public string ControlSwitch { get; set; }
    }

    public partial class MinimumLevel
    {
        [JsonProperty("Default")]
        public string Default { get; set; }

        [JsonProperty("Override")]
        public Override Override { get; set; }
    }

    public partial class Override
    {
        [JsonProperty("Microsoft")]
        public string Microsoft { get; set; }

        [JsonProperty("FenixAlliance.Modules")]
        public string FenixAllianceModules { get; set; }
    }

    public partial class WriteTo
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Args", NullValueHandling = NullValueHandling.Ignore)]
        public Args Args { get; set; }
    }

    public partial class Args
    {
        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public partial class Recaptcha
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("SiteKey")]
        public string SiteKey { get; set; }

        [JsonProperty("SecretKey")]
        public string SecretKey { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }
    }

    public partial class RestApi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Swagger")]
        public Swagger Swagger { get; set; }
    }

    public partial class Swagger
    {
        [JsonProperty("EnableSwagger")]
        public bool EnableSwagger { get; set; }

        [JsonProperty("EnableSwaggerUI")]
        public bool EnableSwaggerUi { get; set; }

        [JsonProperty("IncludeXmlComments")]
        public bool IncludeXmlComments { get; set; }

        [JsonProperty("DefaultModelExpandDepth")]
        public long DefaultModelExpandDepth { get; set; }

        [JsonProperty("DefaultModelsExpandDepth")]
        public long DefaultModelsExpandDepth { get; set; }

        [JsonProperty("SwaggerSpecs")]
        public SwaggerSpec[] SwaggerSpecs { get; set; }

        [JsonProperty("OAuth")]
        public OAuth OAuth { get; set; }

        [JsonProperty("EnableSwaggerFilter")]
        public bool EnableSwaggerFilter { get; set; }

        [JsonProperty("DescribeAllEnumsAsStrings")]
        public bool DescribeAllEnumsAsStrings { get; set; }

        [JsonProperty("UseInlineDefinitionsForEnums")]
        public bool UseInlineDefinitionsForEnums { get; set; }

        [JsonProperty("OAuthAdditionalQueryStringParams")]
        public Header[] OAuthAdditionalQueryStringParams { get; set; }

        [JsonProperty("RoutePrefix")]
        public string RoutePrefix { get; set; }

        [JsonProperty("JavaScripts")]
        public Style[] JavaScripts { get; set; }

        [JsonProperty("CssStyles")]
        public Style[] CssStyles { get; set; }
    }

    public partial class OAuth
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("OAuthClientId")]
        public Guid OAuthClientId { get; set; }

        [JsonProperty("OAuth2RedirectUrl")]
        public Uri OAuth2RedirectUrl { get; set; }

        [JsonProperty("OAuthAdditionalQueryStringParams")]
        public OAuthAdditionalQueryStringParam[] OAuthAdditionalQueryStringParams { get; set; }
    }

    public partial class OAuthAdditionalQueryStringParam
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class SwaggerSpec
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("TermsOfService")]
        public Uri TermsOfService { get; set; }

        [JsonProperty("SwaggerEndpoint")]
        public License SwaggerEndpoint { get; set; }

        [JsonProperty("OpenApiContact")]
        public OpenApiContact OpenApiContact { get; set; }

        [JsonProperty("License")]
        public License License { get; set; }
    }

    public partial class OpenExchangeRates
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("AppID")]
        public string AppID { get; set; }
    }
    public partial class License
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }
    }

    public partial class OpenApiContact
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Url")]
        public Uri Url { get; set; }
    }

    public partial class Integrations
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("ABS")]
        public Abs Abs { get; set; }

        [JsonProperty("DocuSign")]
        public DocuSign DocuSign { get; set; }

        [JsonProperty("AzureRateCardsAPI")]
        public AzureRateCardsApi AzureRateCardsApi { get; set; }

        [JsonProperty("GoogleMyBusiness")]
        public GoogleMyBusiness GoogleMyBusiness { get; set; }

        [JsonProperty("GoogleAPIs")]
        public GoogleApIs GoogleApIs { get; set; }

        [JsonProperty("MercadoLibre")]
        public MercadoLibre MercadoLibre { get; set; }

        [JsonProperty("ePaycoSecrets")]
        public EPaycoSecrets EPaycoSecrets { get; set; }

        [JsonProperty("Facebook")]
        public Facebook Facebook { get; set; }

        [JsonProperty("Sendgrid")]
        public Sendgrid Sendgrid { get; set; }

        [JsonProperty("Wordpress")]
        public Wordpress Wordpress { get; set; }

        [JsonProperty("GodaddyApi")]
        public GodaddyApi GodaddyApi { get; set; }

        [JsonProperty("Plesk")]
        public Plesk Plesk { get; set; }

        [JsonProperty("Syncfusion")]
        public Syncfusion Syncfusion { get; set; }

        [JsonProperty("OpenExchangeRates")]
        public OpenExchangeRates OpenExchangeRates { get; set; }
    }

    public partial class Abs
    {
        [JsonProperty("AppID")]
        public string AppId { get; set; }

        [JsonProperty("TenantID")]
        public string TenantId { get; set; }

        [JsonProperty("PublicKey")]
        public string PublicKey { get; set; }

        [JsonProperty("PrivateKey")]
        public string PrivateKey { get; set; }

        [JsonProperty("Enable")]
        public bool Enable { get; set; }
    }

    public partial class AzureRateCardsApi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Resource")]
        public Uri Resource { get; set; }

        [JsonProperty("GrantType")]
        public string GrantType { get; set; }

        [JsonProperty("SubscriptionID")]
        public Guid SubscriptionId { get; set; }

        [JsonProperty("TenantID")]
        public Guid TenantId { get; set; }

        [JsonProperty("ClientId")]
        public Guid ClientId { get; set; }

        [JsonProperty("ClientSecret")]
        public Guid ClientSecret { get; set; }
    }

    public partial class DocuSign
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("ClientId")]
        public Guid ClientId { get; set; }

        [JsonProperty("ClientSecret")]
        public Guid ClientSecret { get; set; }

        [JsonProperty("AuthorizationEndpoint")]
        public Uri AuthorizationEndpoint { get; set; }

        [JsonProperty("TokenEndpoint")]
        public Uri TokenEndpoint { get; set; }

        [JsonProperty("UserInformationEndpoint")]
        public Uri UserInformationEndpoint { get; set; }

        [JsonProperty("AppUrl")]
        public Uri AppUrl { get; set; }

        [JsonProperty("SignerEmail")]
        public string SignerEmail { get; set; }

        [JsonProperty("SignerName")]
        public string SignerName { get; set; }

        [JsonProperty("GatewayAccountId")]
        public string GatewayAccountId { get; set; }

        [JsonProperty("GatewayName")]
        public string GatewayName { get; set; }

        [JsonProperty("GatewayDisplayName")]
        public string GatewayDisplayName { get; set; }
    }

    public partial class EPaycoSecrets
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("ApiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("ApiSecret")]
        public string ApiSecret { get; set; }
    }

    public partial class Facebook
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("AppID")]
        public string AppId { get; set; }

        [JsonProperty("AppSecret")]
        public string AppSecret { get; set; }

        [JsonProperty("InstagramAppID")]
        public string InstagramAppId { get; set; }

        [JsonProperty("InstagramAppSecret")]
        public string InstagramAppSecret { get; set; }

        [JsonProperty("MarketingAPI_Token")]
        public string MarketingApiToken { get; set; }

        [JsonProperty("MarketingAPI_Token_Sandbox")]
        public string MarketingApiTokenSandbox { get; set; }
    }

    public partial class GodaddyApi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("OTE")]
        public Ote Ote { get; set; }

        [JsonProperty("PROD")]
        public Ote Prod { get; set; }
    }

    public partial class Ote
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Secret")]
        public string Secret { get; set; }
    }

    public partial class GoogleApIs
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("API_Key")]
        public string ApiKey { get; set; }
    }

    public partial class GoogleMyBusiness
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("auth_uri")]
        public Uri AuthUri { get; set; }

        [JsonProperty("token_uri")]
        public Uri TokenUri { get; set; }

        [JsonProperty("auth_provider_x509_cert_url")]
        public Uri AuthProviderX509CertUrl { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("redirect_uris")]
        public Uri[] RedirectUris { get; set; }
    }

    public partial class MercadoLibre
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("AppID")]
        public string AppId { get; set; }

        [JsonProperty("SecretKey")]
        public string SecretKey { get; set; }
    }

    public partial class Plesk
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Master")]
        public Master Master { get; set; }
    }

    public partial class Master
    {
        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }

    public partial class Sendgrid
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("ApiKey")]
        public string ApiKey { get; set; }
    }

    public partial class Wordpress
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("Hosting")]
        public Hosting Hosting { get; set; }
    }

    public partial class Hosting
    {
        [JsonProperty("WooCommerce")]
        public WooCommerce WooCommerce { get; set; }
    }

    public partial class WooCommerce
    {
        [JsonProperty("ConsumerKey")]
        public string ConsumerKey { get; set; }

        [JsonProperty("ConsumerSecret")]
        public string ConsumerSecret { get; set; }

        [JsonProperty("HooksSecret")]
        public string HooksSecret { get; set; }
    }

    public partial class Modules
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("CognitiveServices")]
        public CognitiveServices CognitiveServices { get; set; }

        [JsonProperty("Workplace")]
        public Workplace Workplace { get; set; }

        [JsonProperty("Workflows")]
        public Workflows Workflows { get; set; }

        [JsonProperty("Healthcare")]
        public Healthcare Healthcare { get; set; }
    }

    public partial class CognitiveServices
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("SmartAdaptiveRecommendations")]
        public AndyCognitiveServices SmartAdaptiveRecommendations { get; set; }

        [JsonProperty("ComputerVisionAPI")]
        public ComputerVisionApi ComputerVisionApi { get; set; }

        [JsonProperty("FaceAPI")]
        public ComputerVisionApi FaceApi { get; set; }

        [JsonProperty("ContentModeration")]
        public ComputerVisionApi ContentModeration { get; set; }

        [JsonProperty("TextAnalytics")]
        public ComputerVisionApi TextAnalytics { get; set; }

        [JsonProperty("IntelligentSearch")]
        public ComputerVisionApi IntelligentSearch { get; set; }
    }

    public partial class ComputerVisionApi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("ServiceKey")]
        public string ServiceKey { get; set; }

        [JsonProperty("ServiceEndPoint")]
        public Uri ServiceEndPoint { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class Healthcare
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("FhirServer")]
        public FhirServer FhirServer { get; set; }
    }

    public partial class FhirServer
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("StorageSettings")]
        public StorageSettings StorageSettings { get; set; }
    }

    public partial class StorageSettings
    {
        [JsonProperty("ConnectionString")]
        public string ConnectionString { get; set; }
    }

    public partial class Workflows
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("EnableHttpActivities")]
        public bool EnableHttpActivities { get; set; }

        [JsonProperty("Http")]
        public HttpClass Http { get; set; }

        [JsonProperty("Smtp")]
        public Smtp Smtp { get; set; }

        [JsonProperty("Timers")]
        public Timers Timers { get; set; }
    }

    public partial class HttpClass
    {
        [JsonProperty("BaseUrl")]
        public Uri BaseUrl { get; set; }
    }

    public partial class Smtp
    {
        [JsonProperty("Host")]
        public string Host { get; set; }

        [JsonProperty("Port")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Port { get; set; }
    }

    public partial class Timers
    {
        [JsonProperty("SweepInterval")]
        public string SweepInterval { get; set; }
    }

    public partial class Workplace
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("WOPI")]
        public Wopi Wopi { get; set; }
    }

    public partial class Wopi
    {
        [JsonProperty("Enable")]
        public bool Enable { get; set; }

        [JsonProperty("StorageProviderOptions")]
        public StorageProviderOptions StorageProviderOptions { get; set; }

        [JsonProperty("HostStorageProviderOptions")]
        public StorageProviderOptions HostStorageProviderOptions { get; set; }

        [JsonProperty("UseCobalt")]
        public bool UseCobalt { get; set; }

        [JsonProperty("StorageProviderAssemblyName")]
        public string StorageProviderAssemblyName { get; set; }

        [JsonProperty("HostUrl")]
        public Uri HostUrl { get; set; }

        [JsonProperty("ClientUrl")]
        public Uri ClientUrl { get; set; }
    }

    public partial class StorageProviderOptions
    {
        [JsonProperty("RootPath")]
        public string RootPath { get; set; }
    }

    public partial class PlatformOptions
    {
        public static PlatformOptions FromJson(string json) => JsonConvert.DeserializeObject<PlatformOptions>(json, FenixAlliance.Options.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PlatformOptions self) => JsonConvert.SerializeObject(self, FenixAlliance.Options.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
