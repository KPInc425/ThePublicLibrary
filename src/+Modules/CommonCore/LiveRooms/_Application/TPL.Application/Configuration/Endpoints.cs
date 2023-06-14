namespace TPL.Application.Configuration;
public class Endpoints
{
    public string IdentityEndpointUrl { get; set; } = "";
    public string IdentityValidIssuer { get; set; } = "";
    public string PubsubEndpointUrl { get; set; } = "";

    public string PrimaryApiUrl { get; set; } = "";
    public string PrimaryApiVersion { get; set; } = "";
    public string PrimaryApiName { get; set; } = "tpl_primary_api";
    public string PrimaryAdminApiUrl { get; set; } = "";
    public string PrimaryAdminApiVersion { get; set; } = "";
    public string PrimaryAdminApiName { get; set; } = "tpl_primary_admin_api";
}
