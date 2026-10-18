// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSoftwarePackageVersionSbomFactory(Action<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SoftwarePackageVersionTypes.Sbom>
{

    internal InnerSoftwarePackageVersionS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.IoT.SoftwarePackageVersionTypes.Sbom Create()
    {
        var sbomResult = CreateSbom();
        factoryAction?.Invoke(sbomResult);

        return sbomResult;
    }

    private Humidifier.IoT.SoftwarePackageVersionTypes.Sbom CreateSbom()
    {
        var sbomResult = new Humidifier.IoT.SoftwarePackageVersionTypes.Sbom();

        return sbomResult;
    }
    public override void CreateChildren(Humidifier.IoT.SoftwarePackageVersionTypes.Sbom result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerSoftwarePackageVersionSbomFactoryExtensions
{
    public static CombinedResult<InnerSoftwarePackageVersionSbomFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location(this InnerSoftwarePackageVersionSbomFactory parentFactory, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerSoftwarePackageVersionS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, T2, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, T2, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, T2> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSoftwarePackageVersionSbomFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerSoftwarePackageVersionSbomFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, T2, T3, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, T2, T3, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSoftwarePackageVersionSbomFactory, T3, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerSoftwarePackageVersionSbomFactory, T3> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionSbomFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionSbomFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, T2, T3, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerSoftwarePackageVersionSbomFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, T2, T3, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerSoftwarePackageVersionSbomFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSoftwarePackageVersionSbomFactory, T3, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSoftwarePackageVersionSbomFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionSbomFactory, T4, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSoftwarePackageVersionSbomFactory, T4> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSoftwarePackageVersionSbomFactory, InnerSoftwarePackageVersionS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSoftwarePackageVersionSbomFactory> combinedResult, Action<Humidifier.IoT.SoftwarePackageVersionTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction).T2);
}
