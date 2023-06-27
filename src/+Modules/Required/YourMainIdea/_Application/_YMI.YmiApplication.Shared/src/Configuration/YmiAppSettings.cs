namespace YMI.YmiApplication.Shared.Configuration;
public class AppSettings  { 
    public YmiFeatureFlags YmiFeatureFlags { get; set; } = new();
    public YmiEndpoints YmiEndpoints { get; set; } = new();
}
