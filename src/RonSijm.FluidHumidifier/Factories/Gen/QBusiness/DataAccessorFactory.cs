// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class DataAccessorFactory(string resourceName = null, Action<Humidifier.QBusiness.DataAccessor> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.DataAccessor>(resourceName)
{

    internal List<InnerDataAccessorActionConfigurationFactory> ActionConfigurationsFactories { get; set; } = [];

    protected override Humidifier.QBusiness.DataAccessor Create()
    {
        var dataAccessorResult = CreateDataAccessor();
        factoryAction?.Invoke(dataAccessorResult);

        return dataAccessorResult;
    }

    private Humidifier.QBusiness.DataAccessor CreateDataAccessor()
    {
        var dataAccessorResult = new Humidifier.QBusiness.DataAccessor
        {
            GivenName = InputResourceName,
        };

        return dataAccessorResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataAccessor result)
    {
        base.CreateChildren(result);

        result.ActionConfigurations = ActionConfigurationsFactories.Any() ? ActionConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DataAccessorFactoryExtensions
{
    public static CombinedResult<DataAccessorFactory, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations(this DataAccessorFactory parentFactory, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null)
    {
        var factory = new InnerDataAccessorActionConfigurationFactory(subFactoryAction);
        parentFactory.ActionConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DataAccessorFactory, T1, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1>(this CombinedResult<DataAccessorFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataAccessorFactory, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1>(this CombinedResult<T1, DataAccessorFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataAccessorFactory, T1, T2, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2>(this CombinedResult<DataAccessorFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataAccessorFactory, T2, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2>(this CombinedResult<T1, DataAccessorFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataAccessorFactory, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2>(this CombinedResult<T1, T2, DataAccessorFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataAccessorFactory, T1, T2, T3, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3>(this CombinedResult<DataAccessorFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataAccessorFactory, T2, T3, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3>(this CombinedResult<T1, DataAccessorFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataAccessorFactory, T3, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, DataAccessorFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataAccessorFactory, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataAccessorFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataAccessorFactory, T1, T2, T3, T4, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3, T4>(this CombinedResult<DataAccessorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataAccessorFactory, T2, T3, T4, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, DataAccessorFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataAccessorFactory, T3, T4, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataAccessorFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataAccessorFactory, T4, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataAccessorFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataAccessorFactory, InnerDataAccessorActionConfigurationFactory> WithActionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataAccessorFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.ActionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionConfigurations(combinedResult.T5, subFactoryAction));
}
