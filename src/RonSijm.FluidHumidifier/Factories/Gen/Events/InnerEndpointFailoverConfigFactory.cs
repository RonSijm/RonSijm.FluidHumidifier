// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEndpointFailoverConfigFactory(Action<Humidifier.Events.EndpointTypes.FailoverConfig> factoryAction = null) : SubResourceFactory<Humidifier.Events.EndpointTypes.FailoverConfig>
{

    internal InnerEndpointSecondaryFactory SecondaryFactory { get; set; }

    internal InnerEndpointPrimaryFactory PrimaryFactory { get; set; }

    protected override Humidifier.Events.EndpointTypes.FailoverConfig Create()
    {
        var failoverConfigResult = CreateFailoverConfig();
        factoryAction?.Invoke(failoverConfigResult);

        return failoverConfigResult;
    }

    private Humidifier.Events.EndpointTypes.FailoverConfig CreateFailoverConfig()
    {
        var failoverConfigResult = new Humidifier.Events.EndpointTypes.FailoverConfig();

        return failoverConfigResult;
    }
    public override void CreateChildren(Humidifier.Events.EndpointTypes.FailoverConfig result)
    {
        base.CreateChildren(result);

        result.Secondary ??= SecondaryFactory?.Build();
        result.Primary ??= PrimaryFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointFailoverConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointFailoverConfigFactory, InnerEndpointSecondaryFactory> WithSecondary(this InnerEndpointFailoverConfigFactory parentFactory, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null)
    {
        parentFactory.SecondaryFactory = new InnerEndpointSecondaryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecondaryFactory);
    }

    public static CombinedResult<InnerEndpointFailoverConfigFactory, InnerEndpointPrimaryFactory> WithPrimary(this InnerEndpointFailoverConfigFactory parentFactory, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null)
    {
        parentFactory.PrimaryFactory = new InnerEndpointPrimaryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrimaryFactory);
    }

    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, InnerEndpointSecondaryFactory> WithSecondary<T1>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecondary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, InnerEndpointSecondaryFactory> WithSecondary<T1>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecondary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, InnerEndpointSecondaryFactory> WithSecondary<T1, T2>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, InnerEndpointSecondaryFactory> WithSecondary<T1, T2>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, InnerEndpointSecondaryFactory> WithSecondary<T1, T2>(this CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3, T4, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3, T4>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3, T4, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3, T4, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory, T4, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointFailoverConfigFactory, InnerEndpointSecondaryFactory> WithSecondary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Secondary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecondary(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, InnerEndpointPrimaryFactory> WithPrimary<T1>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, InnerEndpointPrimaryFactory> WithPrimary<T1>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, InnerEndpointPrimaryFactory> WithPrimary<T1, T2>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, InnerEndpointPrimaryFactory> WithPrimary<T1, T2>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, InnerEndpointPrimaryFactory> WithPrimary<T1, T2>(this CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3, T4, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3, T4>(this CombinedResult<InnerEndpointFailoverConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3, T4, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointFailoverConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3, T4, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointFailoverConfigFactory, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory, T4, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointFailoverConfigFactory, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointFailoverConfigFactory, InnerEndpointPrimaryFactory> WithPrimary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointFailoverConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.Primary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimary(combinedResult.T5, subFactoryAction));
}
