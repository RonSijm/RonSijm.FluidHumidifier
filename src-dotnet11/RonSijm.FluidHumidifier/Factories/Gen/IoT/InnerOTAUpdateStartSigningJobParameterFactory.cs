// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateStartSigningJobParameterFactory(Action<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter>
{

    internal InnerOTAUpdateDestinationFactory DestinationFactory { get; set; }

    internal InnerOTAUpdateSigningProfileParameterFactory SigningProfileParameterFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter Create()
    {
        var startSigningJobParameterResult = CreateStartSigningJobParameter();
        factoryAction?.Invoke(startSigningJobParameterResult);

        return startSigningJobParameterResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter CreateStartSigningJobParameter()
    {
        var startSigningJobParameterResult = new Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter();

        return startSigningJobParameterResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.StartSigningJobParameter result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
        result.SigningProfileParameter ??= SigningProfileParameterFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateStartSigningJobParameterFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateDestinationFactory> WithDestination(this InnerOTAUpdateStartSigningJobParameterFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerOTAUpdateDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter(this InnerOTAUpdateStartSigningJobParameterFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null)
    {
        parentFactory.SigningProfileParameterFactory = new InnerOTAUpdateSigningProfileParameterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SigningProfileParameterFactory);
    }

    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, InnerOTAUpdateDestinationFactory> WithDestination<T1>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3, T4, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3, T4, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3, T4, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory, T4, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3, T4, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateStartSigningJobParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3, T4, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateStartSigningJobParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3, T4, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateStartSigningJobParameterFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory, T4, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateStartSigningJobParameterFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory, InnerOTAUpdateSigningProfileParameterFactory> WithSigningProfileParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateStartSigningJobParameterFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSigningProfileParameter(combinedResult.T5, subFactoryAction).T2);
}
