// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageImageScanningConfigurationFactory(Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration>
{

    internal InnerImageEcrConfigurationFactory EcrConfigurationFactory { get; set; }

    protected override Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration Create()
    {
        var imageScanningConfigurationResult = CreateImageScanningConfiguration();
        factoryAction?.Invoke(imageScanningConfigurationResult);

        return imageScanningConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration CreateImageScanningConfiguration()
    {
        var imageScanningConfigurationResult = new Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration();

        return imageScanningConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration result)
    {
        base.CreateChildren(result);

        result.EcrConfiguration ??= EcrConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerImageImageScanningConfigurationFactoryExtensions
{
    public static CombinedResult<InnerImageImageScanningConfigurationFactory, InnerImageEcrConfigurationFactory> WithEcrConfiguration(this InnerImageImageScanningConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null)
    {
        parentFactory.EcrConfigurationFactory = new InnerImageEcrConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EcrConfigurationFactory);
    }

    public static CombinedResult<InnerImageImageScanningConfigurationFactory, T1, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1>(this CombinedResult<InnerImageImageScanningConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageImageScanningConfigurationFactory, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1>(this CombinedResult<T1, InnerImageImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerImageImageScanningConfigurationFactory, T1, T2, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2>(this CombinedResult<InnerImageImageScanningConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageImageScanningConfigurationFactory, T2, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2>(this CombinedResult<T1, InnerImageImageScanningConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageImageScanningConfigurationFactory, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerImageImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerImageImageScanningConfigurationFactory, T1, T2, T3, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<InnerImageImageScanningConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageImageScanningConfigurationFactory, T2, T3, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerImageImageScanningConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageImageScanningConfigurationFactory, T3, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerImageImageScanningConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImageImageScanningConfigurationFactory, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerImageImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerImageImageScanningConfigurationFactory, T1, T2, T3, T4, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerImageImageScanningConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImageImageScanningConfigurationFactory, T2, T3, T4, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerImageImageScanningConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImageImageScanningConfigurationFactory, T3, T4, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerImageImageScanningConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImageImageScanningConfigurationFactory, T4, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerImageImageScanningConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerImageImageScanningConfigurationFactory, InnerImageEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerImageImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T5, subFactoryAction));
}
