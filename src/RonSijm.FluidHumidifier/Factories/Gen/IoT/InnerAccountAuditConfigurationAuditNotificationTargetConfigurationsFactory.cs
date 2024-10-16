// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations>
{

    internal InnerAccountAuditConfigurationAuditNotificationTargetFactory SnsFactory { get; set; }

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations Create()
    {
        var auditNotificationTargetConfigurationsResult = CreateAuditNotificationTargetConfigurations();
        factoryAction?.Invoke(auditNotificationTargetConfigurationsResult);

        return auditNotificationTargetConfigurationsResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations CreateAuditNotificationTargetConfigurations()
    {
        var auditNotificationTargetConfigurationsResult = new Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations();

        return auditNotificationTargetConfigurationsResult;
    }
    public override void CreateChildren(Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTargetConfigurations result)
    {
        base.CreateChildren(result);

        result.Sns ??= SnsFactory?.Build();
    }

} // End Of Class

public static class InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactoryExtensions
{
    public static CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns(this InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory parentFactory, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null)
    {
        parentFactory.SnsFactory = new InnerAccountAuditConfigurationAuditNotificationTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SnsFactory);
    }

    public static CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1>(this CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithSns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1>(this CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithSns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2>(this CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, T2> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T2, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2>(this CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T2> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, T2, T3, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3>(this CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T2, T3, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3>(this CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T2, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T3, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, T2, T3, T4, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3, T4>(this CombinedResult<InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T2, T3, T4, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T3, T4, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T4, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory, InnerAccountAuditConfigurationAuditNotificationTargetFactory> WithSns<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccountAuditConfigurationAuditNotificationTargetConfigurationsFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSns(combinedResult.T5, subFactoryAction));
}
