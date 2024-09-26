// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.DataZone.Environment> factoryAction = null) : ResourceFactory<Humidifier.DataZone.Environment>(resourceName)
{

    internal List<InnerEnvironmentEnvironmentParameterFactory> UserParametersFactories { get; set; } = [];

    protected override Humidifier.DataZone.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.DataZone.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.DataZone.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.DataZone.Environment result)
    {
        base.CreateChildren(result);

        result.UserParameters = UserParametersFactories.Any() ? UserParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters(this EnvironmentFactory parentFactory, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentEnvironmentParameterFactory(subFactoryAction);
        parentFactory.UserParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T5, subFactoryAction));
}
