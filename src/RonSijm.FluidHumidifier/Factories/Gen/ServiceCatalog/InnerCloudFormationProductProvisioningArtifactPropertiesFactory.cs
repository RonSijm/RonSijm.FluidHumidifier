// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProductProvisioningArtifactPropertiesFactory(Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties>
{

    internal InnerCloudFormationProductInfoFactory InfoFactory { get; set; }

    protected override Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties Create()
    {
        var provisioningArtifactPropertiesResult = CreateProvisioningArtifactProperties();
        factoryAction?.Invoke(provisioningArtifactPropertiesResult);

        return provisioningArtifactPropertiesResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties CreateProvisioningArtifactProperties()
    {
        var provisioningArtifactPropertiesResult = new Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties();

        return provisioningArtifactPropertiesResult;
    }
    public override void CreateChildren(Humidifier.ServiceCatalog.CloudFormationProductTypes.ProvisioningArtifactProperties result)
    {
        base.CreateChildren(result);

        result.Info ??= InfoFactory?.Build();
    }

} // End Of Class

public static class InnerCloudFormationProductProvisioningArtifactPropertiesFactoryExtensions
{
    public static CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, InnerCloudFormationProductInfoFactory> WithInfo(this InnerCloudFormationProductProvisioningArtifactPropertiesFactory parentFactory, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null)
    {
        parentFactory.InfoFactory = new InnerCloudFormationProductInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InfoFactory);
    }

    public static CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, InnerCloudFormationProductInfoFactory> WithInfo<T1>(this CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, InnerCloudFormationProductInfoFactory> WithInfo<T1>(this CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, T2, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2>(this CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T2, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2>(this CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T2> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2>(this CombinedResult<T1, T2, InnerCloudFormationProductProvisioningArtifactPropertiesFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, T2, T3, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T2, T3, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T3, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCloudFormationProductProvisioningArtifactPropertiesFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, T2, T3, T4, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T2, T3, T4, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T3, T4, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T4, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCloudFormationProductProvisioningArtifactPropertiesFactory, InnerCloudFormationProductInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCloudFormationProductProvisioningArtifactPropertiesFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.Info> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T5, subFactoryAction).T2);
}
