// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationInsights;

public class InnerApplicationComponentConfigurationFactory(Action<Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration>
{

    internal InnerApplicationConfigurationDetailsFactory ConfigurationDetailsFactory { get; set; }

    protected override Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration Create()
    {
        var componentConfigurationResult = CreateComponentConfiguration();
        factoryAction?.Invoke(componentConfigurationResult);

        return componentConfigurationResult;
    }

    private Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration CreateComponentConfiguration()
    {
        var componentConfigurationResult = new Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration();

        return componentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ApplicationInsights.ApplicationTypes.ComponentConfiguration result)
    {
        base.CreateChildren(result);

        result.ConfigurationDetails ??= ConfigurationDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationComponentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationComponentConfigurationFactory, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails(this InnerApplicationComponentConfigurationFactory parentFactory, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null)
    {
        parentFactory.ConfigurationDetailsFactory = new InnerApplicationConfigurationDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationDetailsFactory);
    }

    public static CombinedResult<InnerApplicationComponentConfigurationFactory, T1, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1>(this CombinedResult<InnerApplicationComponentConfigurationFactory, T1> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationComponentConfigurationFactory, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1>(this CombinedResult<T1, InnerApplicationComponentConfigurationFactory> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationComponentConfigurationFactory, T1, T2, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2>(this CombinedResult<InnerApplicationComponentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationComponentConfigurationFactory, T2, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2>(this CombinedResult<T1, InnerApplicationComponentConfigurationFactory, T2> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationComponentConfigurationFactory, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2>(this CombinedResult<T1, T2, InnerApplicationComponentConfigurationFactory> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationComponentConfigurationFactory, T1, T2, T3, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3>(this CombinedResult<InnerApplicationComponentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationComponentConfigurationFactory, T2, T3, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3>(this CombinedResult<T1, InnerApplicationComponentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationComponentConfigurationFactory, T3, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationComponentConfigurationFactory, T3> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationComponentConfigurationFactory, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationComponentConfigurationFactory> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationComponentConfigurationFactory, T1, T2, T3, T4, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3, T4>(this CombinedResult<InnerApplicationComponentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationComponentConfigurationFactory, T2, T3, T4, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationComponentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationComponentConfigurationFactory, T3, T4, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationComponentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationComponentConfigurationFactory, T4, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationComponentConfigurationFactory, T4> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationComponentConfigurationFactory, InnerApplicationConfigurationDetailsFactory> WithConfigurationDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationComponentConfigurationFactory> combinedResult, Action<Humidifier.ApplicationInsights.ApplicationTypes.ConfigurationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDetails(combinedResult.T5, subFactoryAction));
}
