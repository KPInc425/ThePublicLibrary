namespace Fernweh.KernelShared.Configuration;
public class Endpoints
{
    public string IdentityEndpointUrl { get; set; } = "";
    public string IdentityValidIssuer { get; set; } = "";

    public string PubsubEndpointUrl { get; set; } = "";

    public string AccountAdminApiUrl { get; set; } = "";
    public string AccountAdminApiVersion { get; set; } = "";
    public string AccountAdminApiName { get; set; } = "tpl_admin_api";
        
    public string TplApiUrl { get; set; } = "";
    public string TplApiVersion { get; set; } = "";
    public string TplApiName { get; set; } = "tpl_api";
    
    public string TplAdminApiUrl { get; set; } = "";
    public string TplAdminApiVersion { get; set; } = "";
    public string TplAdminApiName { get; set; } = "tpl_admin_api";
    
    public string YmiApiUrl { get; set; } = "";
    public string YmiApiVersion { get; set; } = "";
    public string YmiApiName { get; set; } = "ymi_api";
    
    public string YmiAdminApiUrl { get; set; } = "";
    public string YmiAdminApiVersion { get; set; } = "";
    public string YmiAdminApiName { get; set; } = "ymi_admin_api";


    public string WskApiUrl { get; set; } = "";
    public string WskApiVersion { get; set; } = "";
    public string WskApiName { get; set; } = "wsk_api";
    
    public string WskAdminApiUrl { get; set; } = "";
    public string WskAdminApiVersion { get; set; } = "";
    public string WskAdminApiName { get; set; } = "wsk_admin_api";

    
}
