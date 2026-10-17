// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class HarvestJobFactory(string resourceName = null, Action<Humidifier.MediaPackage.HarvestJob> factoryAction = null) : ResourceFactory<Humidifier.MediaPackage.HarvestJob>(resourceName)
{

    internal InnerHarvestJobS3DestinationFactory S3DestinationFactory { get; set; }

    protected override Humidifier.MediaPackage.HarvestJob Create()
    {
        var harvestJobResult = CreateHarvestJob();
        factoryAction?.Invoke(harvestJobResult);

        return harvestJobResult;
    }

    private Humidifier.MediaPackage.HarvestJob CreateHarvestJob()
    {
        var harvestJobResult = new Humidifier.MediaPackage.HarvestJob
        {
            GivenName = InputResourceName,
        };

        return harvestJobResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.HarvestJob result)
    {
        base.CreateChildren(result);

        result.S3Destination ??= S3DestinationFactory?.Build();
    }

} // End Of Class

public static class HarvestJobFactoryExtensions
{
    public static CombinedResult<HarvestJobFactory, InnerHarvestJobS3DestinationFactory> WithS3Destination(this HarvestJobFactory parentFactory, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null)
    {
        parentFactory.S3DestinationFactory = new InnerHarvestJobS3DestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DestinationFactory);
    }

    public static CombinedResult<HarvestJobFactory, T1, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<HarvestJobFactory, T1> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HarvestJobFactory, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<T1, HarvestJobFactory> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<HarvestJobFactory, T1, T2, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<HarvestJobFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HarvestJobFactory, T2, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, HarvestJobFactory, T2> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HarvestJobFactory, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, T2, HarvestJobFactory> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<HarvestJobFactory, T1, T2, T3, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<HarvestJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HarvestJobFactory, T2, T3, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, HarvestJobFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HarvestJobFactory, T3, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, HarvestJobFactory, T3> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HarvestJobFactory, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, T3, HarvestJobFactory> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<HarvestJobFactory, T1, T2, T3, T4, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<HarvestJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HarvestJobFactory, T2, T3, T4, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, HarvestJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HarvestJobFactory, T3, T4, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, HarvestJobFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HarvestJobFactory, T4, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HarvestJobFactory, T4> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, HarvestJobFactory, InnerHarvestJobS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HarvestJobFactory> combinedResult, Action<Humidifier.MediaPackage.HarvestJobTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T5, subFactoryAction).T2);
}
