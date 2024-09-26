// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerDistributionConfigurationAmiDistributionConfigurationFactory(Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration>
{

    internal InnerDistributionConfigurationLaunchPermissionConfigurationFactory LaunchPermissionConfigurationFactory { get; set; }

    protected override Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration Create()
    {
        var amiDistributionConfigurationResult = CreateAmiDistributionConfiguration();
        factoryAction?.Invoke(amiDistributionConfigurationResult);

        return amiDistributionConfigurationResult;
    }

    private Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration CreateAmiDistributionConfiguration()
    {
        var amiDistributionConfigurationResult = new Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration();

        return amiDistributionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration result)
    {
        base.CreateChildren(result);

        result.LaunchPermissionConfiguration ??= LaunchPermissionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDistributionConfigurationAmiDistributionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration(this InnerDistributionConfigurationAmiDistributionConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null)
    {
        parentFactory.LaunchPermissionConfigurationFactory = new InnerDistributionConfigurationLaunchPermissionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchPermissionConfigurationFactory);
    }

    public static CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1>(this CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1>(this CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, T2, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2>(this CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T2, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2>(this CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionConfigurationAmiDistributionConfigurationFactory, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDistributionConfigurationAmiDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, T2, T3, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3>(this CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T2, T3, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T3, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionConfigurationAmiDistributionConfigurationFactory, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionConfigurationAmiDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, T2, T3, T4, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDistributionConfigurationAmiDistributionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T2, T3, T4, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T3, T4, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T4, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionConfigurationAmiDistributionConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionConfigurationAmiDistributionConfigurationFactory, InnerDistributionConfigurationLaunchPermissionConfigurationFactory> WithLaunchPermissionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionConfigurationAmiDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchPermissionConfiguration(combinedResult.T5, subFactoryAction));
}
