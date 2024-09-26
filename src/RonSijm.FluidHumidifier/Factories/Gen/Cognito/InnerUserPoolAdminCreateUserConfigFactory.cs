// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolAdminCreateUserConfigFactory(Action<Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig>
{

    internal InnerUserPoolInviteMessageTemplateFactory InviteMessageTemplateFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig Create()
    {
        var adminCreateUserConfigResult = CreateAdminCreateUserConfig();
        factoryAction?.Invoke(adminCreateUserConfigResult);

        return adminCreateUserConfigResult;
    }

    private Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig CreateAdminCreateUserConfig()
    {
        var adminCreateUserConfigResult = new Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig();

        return adminCreateUserConfigResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolTypes.AdminCreateUserConfig result)
    {
        base.CreateChildren(result);

        result.InviteMessageTemplate ??= InviteMessageTemplateFactory?.Build();
    }

} // End Of Class

public static class InnerUserPoolAdminCreateUserConfigFactoryExtensions
{
    public static CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate(this InnerUserPoolAdminCreateUserConfigFactory parentFactory, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null)
    {
        parentFactory.InviteMessageTemplateFactory = new InnerUserPoolInviteMessageTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InviteMessageTemplateFactory);
    }

    public static CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1>(this CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1>(this CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, T2, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2>(this CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, T2, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2>(this CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolAdminCreateUserConfigFactory, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolAdminCreateUserConfigFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, T2, T3, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3>(this CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, T2, T3, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolAdminCreateUserConfigFactory, T3, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolAdminCreateUserConfigFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolAdminCreateUserConfigFactory, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolAdminCreateUserConfigFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, T2, T3, T4, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolAdminCreateUserConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, T2, T3, T4, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolAdminCreateUserConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolAdminCreateUserConfigFactory, T3, T4, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolAdminCreateUserConfigFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolAdminCreateUserConfigFactory, T4, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolAdminCreateUserConfigFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolAdminCreateUserConfigFactory, InnerUserPoolInviteMessageTemplateFactory> WithInviteMessageTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolAdminCreateUserConfigFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.InviteMessageTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInviteMessageTemplate(combinedResult.T5, subFactoryAction));
}
