// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class ProactiveEngagementFactory(string resourceName = null, Action<Humidifier.Shield.ProactiveEngagement> factoryAction = null) : ResourceFactory<Humidifier.Shield.ProactiveEngagement>(resourceName)
{

    internal List<InnerProactiveEngagementEmergencyContactFactory> EmergencyContactListFactories { get; set; } = [];

    protected override Humidifier.Shield.ProactiveEngagement Create()
    {
        var proactiveEngagementResult = CreateProactiveEngagement();
        factoryAction?.Invoke(proactiveEngagementResult);

        return proactiveEngagementResult;
    }

    private Humidifier.Shield.ProactiveEngagement CreateProactiveEngagement()
    {
        var proactiveEngagementResult = new Humidifier.Shield.ProactiveEngagement
        {
            GivenName = InputResourceName,
        };

        return proactiveEngagementResult;
    }
    public override void CreateChildren(Humidifier.Shield.ProactiveEngagement result)
    {
        base.CreateChildren(result);

        result.EmergencyContactList = EmergencyContactListFactories.Any() ? EmergencyContactListFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ProactiveEngagementFactoryExtensions
{
    public static CombinedResult<ProactiveEngagementFactory, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList(this ProactiveEngagementFactory parentFactory, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null)
    {
        var factory = new InnerProactiveEngagementEmergencyContactFactory(subFactoryAction);
        parentFactory.EmergencyContactListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProactiveEngagementFactory, T1, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1>(this CombinedResult<ProactiveEngagementFactory, T1> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProactiveEngagementFactory, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1>(this CombinedResult<T1, ProactiveEngagementFactory> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProactiveEngagementFactory, T1, T2, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2>(this CombinedResult<ProactiveEngagementFactory, T1, T2> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProactiveEngagementFactory, T2, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2>(this CombinedResult<T1, ProactiveEngagementFactory, T2> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProactiveEngagementFactory, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2>(this CombinedResult<T1, T2, ProactiveEngagementFactory> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProactiveEngagementFactory, T1, T2, T3, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3>(this CombinedResult<ProactiveEngagementFactory, T1, T2, T3> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProactiveEngagementFactory, T2, T3, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3>(this CombinedResult<T1, ProactiveEngagementFactory, T2, T3> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProactiveEngagementFactory, T3, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3>(this CombinedResult<T1, T2, ProactiveEngagementFactory, T3> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProactiveEngagementFactory, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProactiveEngagementFactory> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProactiveEngagementFactory, T1, T2, T3, T4, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3, T4>(this CombinedResult<ProactiveEngagementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProactiveEngagementFactory, T2, T3, T4, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3, T4>(this CombinedResult<T1, ProactiveEngagementFactory, T2, T3, T4> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProactiveEngagementFactory, T3, T4, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProactiveEngagementFactory, T3, T4> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProactiveEngagementFactory, T4, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProactiveEngagementFactory, T4> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProactiveEngagementFactory, InnerProactiveEngagementEmergencyContactFactory> WithEmergencyContactList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProactiveEngagementFactory> combinedResult, Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmergencyContactList(combinedResult.T5, subFactoryAction));
}
