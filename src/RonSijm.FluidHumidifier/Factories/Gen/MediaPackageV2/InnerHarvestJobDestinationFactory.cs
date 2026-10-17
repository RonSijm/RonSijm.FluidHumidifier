// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerHarvestJobDestinationFactory(Action<Humidifier.MediaPackageV2.HarvestJobTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.HarvestJobTypes.Destination>
{

    internal InnerHarvestJobS3DestinationConfigFactory S3DestinationFactory { get; set; }

    protected override Humidifier.MediaPackageV2.HarvestJobTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.MediaPackageV2.HarvestJobTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.MediaPackageV2.HarvestJobTypes.Destination();

        return destinationResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.HarvestJobTypes.Destination result)
    {
        base.CreateChildren(result);

        result.S3Destination ??= S3DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerHarvestJobDestinationFactoryExtensions
{
    public static CombinedResult<InnerHarvestJobDestinationFactory, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination(this InnerHarvestJobDestinationFactory parentFactory, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null)
    {
        parentFactory.S3DestinationFactory = new InnerHarvestJobS3DestinationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DestinationFactory);
    }

    public static CombinedResult<InnerHarvestJobDestinationFactory, T1, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1>(this CombinedResult<InnerHarvestJobDestinationFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarvestJobDestinationFactory, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1>(this CombinedResult<T1, InnerHarvestJobDestinationFactory> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarvestJobDestinationFactory, T1, T2, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2>(this CombinedResult<InnerHarvestJobDestinationFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarvestJobDestinationFactory, T2, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, InnerHarvestJobDestinationFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarvestJobDestinationFactory, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, T2, InnerHarvestJobDestinationFactory> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarvestJobDestinationFactory, T1, T2, T3, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<InnerHarvestJobDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarvestJobDestinationFactory, T2, T3, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, InnerHarvestJobDestinationFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarvestJobDestinationFactory, T3, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarvestJobDestinationFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarvestJobDestinationFactory, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarvestJobDestinationFactory> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarvestJobDestinationFactory, T1, T2, T3, T4, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<InnerHarvestJobDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarvestJobDestinationFactory, T2, T3, T4, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarvestJobDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarvestJobDestinationFactory, T3, T4, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarvestJobDestinationFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarvestJobDestinationFactory, T4, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarvestJobDestinationFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarvestJobDestinationFactory, InnerHarvestJobS3DestinationConfigFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarvestJobDestinationFactory> combinedResult, Action<Humidifier.MediaPackageV2.HarvestJobTypes.S3DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T5, subFactoryAction).T2);
}
