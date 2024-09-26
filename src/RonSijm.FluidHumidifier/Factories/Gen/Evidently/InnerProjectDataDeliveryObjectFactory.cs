// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerProjectDataDeliveryObjectFactory(Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.ProjectTypes.DataDeliveryObject>
{

    internal InnerProjectS3DestinationFactory S3Factory { get; set; }

    protected override Humidifier.Evidently.ProjectTypes.DataDeliveryObject Create()
    {
        var dataDeliveryObjectResult = CreateDataDeliveryObject();
        factoryAction?.Invoke(dataDeliveryObjectResult);

        return dataDeliveryObjectResult;
    }

    private Humidifier.Evidently.ProjectTypes.DataDeliveryObject CreateDataDeliveryObject()
    {
        var dataDeliveryObjectResult = new Humidifier.Evidently.ProjectTypes.DataDeliveryObject();

        return dataDeliveryObjectResult;
    }
    public override void CreateChildren(Humidifier.Evidently.ProjectTypes.DataDeliveryObject result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerProjectDataDeliveryObjectFactoryExtensions
{
    public static CombinedResult<InnerProjectDataDeliveryObjectFactory, InnerProjectS3DestinationFactory> WithS3(this InnerProjectDataDeliveryObjectFactory parentFactory, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerProjectS3DestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, InnerProjectS3DestinationFactory> WithS3<T1>(this CombinedResult<InnerProjectDataDeliveryObjectFactory, T1> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, InnerProjectS3DestinationFactory> WithS3<T1>(this CombinedResult<T1, InnerProjectDataDeliveryObjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, T2, InnerProjectS3DestinationFactory> WithS3<T1, T2>(this CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, T2, InnerProjectS3DestinationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, T2> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectDataDeliveryObjectFactory, InnerProjectS3DestinationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerProjectDataDeliveryObjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, T2, T3, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, T2, T3, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectDataDeliveryObjectFactory, T3, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectDataDeliveryObjectFactory, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectDataDeliveryObjectFactory, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectDataDeliveryObjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, T2, T3, T4, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerProjectDataDeliveryObjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, T2, T3, T4, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectDataDeliveryObjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectDataDeliveryObjectFactory, T3, T4, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectDataDeliveryObjectFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectDataDeliveryObjectFactory, T4, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectDataDeliveryObjectFactory, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectDataDeliveryObjectFactory, InnerProjectS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectDataDeliveryObjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
