namespace YMI.YmiApplication.Shared.Configuration;
public class AppSettings  { 
    public FeatureFlags FeatureFlags { get; set; } = new();
    public Endpoints Endpoints { get; set; } = new();
}
