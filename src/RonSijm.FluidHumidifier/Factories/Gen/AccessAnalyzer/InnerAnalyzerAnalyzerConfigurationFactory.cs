// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerAnalyzerConfigurationFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration>
{

    internal InnerAnalyzerUnusedAccessConfigurationFactory UnusedAccessConfigurationFactory { get; set; }

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration Create()
    {
        var analyzerConfigurationResult = CreateAnalyzerConfiguration();
        factoryAction?.Invoke(analyzerConfigurationResult);

        return analyzerConfigurationResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration CreateAnalyzerConfiguration()
    {
        var analyzerConfigurationResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration();

        return analyzerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration result)
    {
        base.CreateChildren(result);

        result.UnusedAccessConfiguration ??= UnusedAccessConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAnalyzerAnalyzerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration(this InnerAnalyzerAnalyzerConfigurationFactory parentFactory, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null)
    {
        parentFactory.UnusedAccessConfigurationFactory = new InnerAnalyzerUnusedAccessConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UnusedAccessConfigurationFactory);
    }

    public static CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1>(this CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1>(this CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2>(this CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, T2, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2>(this CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalyzerAnalyzerConfigurationFactory, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAnalyzerAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, T2, T3, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3>(this CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, T2, T3, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalyzerAnalyzerConfigurationFactory, T3, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalyzerAnalyzerConfigurationFactory, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalyzerAnalyzerConfigurationFactory, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalyzerAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, T2, T3, T4, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAnalyzerAnalyzerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, T2, T3, T4, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalyzerAnalyzerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalyzerAnalyzerConfigurationFactory, T3, T4, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalyzerAnalyzerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalyzerAnalyzerConfigurationFactory, T4, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalyzerAnalyzerConfigurationFactory, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalyzerAnalyzerConfigurationFactory, InnerAnalyzerUnusedAccessConfigurationFactory> WithUnusedAccessConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalyzerAnalyzerConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnusedAccessConfiguration(combinedResult.T5, subFactoryAction));
}
