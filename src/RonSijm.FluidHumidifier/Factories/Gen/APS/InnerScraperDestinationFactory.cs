// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperDestinationFactory(Action<Humidifier.APS.ScraperTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.Destination>
{

    internal InnerScraperAmpConfigurationFactory AmpConfigurationFactory { get; set; }

    protected override Humidifier.APS.ScraperTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.APS.ScraperTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.APS.ScraperTypes.Destination();

        return destinationResult;
    }
    public override void CreateChildren(Humidifier.APS.ScraperTypes.Destination result)
    {
        base.CreateChildren(result);

        result.AmpConfiguration ??= AmpConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScraperDestinationFactoryExtensions
{
    public static CombinedResult<InnerScraperDestinationFactory, InnerScraperAmpConfigurationFactory> WithAmpConfiguration(this InnerScraperDestinationFactory parentFactory, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null)
    {
        parentFactory.AmpConfigurationFactory = new InnerScraperAmpConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AmpConfigurationFactory);
    }

    public static CombinedResult<InnerScraperDestinationFactory, T1, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1>(this CombinedResult<InnerScraperDestinationFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperDestinationFactory, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1>(this CombinedResult<T1, InnerScraperDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScraperDestinationFactory, T1, T2, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2>(this CombinedResult<InnerScraperDestinationFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperDestinationFactory, T2, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2>(this CombinedResult<T1, InnerScraperDestinationFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScraperDestinationFactory, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerScraperDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScraperDestinationFactory, T1, T2, T3, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3>(this CombinedResult<InnerScraperDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperDestinationFactory, T2, T3, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerScraperDestinationFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScraperDestinationFactory, T3, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScraperDestinationFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScraperDestinationFactory, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScraperDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScraperDestinationFactory, T1, T2, T3, T4, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerScraperDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScraperDestinationFactory, T2, T3, T4, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScraperDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScraperDestinationFactory, T3, T4, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScraperDestinationFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScraperDestinationFactory, T4, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScraperDestinationFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScraperDestinationFactory, InnerScraperAmpConfigurationFactory> WithAmpConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScraperDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.AmpConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmpConfiguration(combinedResult.T5, subFactoryAction));
}
