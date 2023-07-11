namespace AccountModuleCore.TestData.Entities;

public static class KnownAccountProfileTestData {
    
    public readonly static JamesKnownAccountProfileId = new Guid("00000c7a-0000-4b7a-9a8b-2b1e8f0d7a8b");
    public readonly static KpKnownAccountProfileId = new Guid("11111c7a-1111-4b7a-9a8b-2b1e8f0d7a8b");
    
    public readonly static KnownAccountProfile JamesAccountProfile;
    public readonly static KnownAccountProfile KpAccountProfile;

    public readonly static IEnumerable<KnownAccountProfile> AllKnownAccountProfiles;

    static KnownAccountProfileTestData() {
        JamesAccountProfile = new(JamesAccountProfileId);
        KpAccountProfile = new (KpAccountProfileId);
        
        AllKnownAccountProfiles = new List<AllKnownAccountProfiles> {
            JamesAccountProfile,
            KpAccountProfile
        }
        .AsReadOnly();
    }
}
