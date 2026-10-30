// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateDestinationFactory(Action<Humidifier.IoT.OTAUpdateTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.Destination>
{

    internal InnerOTAUpdateS3DestinationFactory S3DestinationFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.IoT.OTAUpdateTypes.Destination();

        return destinationResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.Destination result)
    {
        base.CreateChildren(result);

        result.S3Destination ??= S3DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateDestinationFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateDestinationFactory, InnerOTAUpdateS3DestinationFactory> WithS3Destination(this InnerOTAUpdateDestinationFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null)
    {
        parentFactory.S3DestinationFactory = new InnerOTAUpdateS3DestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DestinationFactory);
    }

    public static CombinedResult<InnerOTAUpdateDestinationFactory, T1, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<InnerOTAUpdateDestinationFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateDestinationFactory, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<T1, InnerOTAUpdateDestinationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateDestinationFactory, T1, T2, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<InnerOTAUpdateDestinationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateDestinationFactory, T2, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, InnerOTAUpdateDestinationFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateDestinationFactory, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateDestinationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateDestinationFactory, T1, T2, T3, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<InnerOTAUpdateDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateDestinationFactory, T2, T3, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateDestinationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateDestinationFactory, T3, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateDestinationFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateDestinationFactory, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateDestinationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateDestinationFactory, T1, T2, T3, T4, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateDestinationFactory, T2, T3, T4, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateDestinationFactory, T3, T4, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateDestinationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateDestinationFactory, T4, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateDestinationFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateDestinationFactory, InnerOTAUpdateS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateDestinationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T5, subFactoryAction).T2);
}
