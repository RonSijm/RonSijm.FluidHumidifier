// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateOutputsFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.Outputs> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.Outputs>
{

    internal InnerExperimentTemplateExperimentReportS3ConfigurationFactory ExperimentReportS3ConfigurationFactory { get; set; }

    protected override Humidifier.FIS.ExperimentTemplateTypes.Outputs Create()
    {
        var outputsResult = CreateOutputs();
        factoryAction?.Invoke(outputsResult);

        return outputsResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.Outputs CreateOutputs()
    {
        var outputsResult = new Humidifier.FIS.ExperimentTemplateTypes.Outputs();

        return outputsResult;
    }
    public override void CreateChildren(Humidifier.FIS.ExperimentTemplateTypes.Outputs result)
    {
        base.CreateChildren(result);

        result.ExperimentReportS3Configuration ??= ExperimentReportS3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerExperimentTemplateOutputsFactoryExtensions
{
    public static CombinedResult<InnerExperimentTemplateOutputsFactory, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration(this InnerExperimentTemplateOutputsFactory parentFactory, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null)
    {
        parentFactory.ExperimentReportS3ConfigurationFactory = new InnerExperimentTemplateExperimentReportS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExperimentReportS3ConfigurationFactory);
    }

    public static CombinedResult<InnerExperimentTemplateOutputsFactory, T1, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1>(this CombinedResult<InnerExperimentTemplateOutputsFactory, T1> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExperimentTemplateOutputsFactory, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1>(this CombinedResult<T1, InnerExperimentTemplateOutputsFactory> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerExperimentTemplateOutputsFactory, T1, T2, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2>(this CombinedResult<InnerExperimentTemplateOutputsFactory, T1, T2> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExperimentTemplateOutputsFactory, T2, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2>(this CombinedResult<T1, InnerExperimentTemplateOutputsFactory, T2> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExperimentTemplateOutputsFactory, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerExperimentTemplateOutputsFactory> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerExperimentTemplateOutputsFactory, T1, T2, T3, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3>(this CombinedResult<InnerExperimentTemplateOutputsFactory, T1, T2, T3> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExperimentTemplateOutputsFactory, T2, T3, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerExperimentTemplateOutputsFactory, T2, T3> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExperimentTemplateOutputsFactory, T3, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerExperimentTemplateOutputsFactory, T3> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerExperimentTemplateOutputsFactory, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerExperimentTemplateOutputsFactory> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerExperimentTemplateOutputsFactory, T1, T2, T3, T4, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerExperimentTemplateOutputsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerExperimentTemplateOutputsFactory, T2, T3, T4, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerExperimentTemplateOutputsFactory, T2, T3, T4> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerExperimentTemplateOutputsFactory, T3, T4, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerExperimentTemplateOutputsFactory, T3, T4> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerExperimentTemplateOutputsFactory, T4, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerExperimentTemplateOutputsFactory, T4> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerExperimentTemplateOutputsFactory, InnerExperimentTemplateExperimentReportS3ConfigurationFactory> WithExperimentReportS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerExperimentTemplateOutputsFactory> combinedResult, Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentReportS3Configuration(combinedResult.T5, subFactoryAction));
}
