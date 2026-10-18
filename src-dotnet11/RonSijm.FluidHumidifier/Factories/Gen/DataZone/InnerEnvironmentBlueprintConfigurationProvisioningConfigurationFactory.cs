// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory(Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration>
{

    internal InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory LakeFormationConfigurationFactory { get; set; }

    protected override Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration Create()
    {
        var provisioningConfigurationResult = CreateProvisioningConfiguration();
        factoryAction?.Invoke(provisioningConfigurationResult);

        return provisioningConfigurationResult;
    }

    private Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration CreateProvisioningConfiguration()
    {
        var provisioningConfigurationResult = new Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration();

        return provisioningConfigurationResult;
    }
    public override void CreateChildren(Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.ProvisioningConfiguration result)
    {
        base.CreateChildren(result);

        result.LakeFormationConfiguration ??= LakeFormationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactoryExtensions
{
    public static CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration(this InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory parentFactory, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null)
    {
        parentFactory.LakeFormationConfigurationFactory = new InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LakeFormationConfigurationFactory);
    }

    public static CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1>(this CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1>(this CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, T2, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2>(this CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T2, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2>(this CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, T2, T3, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T2, T3, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T3, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, T2, T3, T4, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T2, T3, T4, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T3, T4, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T4, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory, InnerEnvironmentBlueprintConfigurationLakeFormationConfigurationFactory> WithLakeFormationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEnvironmentBlueprintConfigurationProvisioningConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.LakeFormationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLakeFormationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
