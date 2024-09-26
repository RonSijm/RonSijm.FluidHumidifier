// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolUserPoolAddOnsFactory(Action<Humidifier.Cognito.UserPoolTypes.UserPoolAddOns> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.UserPoolAddOns>
{

    internal InnerUserPoolAdvancedSecurityAdditionalFlowsFactory AdvancedSecurityAdditionalFlowsFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolTypes.UserPoolAddOns Create()
    {
        var userPoolAddOnsResult = CreateUserPoolAddOns();
        factoryAction?.Invoke(userPoolAddOnsResult);

        return userPoolAddOnsResult;
    }

    private Humidifier.Cognito.UserPoolTypes.UserPoolAddOns CreateUserPoolAddOns()
    {
        var userPoolAddOnsResult = new Humidifier.Cognito.UserPoolTypes.UserPoolAddOns();

        return userPoolAddOnsResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolTypes.UserPoolAddOns result)
    {
        base.CreateChildren(result);

        result.AdvancedSecurityAdditionalFlows ??= AdvancedSecurityAdditionalFlowsFactory?.Build();
    }

} // End Of Class

public static class InnerUserPoolUserPoolAddOnsFactoryExtensions
{
    public static CombinedResult<InnerUserPoolUserPoolAddOnsFactory, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows(this InnerUserPoolUserPoolAddOnsFactory parentFactory, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null)
    {
        parentFactory.AdvancedSecurityAdditionalFlowsFactory = new InnerUserPoolAdvancedSecurityAdditionalFlowsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdvancedSecurityAdditionalFlowsFactory);
    }

    public static CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1>(this CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1>(this CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, T2, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2>(this CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, T2, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2>(this CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolUserPoolAddOnsFactory, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolUserPoolAddOnsFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, T2, T3, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3>(this CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, T2, T3, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolUserPoolAddOnsFactory, T3, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolUserPoolAddOnsFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolUserPoolAddOnsFactory, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolUserPoolAddOnsFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, T2, T3, T4, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolUserPoolAddOnsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, T2, T3, T4, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolUserPoolAddOnsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolUserPoolAddOnsFactory, T3, T4, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolUserPoolAddOnsFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolUserPoolAddOnsFactory, T4, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolUserPoolAddOnsFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolUserPoolAddOnsFactory, InnerUserPoolAdvancedSecurityAdditionalFlowsFactory> WithAdvancedSecurityAdditionalFlows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolUserPoolAddOnsFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.AdvancedSecurityAdditionalFlows> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedSecurityAdditionalFlows(combinedResult.T5, subFactoryAction));
}
