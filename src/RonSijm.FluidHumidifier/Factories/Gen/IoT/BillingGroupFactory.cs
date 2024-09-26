// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class BillingGroupFactory(string resourceName = null, Action<Humidifier.IoT.BillingGroup> factoryAction = null) : ResourceFactory<Humidifier.IoT.BillingGroup>(resourceName)
{

    internal InnerBillingGroupBillingGroupPropertiesFactory BillingGroupPropertiesFactory { get; set; }

    protected override Humidifier.IoT.BillingGroup Create()
    {
        var billingGroupResult = CreateBillingGroup();
        factoryAction?.Invoke(billingGroupResult);

        return billingGroupResult;
    }

    private Humidifier.IoT.BillingGroup CreateBillingGroup()
    {
        var billingGroupResult = new Humidifier.IoT.BillingGroup
        {
            GivenName = InputResourceName,
        };

        return billingGroupResult;
    }
    public override void CreateChildren(Humidifier.IoT.BillingGroup result)
    {
        base.CreateChildren(result);

        result.BillingGroupProperties ??= BillingGroupPropertiesFactory?.Build();
    }

} // End Of Class

public static class BillingGroupFactoryExtensions
{
    public static CombinedResult<BillingGroupFactory, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties(this BillingGroupFactory parentFactory, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null)
    {
        parentFactory.BillingGroupPropertiesFactory = new InnerBillingGroupBillingGroupPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BillingGroupPropertiesFactory);
    }

    public static CombinedResult<BillingGroupFactory, T1, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1>(this CombinedResult<BillingGroupFactory, T1> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1>(this CombinedResult<T1, BillingGroupFactory> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2>(this CombinedResult<BillingGroupFactory, T1, T2> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2>(this CombinedResult<T1, BillingGroupFactory, T2> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2>(this CombinedResult<T1, T2, BillingGroupFactory> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, T3, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3>(this CombinedResult<BillingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, T3, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3>(this CombinedResult<T1, BillingGroupFactory, T2, T3> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, T3, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3>(this CombinedResult<T1, T2, BillingGroupFactory, T3> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BillingGroupFactory, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, BillingGroupFactory> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, T3, T4, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3, T4>(this CombinedResult<BillingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, T3, T4, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, BillingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, T3, T4, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, BillingGroupFactory, T3, T4> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BillingGroupFactory, T4, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BillingGroupFactory, T4> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BillingGroupFactory, InnerBillingGroupBillingGroupPropertiesFactory> WithBillingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BillingGroupFactory> combinedResult, Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBillingGroupProperties(combinedResult.T5, subFactoryAction));
}
