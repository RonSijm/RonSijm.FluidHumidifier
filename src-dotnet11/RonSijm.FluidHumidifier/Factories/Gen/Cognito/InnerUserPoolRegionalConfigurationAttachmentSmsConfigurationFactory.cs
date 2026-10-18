// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory(Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration>
{

    internal InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory EumsSmsFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration Create()
    {
        var smsConfigurationResult = CreateSmsConfiguration();
        factoryAction?.Invoke(smsConfigurationResult);

        return smsConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration CreateSmsConfiguration()
    {
        var smsConfigurationResult = new Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration();

        return smsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.SmsConfiguration result)
    {
        base.CreateChildren(result);

        result.EumsSms ??= EumsSmsFactory?.Build();
    }

} // End Of Class

public static class InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms(this InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory parentFactory, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null)
    {
        parentFactory.EumsSmsFactory = new InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EumsSmsFactory);
    }

    public static CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1>(this CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1>(this CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, T2, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2>(this CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T2, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2>(this CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, T2, T3, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T2, T3, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T3, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, T2, T3, T4, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T2, T3, T4, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T3, T4, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T4, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory, InnerUserPoolRegionalConfigurationAttachmentEumsSmsConfigurationFactory> WithEumsSms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolRegionalConfigurationAttachmentSmsConfigurationFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRegionalConfigurationAttachmentTypes.EumsSmsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEumsSms(combinedResult.T5, subFactoryAction).T2);
}
