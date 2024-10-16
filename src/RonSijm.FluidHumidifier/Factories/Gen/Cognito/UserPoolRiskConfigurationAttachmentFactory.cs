// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolRiskConfigurationAttachmentFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachment> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolRiskConfigurationAttachment>(resourceName)
{

    internal InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory CompromisedCredentialsRiskConfigurationFactory { get; set; }

    internal InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory AccountTakeoverRiskConfigurationFactory { get; set; }

    internal InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory RiskExceptionConfigurationFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolRiskConfigurationAttachment Create()
    {
        var userPoolRiskConfigurationAttachmentResult = CreateUserPoolRiskConfigurationAttachment();
        factoryAction?.Invoke(userPoolRiskConfigurationAttachmentResult);

        return userPoolRiskConfigurationAttachmentResult;
    }

    private Humidifier.Cognito.UserPoolRiskConfigurationAttachment CreateUserPoolRiskConfigurationAttachment()
    {
        var userPoolRiskConfigurationAttachmentResult = new Humidifier.Cognito.UserPoolRiskConfigurationAttachment
        {
            GivenName = InputResourceName,
        };

        return userPoolRiskConfigurationAttachmentResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolRiskConfigurationAttachment result)
    {
        base.CreateChildren(result);

        result.CompromisedCredentialsRiskConfiguration ??= CompromisedCredentialsRiskConfigurationFactory?.Build();
        result.AccountTakeoverRiskConfiguration ??= AccountTakeoverRiskConfigurationFactory?.Build();
        result.RiskExceptionConfiguration ??= RiskExceptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class UserPoolRiskConfigurationAttachmentFactoryExtensions
{
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration(this UserPoolRiskConfigurationAttachmentFactory parentFactory, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null)
    {
        parentFactory.CompromisedCredentialsRiskConfigurationFactory = new InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CompromisedCredentialsRiskConfigurationFactory);
    }

    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration(this UserPoolRiskConfigurationAttachmentFactory parentFactory, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null)
    {
        parentFactory.AccountTakeoverRiskConfigurationFactory = new InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccountTakeoverRiskConfigurationFactory);
    }

    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration(this UserPoolRiskConfigurationAttachmentFactory parentFactory, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null)
    {
        parentFactory.RiskExceptionConfigurationFactory = new InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RiskExceptionConfigurationFactory);
    }

    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, T4, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, T4, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, T4, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, T4, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentCompromisedCredentialsRiskConfigurationTypeFactory> WithCompromisedCredentialsRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.CompromisedCredentialsRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompromisedCredentialsRiskConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, T4, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, T4, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, T4, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, T4, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentAccountTakeoverRiskConfigurationTypeFactory> WithAccountTakeoverRiskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.AccountTakeoverRiskConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccountTakeoverRiskConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, T4, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3, T4>(this CombinedResult<UserPoolRiskConfigurationAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, T4, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolRiskConfigurationAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, T4, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolRiskConfigurationAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, T4, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolRiskConfigurationAttachmentFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolRiskConfigurationAttachmentFactory, InnerUserPoolRiskConfigurationAttachmentRiskExceptionConfigurationTypeFactory> WithRiskExceptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolRiskConfigurationAttachmentFactory> combinedResult, Action<Humidifier.Cognito.UserPoolRiskConfigurationAttachmentTypes.RiskExceptionConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRiskExceptionConfiguration(combinedResult.T5, subFactoryAction));
}
