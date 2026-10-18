// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolSmsConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.SmsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.SmsConfiguration>
{

    internal InnerUserPoolEumsSmsConfigurationFactory EumsSmsFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolTypes.SmsConfiguration Create()
    {
        var smsConfigurationResult = CreateSmsConfiguration();
        factoryAction?.Invoke(smsConfigurationResult);

        return smsConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.SmsConfiguration CreateSmsConfiguration()
    {
        var smsConfigurationResult = new Humidifier.Cognito.UserPoolTypes.SmsConfiguration();

        return smsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolTypes.SmsConfiguration result)
    {
        base.CreateChildren(result);

        result.EumsSms ??= EumsSmsFactory?.Build();
    }

} // End Of Class

public static class InnerUserPoolSmsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerUserPoolSmsConfigurationFactory, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms(this InnerUserPoolSmsConfigurationFactory parentFactory, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null)
    {
        parentFactory.EumsSmsFactory = new InnerUserPoolEumsSmsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EumsSmsFactory);
    }

    public static CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1>(this CombinedResult<InnerUserPoolSmsConfigurationFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1>(this CombinedResult<T1, InnerUserPoolSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, T2, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2>(this CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, T2, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2>(this CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolSmsConfigurationFactory, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, T2, T3, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, T2, T3, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolSmsConfigurationFactory, T3, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolSmsConfigurationFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerUserPoolSmsConfigurationFactory, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, T2, T3, T4, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolSmsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, T2, T3, T4, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolSmsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolSmsConfigurationFactory, T3, T4, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolSmsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerUserPoolSmsConfigurationFactory, T4, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolSmsConfigurationFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolSmsConfigurationFactory, InnerUserPoolEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T5, subFactoryAction).T2);
}
