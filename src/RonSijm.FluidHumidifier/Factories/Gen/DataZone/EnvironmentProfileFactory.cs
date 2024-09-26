// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class EnvironmentProfileFactory(string resourceName = null, Action<Humidifier.DataZone.EnvironmentProfile> factoryAction = null) : ResourceFactory<Humidifier.DataZone.EnvironmentProfile>(resourceName)
{

    internal List<InnerEnvironmentProfileEnvironmentParameterFactory> UserParametersFactories { get; set; } = [];

    protected override Humidifier.DataZone.EnvironmentProfile Create()
    {
        var environmentProfileResult = CreateEnvironmentProfile();
        factoryAction?.Invoke(environmentProfileResult);

        return environmentProfileResult;
    }

    private Humidifier.DataZone.EnvironmentProfile CreateEnvironmentProfile()
    {
        var environmentProfileResult = new Humidifier.DataZone.EnvironmentProfile
        {
            GivenName = InputResourceName,
        };

        return environmentProfileResult;
    }
    public override void CreateChildren(Humidifier.DataZone.EnvironmentProfile result)
    {
        base.CreateChildren(result);

        result.UserParameters = UserParametersFactories.Any() ? UserParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnvironmentProfileFactoryExtensions
{
    public static CombinedResult<EnvironmentProfileFactory, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters(this EnvironmentProfileFactory parentFactory, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentProfileEnvironmentParameterFactory(subFactoryAction);
        parentFactory.UserParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentProfileFactory, T1, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1>(this CombinedResult<EnvironmentProfileFactory, T1> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentProfileFactory, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1>(this CombinedResult<T1, EnvironmentProfileFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentProfileFactory, T1, T2, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<EnvironmentProfileFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentProfileFactory, T2, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<T1, EnvironmentProfileFactory, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentProfileFactory, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2>(this CombinedResult<T1, T2, EnvironmentProfileFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentProfileFactory, T1, T2, T3, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<EnvironmentProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentProfileFactory, T2, T3, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, EnvironmentProfileFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentProfileFactory, T3, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentProfileFactory, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentProfileFactory, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentProfileFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentProfileFactory, T1, T2, T3, T4, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<EnvironmentProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentProfileFactory, T2, T3, T4, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentProfileFactory, T3, T4, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentProfileFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentProfileFactory, T4, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentProfileFactory, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentProfileFactory, InnerEnvironmentProfileEnvironmentParameterFactory> WithUserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentProfileFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserParameters(combinedResult.T5, subFactoryAction));
}
