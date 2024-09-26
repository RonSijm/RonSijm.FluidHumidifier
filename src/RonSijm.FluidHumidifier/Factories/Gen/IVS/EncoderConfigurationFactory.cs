// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class EncoderConfigurationFactory(string resourceName = null, Action<Humidifier.IVS.EncoderConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IVS.EncoderConfiguration>(resourceName)
{

    internal InnerEncoderConfigurationVideoFactory VideoFactory { get; set; }

    protected override Humidifier.IVS.EncoderConfiguration Create()
    {
        var encoderConfigurationResult = CreateEncoderConfiguration();
        factoryAction?.Invoke(encoderConfigurationResult);

        return encoderConfigurationResult;
    }

    private Humidifier.IVS.EncoderConfiguration CreateEncoderConfiguration()
    {
        var encoderConfigurationResult = new Humidifier.IVS.EncoderConfiguration
        {
            GivenName = InputResourceName,
        };

        return encoderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.EncoderConfiguration result)
    {
        base.CreateChildren(result);

        result.Video ??= VideoFactory?.Build();
    }

} // End Of Class

public static class EncoderConfigurationFactoryExtensions
{
    public static CombinedResult<EncoderConfigurationFactory, InnerEncoderConfigurationVideoFactory> WithVideo(this EncoderConfigurationFactory parentFactory, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null)
    {
        parentFactory.VideoFactory = new InnerEncoderConfigurationVideoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VideoFactory);
    }

    public static CombinedResult<EncoderConfigurationFactory, T1, InnerEncoderConfigurationVideoFactory> WithVideo<T1>(this CombinedResult<EncoderConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EncoderConfigurationFactory, InnerEncoderConfigurationVideoFactory> WithVideo<T1>(this CombinedResult<T1, EncoderConfigurationFactory> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EncoderConfigurationFactory, T1, T2, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2>(this CombinedResult<EncoderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EncoderConfigurationFactory, T2, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2>(this CombinedResult<T1, EncoderConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EncoderConfigurationFactory, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2>(this CombinedResult<T1, T2, EncoderConfigurationFactory> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EncoderConfigurationFactory, T1, T2, T3, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3>(this CombinedResult<EncoderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EncoderConfigurationFactory, T2, T3, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3>(this CombinedResult<T1, EncoderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EncoderConfigurationFactory, T3, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3>(this CombinedResult<T1, T2, EncoderConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EncoderConfigurationFactory, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3>(this CombinedResult<T1, T2, T3, EncoderConfigurationFactory> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EncoderConfigurationFactory, T1, T2, T3, T4, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3, T4>(this CombinedResult<EncoderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EncoderConfigurationFactory, T2, T3, T4, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3, T4>(this CombinedResult<T1, EncoderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EncoderConfigurationFactory, T3, T4, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3, T4>(this CombinedResult<T1, T2, EncoderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EncoderConfigurationFactory, T4, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EncoderConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EncoderConfigurationFactory, InnerEncoderConfigurationVideoFactory> WithVideo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EncoderConfigurationFactory> combinedResult, Action<Humidifier.IVS.EncoderConfigurationTypes.Video> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideo(combinedResult.T5, subFactoryAction));
}
