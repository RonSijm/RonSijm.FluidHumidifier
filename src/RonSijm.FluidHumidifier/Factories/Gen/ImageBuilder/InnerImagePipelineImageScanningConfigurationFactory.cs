// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineImageScanningConfigurationFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration>
{

    internal InnerImagePipelineEcrConfigurationFactory EcrConfigurationFactory { get; set; }

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration Create()
    {
        var imageScanningConfigurationResult = CreateImageScanningConfiguration();
        factoryAction?.Invoke(imageScanningConfigurationResult);

        return imageScanningConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration CreateImageScanningConfiguration()
    {
        var imageScanningConfigurationResult = new Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration();

        return imageScanningConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.ImagePipelineTypes.ImageScanningConfiguration result)
    {
        base.CreateChildren(result);

        result.EcrConfiguration ??= EcrConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerImagePipelineImageScanningConfigurationFactoryExtensions
{
    public static CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration(this InnerImagePipelineImageScanningConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null)
    {
        parentFactory.EcrConfigurationFactory = new InnerImagePipelineEcrConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EcrConfigurationFactory);
    }

    public static CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1>(this CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1>(this CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, T2, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2>(this CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, T2, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2>(this CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImagePipelineImageScanningConfigurationFactory, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerImagePipelineImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, T2, T3, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, T2, T3, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImagePipelineImageScanningConfigurationFactory, T3, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerImagePipelineImageScanningConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImagePipelineImageScanningConfigurationFactory, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerImagePipelineImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, T2, T3, T4, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerImagePipelineImageScanningConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, T2, T3, T4, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerImagePipelineImageScanningConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerImagePipelineImageScanningConfigurationFactory, T3, T4, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerImagePipelineImageScanningConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerImagePipelineImageScanningConfigurationFactory, T4, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerImagePipelineImageScanningConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerImagePipelineImageScanningConfigurationFactory, InnerImagePipelineEcrConfigurationFactory> WithEcrConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerImagePipelineImageScanningConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrConfiguration(combinedResult.T5, subFactoryAction));
}
