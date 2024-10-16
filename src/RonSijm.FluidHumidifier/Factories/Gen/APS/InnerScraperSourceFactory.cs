// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperSourceFactory(Action<Humidifier.APS.ScraperTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.Source>
{

    internal InnerScraperEksConfigurationFactory EksConfigurationFactory { get; set; }

    protected override Humidifier.APS.ScraperTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.APS.ScraperTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.APS.ScraperTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.APS.ScraperTypes.Source result)
    {
        base.CreateChildren(result);

        result.EksConfiguration ??= EksConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScraperSourceFactoryExtensions
{
    public static CombinedResult<InnerScraperSourceFactory, InnerScraperEksConfigurationFactory> WithEksConfiguration(this InnerScraperSourceFactory parentFactory, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null)
    {
        parentFactory.EksConfigurationFactory = new InnerScraperEksConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EksConfigurationFactory);
    }

    public static CombinedResult<InnerScraperSourceFactory, T1, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1>(this CombinedResult<InnerScraperSourceFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEksConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperSourceFactory, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1>(this CombinedResult<T1, InnerScraperSourceFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEksConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScraperSourceFactory, T1, T2, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2>(this CombinedResult<InnerScraperSourceFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperSourceFactory, T2, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2>(this CombinedResult<T1, InnerScraperSourceFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScraperSourceFactory, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerScraperSourceFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScraperSourceFactory, T1, T2, T3, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3>(this CombinedResult<InnerScraperSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperSourceFactory, T2, T3, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerScraperSourceFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScraperSourceFactory, T3, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScraperSourceFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScraperSourceFactory, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScraperSourceFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScraperSourceFactory, T1, T2, T3, T4, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerScraperSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperSourceFactory, T2, T3, T4, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScraperSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScraperSourceFactory, T3, T4, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScraperSourceFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScraperSourceFactory, T4, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScraperSourceFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScraperSourceFactory, InnerScraperEksConfigurationFactory> WithEksConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScraperSourceFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.EksConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksConfiguration(combinedResult.T5, subFactoryAction));
}
