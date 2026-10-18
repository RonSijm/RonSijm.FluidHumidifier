// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.SecurityAgent.Application> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.Application>(resourceName)
{

    internal InnerApplicationIdCConfigurationFactory IdCConfigurationFactory { get; set; }

    protected override Humidifier.SecurityAgent.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.SecurityAgent.Application CreateApplication()
    {
        var applicationResult = new Humidifier.SecurityAgent.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.SecurityAgent.Application result)
    {
        base.CreateChildren(result);

        result.IdCConfiguration ??= IdCConfigurationFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration(this ApplicationFactory parentFactory, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null)
    {
        parentFactory.IdCConfigurationFactory = new InnerApplicationIdCConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdCConfigurationFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationIdCConfigurationFactory> WithIdCConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdCConfiguration(combinedResult.T5, subFactoryAction).T2);
}
