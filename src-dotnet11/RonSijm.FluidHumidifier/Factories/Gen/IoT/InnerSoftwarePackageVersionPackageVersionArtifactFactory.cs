// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSoftwarePackageVersionPackageVersionArtifactFactory(Action<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact>
{

    internal InnerSoftwarePackageVersionS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact Create()
    {
        var packageVersionArtifactResult = CreatePackageVersionArtifact();
        factoryAction?.Invoke(packageVersionArtifactResult);

        return packageVersionArtifactResult;
    }

    private Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact CreatePackageVersionArtifact()
    {
        var packageVersionArtifactResult = new Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact();

        return packageVersionArtifactResult;
    }
    public override void CreateChildren(Humidifier.IoT.SoftwarePackageVersionTypes.PackageVersionArtifact result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerSoftwarePackageVersionPackageVersionArtifactFactoryExtensions
{
    public static CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location(this InnerSoftwarePackageVersionPackageVersionArtifactFactory parentFactory, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerSoftwarePackageVersionS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, T2, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T2, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, T2, T3, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T2, T3, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T3, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, T2, T3, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerSoftwarePackageVersionPackageVersionArtifactFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T2, T3, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T3, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionPackageVersionArtifactFactory, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSoftwarePackageVersionPackageVersionArtifactFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSoftwarePackageVersionPackageVersionArtifactFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction).T2);
}
