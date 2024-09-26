// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerCustomPluginCustomPluginLocationFactory(Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation>
{

    internal InnerCustomPluginS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation Create()
    {
        var customPluginLocationResult = CreateCustomPluginLocation();
        factoryAction?.Invoke(customPluginLocationResult);

        return customPluginLocationResult;
    }

    private Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation CreateCustomPluginLocation()
    {
        var customPluginLocationResult = new Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation();

        return customPluginLocationResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerCustomPluginCustomPluginLocationFactoryExtensions
{
    public static CombinedResult<InnerCustomPluginCustomPluginLocationFactory, InnerCustomPluginS3LocationFactory> WithS3Location(this InnerCustomPluginCustomPluginLocationFactory parentFactory, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerCustomPluginS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, InnerCustomPluginS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, InnerCustomPluginS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, T2, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, T2, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCustomPluginCustomPluginLocationFactory, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerCustomPluginCustomPluginLocationFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, T2, T3, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, T2, T3, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCustomPluginCustomPluginLocationFactory, T3, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerCustomPluginCustomPluginLocationFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCustomPluginCustomPluginLocationFactory, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCustomPluginCustomPluginLocationFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, T2, T3, T4, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerCustomPluginCustomPluginLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, T2, T3, T4, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerCustomPluginCustomPluginLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCustomPluginCustomPluginLocationFactory, T3, T4, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCustomPluginCustomPluginLocationFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCustomPluginCustomPluginLocationFactory, T4, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCustomPluginCustomPluginLocationFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCustomPluginCustomPluginLocationFactory, InnerCustomPluginS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCustomPluginCustomPluginLocationFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction));
}
