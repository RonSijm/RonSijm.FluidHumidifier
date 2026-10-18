// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerApplicationApplicationConfigFactory(Action<Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig>
{

    internal InnerApplicationContactHandlingFactory ContactHandlingFactory { get; set; }

    protected override Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig Create()
    {
        var applicationConfigResult = CreateApplicationConfig();
        factoryAction?.Invoke(applicationConfigResult);

        return applicationConfigResult;
    }

    private Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig CreateApplicationConfig()
    {
        var applicationConfigResult = new Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig();

        return applicationConfigResult;
    }
    public override void CreateChildren(Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig result)
    {
        base.CreateChildren(result);

        result.ContactHandling ??= ContactHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationApplicationConfigFactoryExtensions
{
    public static CombinedResult<InnerApplicationApplicationConfigFactory, InnerApplicationContactHandlingFactory> WithContactHandling(this InnerApplicationApplicationConfigFactory parentFactory, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null)
    {
        parentFactory.ContactHandlingFactory = new InnerApplicationContactHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContactHandlingFactory);
    }

    public static CombinedResult<InnerApplicationApplicationConfigFactory, T1, InnerApplicationContactHandlingFactory> WithContactHandling<T1>(this CombinedResult<InnerApplicationApplicationConfigFactory, T1> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithContactHandling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationApplicationConfigFactory, InnerApplicationContactHandlingFactory> WithContactHandling<T1>(this CombinedResult<T1, InnerApplicationApplicationConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithContactHandling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationApplicationConfigFactory, T1, T2, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2>(this CombinedResult<InnerApplicationApplicationConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationApplicationConfigFactory, T2, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2>(this CombinedResult<T1, InnerApplicationApplicationConfigFactory, T2> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationApplicationConfigFactory, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2>(this CombinedResult<T1, T2, InnerApplicationApplicationConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationApplicationConfigFactory, T1, T2, T3, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3>(this CombinedResult<InnerApplicationApplicationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationApplicationConfigFactory, T2, T3, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3>(this CombinedResult<T1, InnerApplicationApplicationConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationApplicationConfigFactory, T3, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationApplicationConfigFactory, T3> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationConfigFactory, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerApplicationApplicationConfigFactory, T1, T2, T3, T4, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3, T4>(this CombinedResult<InnerApplicationApplicationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApplicationApplicationConfigFactory, T2, T3, T4, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationApplicationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApplicationApplicationConfigFactory, T3, T4, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationApplicationConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationConfigFactory, T4, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationConfigFactory, T4> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationConfigFactory, InnerApplicationContactHandlingFactory> WithContactHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationConfigFactory> combinedResult, Action<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContactHandling(combinedResult.T5, subFactoryAction).T2);
}
