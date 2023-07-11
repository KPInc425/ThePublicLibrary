namespace AccountModuleCore.TestData.Entities;

public static class KnownAccountSubscriptionTestData {
    
    public readonly static JamesKnownAccountSubscriptionId = new Guid("00000c7a-0000-4b7a-9a8b-2b1e8f0d7a8b");
    public readonly static KpKnownAccountSubscriptionId = new Guid("11111c7a-1111-4b7a-9a8b-2b1e8f0d7a8b");
    
    public readonly static KnownAccountSubscription JamesAccountSubscription;
    public readonly static KnownAccountSubscription KpAccountSubscription;

    public readonly static IEnumerable<KnownAccountSubscription> AllKnownAccountSubscriptions;

    static KnownAccountSubscriptionTestData() {
        JamesAccountSubscription = new(JamesAccountSubscriptionId);
        KpAccountSubscription = new (KpAccountSubscriptionId);
        
        AllKnownAccountSubscriptions = new List<AllKnownAccountSubscriptions> {
            JamesAccountSubscription,
            KpAccountSubscription
        }
        .AsReadOnly();
    }
}
