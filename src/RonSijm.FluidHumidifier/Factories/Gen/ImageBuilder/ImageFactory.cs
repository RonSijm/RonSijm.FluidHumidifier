// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class ImageFactory(string resourceName = null, Action<Humidifier.ImageBuilder.Image> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.Image>(resourceName)
{

    internal List<InnerImageWorkflowConfigurationFactory> WorkflowsFactories { get; set; } = [];

    internal InnerImageImageScanningConfigurationFactory ImageScanningConfigurationFactory { get; set; }

    internal InnerImageImageTestsConfigurationFactory ImageTestsConfigurationFactory { get; set; }

    protected override Humidifier.ImageBuilder.Image Create()
    {
        var imageResult = CreateImage();
        factoryAction?.Invoke(imageResult);

        return imageResult;
    }

    private Humidifier.ImageBuilder.Image CreateImage()
    {
        var imageResult = new Humidifier.ImageBuilder.Image
        {
            GivenName = InputResourceName,
        };

        return imageResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.Image result)
    {
        base.CreateChildren(result);

        result.Workflows = WorkflowsFactories.Any() ? WorkflowsFactories.Select(x => x.Build()).ToList() : null;
        result.ImageScanningConfiguration ??= ImageScanningConfigurationFactory?.Build();
        result.ImageTestsConfiguration ??= ImageTestsConfigurationFactory?.Build();
    }

} // End Of Class

public static class ImageFactoryExtensions
{
    public static CombinedResult<ImageFactory, InnerImageWorkflowConfigurationFactory> WithWorkflows(this ImageFactory parentFactory, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null)
    {
        var factory = new InnerImageWorkflowConfigurationFactory(subFactoryAction);
        parentFactory.WorkflowsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ImageFactory, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration(this ImageFactory parentFactory, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null)
    {
        parentFactory.ImageScanningConfigurationFactory = new InnerImageImageScanningConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImageScanningConfigurationFactory);
    }

    public static CombinedResult<ImageFactory, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration(this ImageFactory parentFactory, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null)
    {
        parentFactory.ImageTestsConfigurationFactory = new InnerImageImageTestsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImageTestsConfigurationFactory);
    }

    public static CombinedResult<ImageFactory, T1, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1>(this CombinedResult<ImageFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1>(this CombinedResult<T1, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2>(this CombinedResult<ImageFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2>(this CombinedResult<T1, ImageFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2>(this CombinedResult<T1, T2, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, T3, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<ImageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, T3, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<T1, ImageFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, T3, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<T1, T2, ImageFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageFactory, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, T3, T4, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<ImageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, T3, T4, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, ImageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, T3, T4, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageFactory, T4, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ImageFactory, InnerImageWorkflowConfigurationFactory> WithWorkflows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkflows(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1>(this CombinedResult<ImageFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1>(this CombinedResult<T1, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2>(this CombinedResult<ImageFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2>(this CombinedResult<T1, ImageFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2>(this CombinedResult<T1, T2, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, T3, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3>(this CombinedResult<ImageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, T3, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3>(this CombinedResult<T1, ImageFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, T3, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ImageFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageFactory, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, T3, T4, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3, T4>(this CombinedResult<ImageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, T3, T4, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ImageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, T3, T4, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageFactory, T4, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ImageFactory, InnerImageImageScanningConfigurationFactory> WithImageScanningConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageScanningConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1>(this CombinedResult<ImageFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1>(this CombinedResult<T1, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2>(this CombinedResult<ImageFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2>(this CombinedResult<T1, ImageFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2>(this CombinedResult<T1, T2, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, T3, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3>(this CombinedResult<ImageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, T3, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3>(this CombinedResult<T1, ImageFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, T3, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ImageFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageFactory, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ImageFactory, T1, T2, T3, T4, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3, T4>(this CombinedResult<ImageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageFactory, T2, T3, T4, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ImageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageFactory, T3, T4, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageFactory, T4, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ImageFactory, InnerImageImageTestsConfigurationFactory> WithImageTestsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageFactory> combinedResult, Action<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageTestsConfiguration(combinedResult.T5, subFactoryAction));
}
