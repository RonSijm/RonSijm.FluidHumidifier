// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class PartnerAppFactory(string resourceName = null, Action<Humidifier.SageMaker.PartnerApp> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.PartnerApp>(resourceName)
{

    internal InnerPartnerAppPartnerAppConfigFactory ApplicationConfigFactory { get; set; }

    internal InnerPartnerAppPartnerAppMaintenanceConfigFactory MaintenanceConfigFactory { get; set; }

    protected override Humidifier.SageMaker.PartnerApp Create()
    {
        var partnerAppResult = CreatePartnerApp();
        factoryAction?.Invoke(partnerAppResult);

        return partnerAppResult;
    }

    private Humidifier.SageMaker.PartnerApp CreatePartnerApp()
    {
        var partnerAppResult = new Humidifier.SageMaker.PartnerApp
        {
            GivenName = InputResourceName,
        };

        return partnerAppResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.PartnerApp result)
    {
        base.CreateChildren(result);

        result.ApplicationConfig ??= ApplicationConfigFactory?.Build();
        result.MaintenanceConfig ??= MaintenanceConfigFactory?.Build();
    }

} // End Of Class

public static class PartnerAppFactoryExtensions
{
    public static CombinedResult<PartnerAppFactory, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig(this PartnerAppFactory parentFactory, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null)
    {
        parentFactory.ApplicationConfigFactory = new InnerPartnerAppPartnerAppConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationConfigFactory);
    }

    public static CombinedResult<PartnerAppFactory, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig(this PartnerAppFactory parentFactory, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null)
    {
        parentFactory.MaintenanceConfigFactory = new InnerPartnerAppPartnerAppMaintenanceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceConfigFactory);
    }

    public static CombinedResult<PartnerAppFactory, T1, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1>(this CombinedResult<PartnerAppFactory, T1> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1>(this CombinedResult<T1, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, T2, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2>(this CombinedResult<PartnerAppFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, T2, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2>(this CombinedResult<T1, PartnerAppFactory, T2> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnerAppFactory, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2>(this CombinedResult<T1, T2, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, T2, T3, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3>(this CombinedResult<PartnerAppFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, T2, T3, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3>(this CombinedResult<T1, PartnerAppFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnerAppFactory, T3, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3>(this CombinedResult<T1, T2, PartnerAppFactory, T3> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartnerAppFactory, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, T2, T3, T4, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3, T4>(this CombinedResult<PartnerAppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, T2, T3, T4, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, PartnerAppFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnerAppFactory, T3, T4, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, PartnerAppFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartnerAppFactory, T4, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PartnerAppFactory, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PartnerAppFactory, InnerPartnerAppPartnerAppConfigFactory> WithApplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1>(this CombinedResult<PartnerAppFactory, T1> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1>(this CombinedResult<T1, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, T2, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2>(this CombinedResult<PartnerAppFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, T2, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2>(this CombinedResult<T1, PartnerAppFactory, T2> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnerAppFactory, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2>(this CombinedResult<T1, T2, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, T2, T3, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3>(this CombinedResult<PartnerAppFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, T2, T3, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3>(this CombinedResult<T1, PartnerAppFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnerAppFactory, T3, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3>(this CombinedResult<T1, T2, PartnerAppFactory, T3> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartnerAppFactory, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PartnerAppFactory, T1, T2, T3, T4, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3, T4>(this CombinedResult<PartnerAppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PartnerAppFactory, T2, T3, T4, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3, T4>(this CombinedResult<T1, PartnerAppFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PartnerAppFactory, T3, T4, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, PartnerAppFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PartnerAppFactory, T4, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PartnerAppFactory, T4> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PartnerAppFactory, InnerPartnerAppPartnerAppMaintenanceConfigFactory> WithMaintenanceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PartnerAppFactory> combinedResult, Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceConfig(combinedResult.T5, subFactoryAction));
}
