namespace YMI.YmiApplication.Shared.Configuration;
public class Endpoints
{
    public string IdentityEndpointUrl { get; set; } = "";
    public string IdentityValidIssuer { get; set; } = "";

    public string PubsubEndpointUrl { get; set; } = "";

    public string YmiApiUrl { get; set; } = "";
    public string YmiApiVersion { get; set; } = "";
    public string YmiApiName { get; set; } = "ymi_primary_api";
    
    public string YmiAdminApiUrl { get; set; } = "";
    public string YmiAdminApiVersion { get; set; } = "";
    public string YmiAdminApiName { get; set; } = "ymi_primary_admin_api";
}
