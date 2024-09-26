// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class BillingGroupFactory(string resourceName = null, Action<Humidifier.BillingConductor.BillingGroup> factoryAction = null) : ResourceFactory<Humidifier.BillingConductor.BillingGroup>(resourceName)
{

    internal InnerBillingGroupComputationPreferenceFactory ComputationPreferenceFactory { get; set; }

    internal InnerBillingGroupAccountGroupingFactory AccountGroupingFactory { get; set; }

    protected override Humidifier.BillingConductor.BillingGroup Create()
    {
        var billingGroupResult = CreateBillingGroup();
        factoryAction?.Invoke(billingGroupResult);

        return billingGroupResult;
    }

    private Humidifier.BillingConductor.BillingGroup CreateBillingGroup()
    {
        var billingGroupResult = new Humidifier.BillingConductor.BillingGroup
        {
            GivenName = InputResourceName,
        };

        return billingGroupResult;
    }
    public override void CreateChildren(Humidifier.BillingConductor.BillingGroup result)
    {
        base.CreateChildren(result);

        result.ComputationPreference ??= ComputationPreferenceFactory?.Build();
        result.AccountGrouping ??= AccountGroupingFactory?.Build();
    }

} // End Of Class

public static class BillingGroupFactoryExtensions
{
    public static CombinedResult<BillingGroupFactory, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference(this BillingGroupFactory parentFactory, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null)
    {
        parentFactory.ComputationPreferenceFactory = new InnerBillingGroupComputationPreferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputationPreferenceFactory);
    }

    public static CombinedResult<BillingGroupFactory, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping(this BillingGroupFactory parentFactory, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null)
    {
        parentFactory.AccountGroupingFactory = new InnerBillingGroupAccountGroupingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccountGroupingFactory);
    }

    public static CombinedResult<BillingGroupFactory, T1, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1>(this CombinedResult<BillingGroupFactory, T1> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputationPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1>(this CombinedResult<T1, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputationPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2>(this CombinedResult<BillingGroupFactory, T1, T2> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2>(this CombinedResult<T1, BillingGroupFactory, T2> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2>(this CombinedResult<T1, T2, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, T3, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3>(this CombinedResult<BillingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, T3, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3>(this CombinedResult<T1, BillingGroupFactory, T2, T3> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, T3, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3>(this CombinedResult<T1, T2, BillingGroupFactory, T3> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BillingGroupFactory, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3>(this CombinedResult<T1, T2, T3, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, T3, T4, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3, T4>(this CombinedResult<BillingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, T3, T4, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3, T4>(this CombinedResult<T1, BillingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, T3, T4, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3, T4>(this CombinedResult<T1, T2, BillingGroupFactory, T3, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BillingGroupFactory, T4, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BillingGroupFactory, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BillingGroupFactory, InnerBillingGroupComputationPreferenceFactory> WithComputationPreference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputationPreference(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1>(this CombinedResult<BillingGroupFactory, T1> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccountGrouping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1>(this CombinedResult<T1, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccountGrouping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2>(this CombinedResult<BillingGroupFactory, T1, T2> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2>(this CombinedResult<T1, BillingGroupFactory, T2> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2>(this CombinedResult<T1, T2, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, T3, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3>(this CombinedResult<BillingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, T3, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3>(this CombinedResult<T1, BillingGroupFactory, T2, T3> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, T3, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3>(this CombinedResult<T1, T2, BillingGroupFactory, T3> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BillingGroupFactory, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3>(this CombinedResult<T1, T2, T3, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BillingGroupFactory, T1, T2, T3, T4, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3, T4>(this CombinedResult<BillingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BillingGroupFactory, T2, T3, T4, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3, T4>(this CombinedResult<T1, BillingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BillingGroupFactory, T3, T4, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3, T4>(this CombinedResult<T1, T2, BillingGroupFactory, T3, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BillingGroupFactory, T4, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BillingGroupFactory, T4> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BillingGroupFactory, InnerBillingGroupAccountGroupingFactory> WithAccountGrouping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BillingGroupFactory> combinedResult, Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountGrouping(combinedResult.T5, subFactoryAction));
}
