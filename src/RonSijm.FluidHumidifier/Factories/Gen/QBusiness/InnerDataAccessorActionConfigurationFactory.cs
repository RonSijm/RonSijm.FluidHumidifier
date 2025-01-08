// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorActionConfigurationFactory(Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration>
{

    internal InnerDataAccessorActionFilterConfigurationFactory FilterConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration Create()
    {
        var actionConfigurationResult = CreateActionConfiguration();
        factoryAction?.Invoke(actionConfigurationResult);

        return actionConfigurationResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration CreateActionConfiguration()
    {
        var actionConfigurationResult = new Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration();

        return actionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration result)
    {
        base.CreateChildren(result);

        result.FilterConfiguration ??= FilterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataAccessorActionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataAccessorActionConfigurationFactory, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration(this InnerDataAccessorActionConfigurationFactory parentFactory, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.FilterConfigurationFactory = new InnerDataAccessorActionFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterConfigurationFactory);
    }

    public static CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<InnerDataAccessorActionConfigurationFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<T1, InnerDataAccessorActionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, T2, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, T2, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorActionConfigurationFactory, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataAccessorActionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, T2, T3, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, T2, T3, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorActionConfigurationFactory, T3, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAccessorActionConfigurationFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataAccessorActionConfigurationFactory, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAccessorActionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, T2, T3, T4, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataAccessorActionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, T2, T3, T4, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAccessorActionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorActionConfigurationFactory, T3, T4, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAccessorActionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataAccessorActionConfigurationFactory, T4, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAccessorActionConfigurationFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataAccessorActionConfigurationFactory, InnerDataAccessorActionFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAccessorActionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T5, subFactoryAction));
}
