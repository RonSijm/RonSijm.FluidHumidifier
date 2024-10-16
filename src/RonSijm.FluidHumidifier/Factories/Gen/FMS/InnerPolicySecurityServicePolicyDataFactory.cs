// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicySecurityServicePolicyDataFactory(Action<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.SecurityServicePolicyData>
{

    internal InnerPolicyPolicyOptionFactory PolicyOptionFactory { get; set; }

    protected override Humidifier.FMS.PolicyTypes.SecurityServicePolicyData Create()
    {
        var securityServicePolicyDataResult = CreateSecurityServicePolicyData();
        factoryAction?.Invoke(securityServicePolicyDataResult);

        return securityServicePolicyDataResult;
    }

    private Humidifier.FMS.PolicyTypes.SecurityServicePolicyData CreateSecurityServicePolicyData()
    {
        var securityServicePolicyDataResult = new Humidifier.FMS.PolicyTypes.SecurityServicePolicyData();

        return securityServicePolicyDataResult;
    }
    public override void CreateChildren(Humidifier.FMS.PolicyTypes.SecurityServicePolicyData result)
    {
        base.CreateChildren(result);

        result.PolicyOption ??= PolicyOptionFactory?.Build();
    }

} // End Of Class

public static class InnerPolicySecurityServicePolicyDataFactoryExtensions
{
    public static CombinedResult<InnerPolicySecurityServicePolicyDataFactory, InnerPolicyPolicyOptionFactory> WithPolicyOption(this InnerPolicySecurityServicePolicyDataFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null)
    {
        parentFactory.PolicyOptionFactory = new InnerPolicyPolicyOptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyOptionFactory);
    }

    public static CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1>(this CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1>(this CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, T2, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2>(this CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, T2, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2>(this CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicySecurityServicePolicyDataFactory, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2>(this CombinedResult<T1, T2, InnerPolicySecurityServicePolicyDataFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, T2, T3, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3>(this CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, T2, T3, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3>(this CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicySecurityServicePolicyDataFactory, T3, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicySecurityServicePolicyDataFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicySecurityServicePolicyDataFactory, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicySecurityServicePolicyDataFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, T2, T3, T4, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3, T4>(this CombinedResult<InnerPolicySecurityServicePolicyDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, T2, T3, T4, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicySecurityServicePolicyDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicySecurityServicePolicyDataFactory, T3, T4, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicySecurityServicePolicyDataFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicySecurityServicePolicyDataFactory, T4, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicySecurityServicePolicyDataFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPolicySecurityServicePolicyDataFactory, InnerPolicyPolicyOptionFactory> WithPolicyOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicySecurityServicePolicyDataFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.PolicyOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyOption(combinedResult.T5, subFactoryAction));
}
