namespace Fernweh.KernelShared.Configuration;
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
    

    public string YmiApiUrl { get; set; } = "";
    public string YmiApiVersion { get; set; } = "";
    public string YmiApiName { get; set; } = "ymi_primary_api";
    
    public string YmiAdminApiUrl { get; set; } = "";
    public string YmiAdminApiVersion { get; set; } = "";
    public string YmiAdminApiName { get; set; } = "ymi_primary_admin_api";

    
}
