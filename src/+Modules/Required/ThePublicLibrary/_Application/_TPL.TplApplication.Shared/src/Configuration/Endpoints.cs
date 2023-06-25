namespace TPL.TplApplication.Shared.Configuration;
public class Endpoints
{
    public string IdentityEndpointUrl { get; set; } = "";
    public string IdentityValidIssuer { get; set; } = "";

    public string PubsubEndpointUrl { get; set; } = "";

    public string TplApiUrl { get; set; } = "";
    public string TplApiVersion { get; set; } = "";
    public string TplApiName { get; set; } = "tpl_primary_api";
    
    public string TplAdminApiUrl { get; set; } = "";
    public string TplAdminApiVersion { get; set; } = "";
    public string TplAdminApiName { get; set; } = "tpl_primary_admin_api";
}
