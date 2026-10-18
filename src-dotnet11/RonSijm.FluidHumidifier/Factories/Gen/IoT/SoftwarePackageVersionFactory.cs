// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class SoftwarePackageVersionFactory(string resourceName = null, Action<Humidifier.IoT.SoftwarePackageVersion> factoryAction = null) : ResourceFactory<Humidifier.IoT.SoftwarePackageVersion>(resourceName)
{

    internal InnerSoftwarePackageVersionSbomFactory SbomFactory { get; set; }

    internal InnerSoftwarePackageVersionPackageVersionArtifactFactory ArtifactFactory { get; set; }

    protected override Humidifier.IoT.SoftwarePackageVersion Create()
    {
        var softwarePackageVersionResult = CreateSoftwarePackageVersion();
        factoryAction?.Invoke(softwarePackageVersionResult);

        return softwarePackageVersionResult;
    }

    private Humidifier.IoT.SoftwarePackageVersion CreateSoftwarePackageVersion()
    {
        var softwarePackageVersionResult = new Humidifier.IoT.SoftwarePackageVersion
        {
            GivenName = InputResourceName,
        };

        return softwarePackageVersionResult;
    }
    public override void CreateChildren(Humidifier.IoT.SoftwarePackageVersion result)
    {
        base.CreateChildren(result);

        result.Sbom ??= SbomFactory?.Build();
        result.Artifact ??= ArtifactFactory?.Build();
    }

} // End Of Class

public static class SoftwarePackageVersionFactoryExtensions
{
    public static CombinedResult<SoftwarePackageVersionFactory, InnerSoftwarePackageVersionSbomFactory> WithSbom(this SoftwarePackageVersionFactory parentFactory, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null)
    {
        parentFactory.SbomFactory = new InnerSoftwarePackageVersionSbomFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SbomFactory);
    }

    public static CombinedResult<SoftwarePackageVersionFactory, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact(this SoftwarePackageVersionFactory parentFactory, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null)
    {
        parentFactory.ArtifactFactory = new InnerSoftwarePackageVersionPackageVersionArtifactFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArtifactFactory);
    }

    public static CombinedResult<SoftwarePackageVersionFactory, T1, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1>(this CombinedResult<SoftwarePackageVersionFactory, T1> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, WithSbom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1>(this CombinedResult<T1, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, WithSbom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, T2, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2>(this CombinedResult<SoftwarePackageVersionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, T2, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2>(this CombinedResult<T1, SoftwarePackageVersionFactory, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2>(this CombinedResult<T1, T2, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3>(this CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3>(this CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3>(this CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3>(this CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3, T4, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3, T4>(this CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3, T4, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3, T4>(this CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3, T4, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3, T4>(this CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory, T4, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionSbomFactory> WithSbom<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSbom(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1>(this CombinedResult<SoftwarePackageVersionFactory, T1> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1>(this CombinedResult<T1, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2>(this CombinedResult<SoftwarePackageVersionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2>(this CombinedResult<T1, SoftwarePackageVersionFactory, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2>(this CombinedResult<T1, T2, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3>(this CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3>(this CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3>(this CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3>(this CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3, T4, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3, T4>(this CombinedResult<SoftwarePackageVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3, T4, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3, T4>(this CombinedResult<T1, SoftwarePackageVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3, T4, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3, T4>(this CombinedResult<T1, T2, SoftwarePackageVersionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory, T4, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SoftwarePackageVersionFactory, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SoftwarePackageVersionFactory, InnerSoftwarePackageVersionPackageVersionArtifactFactory> WithArtifact<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SoftwarePackageVersionFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifact(combinedResult.T5, subFactoryAction).T2);
}
