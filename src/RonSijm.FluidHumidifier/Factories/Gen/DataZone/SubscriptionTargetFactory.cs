// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class SubscriptionTargetFactory(string resourceName = null, Action<Humidifier.DataZone.SubscriptionTarget> factoryAction = null) : ResourceFactory<Humidifier.DataZone.SubscriptionTarget>(resourceName)
{

    internal List<InnerSubscriptionTargetSubscriptionTargetFormFactory> SubscriptionTargetConfigFactories { get; set; } = [];

    protected override Humidifier.DataZone.SubscriptionTarget Create()
    {
        var subscriptionTargetResult = CreateSubscriptionTarget();
        factoryAction?.Invoke(subscriptionTargetResult);

        return subscriptionTargetResult;
    }

    private Humidifier.DataZone.SubscriptionTarget CreateSubscriptionTarget()
    {
        var subscriptionTargetResult = new Humidifier.DataZone.SubscriptionTarget
        {
            GivenName = InputResourceName,
        };

        return subscriptionTargetResult;
    }
    public override void CreateChildren(Humidifier.DataZone.SubscriptionTarget result)
    {
        base.CreateChildren(result);

        result.SubscriptionTargetConfig = SubscriptionTargetConfigFactories.Any() ? SubscriptionTargetConfigFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SubscriptionTargetFactoryExtensions
{
    public static CombinedResult<SubscriptionTargetFactory, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig(this SubscriptionTargetFactory parentFactory, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null)
    {
        var factory = new InnerSubscriptionTargetSubscriptionTargetFormFactory(subFactoryAction);
        parentFactory.SubscriptionTargetConfigFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SubscriptionTargetFactory, T1, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1>(this CombinedResult<SubscriptionTargetFactory, T1> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionTargetFactory, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1>(this CombinedResult<T1, SubscriptionTargetFactory> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubscriptionTargetFactory, T1, T2, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2>(this CombinedResult<SubscriptionTargetFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionTargetFactory, T2, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2>(this CombinedResult<T1, SubscriptionTargetFactory, T2> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionTargetFactory, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2>(this CombinedResult<T1, T2, SubscriptionTargetFactory> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubscriptionTargetFactory, T1, T2, T3, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3>(this CombinedResult<SubscriptionTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionTargetFactory, T2, T3, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3>(this CombinedResult<T1, SubscriptionTargetFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionTargetFactory, T3, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3>(this CombinedResult<T1, T2, SubscriptionTargetFactory, T3> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriptionTargetFactory, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubscriptionTargetFactory> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubscriptionTargetFactory, T1, T2, T3, T4, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3, T4>(this CombinedResult<SubscriptionTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionTargetFactory, T2, T3, T4, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3, T4>(this CombinedResult<T1, SubscriptionTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionTargetFactory, T3, T4, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubscriptionTargetFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriptionTargetFactory, T4, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubscriptionTargetFactory, T4> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubscriptionTargetFactory, InnerSubscriptionTargetSubscriptionTargetFormFactory> WithSubscriptionTargetConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubscriptionTargetFactory> combinedResult, Action<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptionTargetConfig(combinedResult.T5, subFactoryAction));
}
