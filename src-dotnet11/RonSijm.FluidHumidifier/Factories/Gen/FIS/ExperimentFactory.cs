// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class ExperimentFactory(string resourceName = null, Action<Humidifier.FIS.Experiment> factoryAction = null) : ResourceFactory<Humidifier.FIS.Experiment>(resourceName)
{

    internal InnerExperimentExperimentOptionsFactory ExperimentOptionsFactory { get; set; }

    protected override Humidifier.FIS.Experiment Create()
    {
        var experimentResult = CreateExperiment();
        factoryAction?.Invoke(experimentResult);

        return experimentResult;
    }

    private Humidifier.FIS.Experiment CreateExperiment()
    {
        var experimentResult = new Humidifier.FIS.Experiment
        {
            GivenName = InputResourceName,
        };

        return experimentResult;
    }
    public override void CreateChildren(Humidifier.FIS.Experiment result)
    {
        base.CreateChildren(result);

        result.ExperimentOptions ??= ExperimentOptionsFactory?.Build();
    }

} // End Of Class

public static class ExperimentFactoryExtensions
{
    public static CombinedResult<ExperimentFactory, InnerExperimentExperimentOptionsFactory> WithExperimentOptions(this ExperimentFactory parentFactory, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null)
    {
        parentFactory.ExperimentOptionsFactory = new InnerExperimentExperimentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExperimentOptionsFactory);
    }

    public static CombinedResult<ExperimentFactory, T1, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1>(this CombinedResult<ExperimentFactory, T1> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExperimentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1>(this CombinedResult<T1, ExperimentFactory> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExperimentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExperimentFactory, T1, T2, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2>(this CombinedResult<ExperimentFactory, T1, T2> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, T2, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2>(this CombinedResult<T1, ExperimentFactory, T2> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentFactory, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2>(this CombinedResult<T1, T2, ExperimentFactory> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExperimentFactory, T1, T2, T3, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3>(this CombinedResult<ExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, T2, T3, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3>(this CombinedResult<T1, ExperimentFactory, T2, T3> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentFactory, T3, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentFactory, T3> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentFactory, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentFactory> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExperimentFactory, T1, T2, T3, T4, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3, T4>(this CombinedResult<ExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentFactory, T2, T3, T4, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentFactory, T3, T4, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentFactory, T3, T4> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentFactory, T4, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentFactory, T4> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExperimentFactory, InnerExperimentExperimentOptionsFactory> WithExperimentOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentFactory> combinedResult, Action<Humidifier.FIS.ExperimentTypes.ExperimentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExperimentOptions(combinedResult.T5, subFactoryAction).T2);
}
