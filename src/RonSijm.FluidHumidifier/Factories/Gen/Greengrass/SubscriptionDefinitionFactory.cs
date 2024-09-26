// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class SubscriptionDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.SubscriptionDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.SubscriptionDefinition>(resourceName)
{

    internal InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.SubscriptionDefinition Create()
    {
        var subscriptionDefinitionResult = CreateSubscriptionDefinition();
        factoryAction?.Invoke(subscriptionDefinitionResult);

        return subscriptionDefinitionResult;
    }

    private Humidifier.Greengrass.SubscriptionDefinition CreateSubscriptionDefinition()
    {
        var subscriptionDefinitionResult = new Humidifier.Greengrass.SubscriptionDefinition
        {
            GivenName = InputResourceName,
        };

        return subscriptionDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.SubscriptionDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class SubscriptionDefinitionFactoryExtensions
{
    public static CombinedResult<SubscriptionDefinitionFactory, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion(this SubscriptionDefinitionFactory parentFactory, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<SubscriptionDefinitionFactory, T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<SubscriptionDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionFactory, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, SubscriptionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubscriptionDefinitionFactory, T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<SubscriptionDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionFactory, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, SubscriptionDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionDefinitionFactory, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, SubscriptionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubscriptionDefinitionFactory, T1, T2, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<SubscriptionDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionFactory, T2, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, SubscriptionDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionDefinitionFactory, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, SubscriptionDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriptionDefinitionFactory, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubscriptionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubscriptionDefinitionFactory, T1, T2, T3, T4, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<SubscriptionDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionFactory, T2, T3, T4, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, SubscriptionDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionDefinitionFactory, T3, T4, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubscriptionDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriptionDefinitionFactory, T4, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubscriptionDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubscriptionDefinitionFactory, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubscriptionDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
