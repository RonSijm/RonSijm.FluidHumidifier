// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class EnvironmentBlueprintConfigurationFactory(string resourceName = null, Action<Humidifier.DataZone.EnvironmentBlueprintConfiguration> factoryAction = null) : ResourceFactory<Humidifier.DataZone.EnvironmentBlueprintConfiguration>(resourceName)
{

    internal List<InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> RegionalParametersFactories { get; set; } = [];

    protected override Humidifier.DataZone.EnvironmentBlueprintConfiguration Create()
    {
        var environmentBlueprintConfigurationResult = CreateEnvironmentBlueprintConfiguration();
        factoryAction?.Invoke(environmentBlueprintConfigurationResult);

        return environmentBlueprintConfigurationResult;
    }

    private Humidifier.DataZone.EnvironmentBlueprintConfiguration CreateEnvironmentBlueprintConfiguration()
    {
        var environmentBlueprintConfigurationResult = new Humidifier.DataZone.EnvironmentBlueprintConfiguration
        {
            GivenName = InputResourceName,
        };

        return environmentBlueprintConfigurationResult;
    }
    public override void CreateChildren(Humidifier.DataZone.EnvironmentBlueprintConfiguration result)
    {
        base.CreateChildren(result);

        result.RegionalParameters = RegionalParametersFactories.Any() ? RegionalParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnvironmentBlueprintConfigurationFactoryExtensions
{
    public static CombinedResult<EnvironmentBlueprintConfigurationFactory, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters(this EnvironmentBlueprintConfigurationFactory parentFactory, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentBlueprintConfigurationRegionalParameterFactory(subFactoryAction);
        parentFactory.RegionalParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1>(this CombinedResult<EnvironmentBlueprintConfigurationFactory, T1> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegionalParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1>(this CombinedResult<T1, EnvironmentBlueprintConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegionalParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, T2, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2>(this CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, T2, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2>(this CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentBlueprintConfigurationFactory, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2>(this CombinedResult<T1, T2, EnvironmentBlueprintConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, T2, T3, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3>(this CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, T2, T3, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3>(this CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentBlueprintConfigurationFactory, T3, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentBlueprintConfigurationFactory, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentBlueprintConfigurationFactory, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentBlueprintConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, T2, T3, T4, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3, T4>(this CombinedResult<EnvironmentBlueprintConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, T2, T3, T4, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentBlueprintConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentBlueprintConfigurationFactory, T3, T4, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentBlueprintConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentBlueprintConfigurationFactory, T4, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentBlueprintConfigurationFactory, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentBlueprintConfigurationFactory, InnerEnvironmentBlueprintConfigurationRegionalParameterFactory> WithRegionalParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentBlueprintConfigurationFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionalParameters(combinedResult.T5, subFactoryAction));
}
