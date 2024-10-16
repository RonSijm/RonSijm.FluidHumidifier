// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeArtifact;

public class PackageGroupFactory(string resourceName = null, Action<Humidifier.CodeArtifact.PackageGroup> factoryAction = null) : ResourceFactory<Humidifier.CodeArtifact.PackageGroup>(resourceName)
{

    internal InnerPackageGroupOriginConfigurationFactory OriginConfigurationFactory { get; set; }

    protected override Humidifier.CodeArtifact.PackageGroup Create()
    {
        var packageGroupResult = CreatePackageGroup();
        factoryAction?.Invoke(packageGroupResult);

        return packageGroupResult;
    }

    private Humidifier.CodeArtifact.PackageGroup CreatePackageGroup()
    {
        var packageGroupResult = new Humidifier.CodeArtifact.PackageGroup
        {
            GivenName = InputResourceName,
        };

        return packageGroupResult;
    }
    public override void CreateChildren(Humidifier.CodeArtifact.PackageGroup result)
    {
        base.CreateChildren(result);

        result.OriginConfiguration ??= OriginConfigurationFactory?.Build();
    }

} // End Of Class

public static class PackageGroupFactoryExtensions
{
    public static CombinedResult<PackageGroupFactory, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration(this PackageGroupFactory parentFactory, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null)
    {
        parentFactory.OriginConfigurationFactory = new InnerPackageGroupOriginConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OriginConfigurationFactory);
    }

    public static CombinedResult<PackageGroupFactory, T1, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1>(this CombinedResult<PackageGroupFactory, T1> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageGroupFactory, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1>(this CombinedResult<T1, PackageGroupFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PackageGroupFactory, T1, T2, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2>(this CombinedResult<PackageGroupFactory, T1, T2> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageGroupFactory, T2, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2>(this CombinedResult<T1, PackageGroupFactory, T2> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackageGroupFactory, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2>(this CombinedResult<T1, T2, PackageGroupFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PackageGroupFactory, T1, T2, T3, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3>(this CombinedResult<PackageGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageGroupFactory, T2, T3, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3>(this CombinedResult<T1, PackageGroupFactory, T2, T3> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackageGroupFactory, T3, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PackageGroupFactory, T3> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackageGroupFactory, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PackageGroupFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PackageGroupFactory, T1, T2, T3, T4, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3, T4>(this CombinedResult<PackageGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PackageGroupFactory, T2, T3, T4, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PackageGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PackageGroupFactory, T3, T4, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PackageGroupFactory, T3, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PackageGroupFactory, T4, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PackageGroupFactory, T4> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PackageGroupFactory, InnerPackageGroupOriginConfigurationFactory> WithOriginConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PackageGroupFactory> combinedResult, Action<Humidifier.CodeArtifact.PackageGroupTypes.OriginConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginConfiguration(combinedResult.T5, subFactoryAction));
}
