// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class EnvironmentActionsFactory(string resourceName = null, Action<Humidifier.DataZone.EnvironmentActions> factoryAction = null) : ResourceFactory<Humidifier.DataZone.EnvironmentActions>(resourceName)
{

    internal InnerEnvironmentActionsAwsConsoleLinkParametersFactory ParametersFactory { get; set; }

    protected override Humidifier.DataZone.EnvironmentActions Create()
    {
        var environmentActionsResult = CreateEnvironmentActions();
        factoryAction?.Invoke(environmentActionsResult);

        return environmentActionsResult;
    }

    private Humidifier.DataZone.EnvironmentActions CreateEnvironmentActions()
    {
        var environmentActionsResult = new Humidifier.DataZone.EnvironmentActions
        {
            GivenName = InputResourceName,
        };

        return environmentActionsResult;
    }
    public override void CreateChildren(Humidifier.DataZone.EnvironmentActions result)
    {
        base.CreateChildren(result);

        result.Parameters ??= ParametersFactory?.Build();
    }

} // End Of Class

public static class EnvironmentActionsFactoryExtensions
{
    public static CombinedResult<EnvironmentActionsFactory, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters(this EnvironmentActionsFactory parentFactory, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null)
    {
        parentFactory.ParametersFactory = new InnerEnvironmentActionsAwsConsoleLinkParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersFactory);
    }

    public static CombinedResult<EnvironmentActionsFactory, T1, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1>(this CombinedResult<EnvironmentActionsFactory, T1> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentActionsFactory, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1>(this CombinedResult<T1, EnvironmentActionsFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentActionsFactory, T1, T2, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2>(this CombinedResult<EnvironmentActionsFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentActionsFactory, T2, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, EnvironmentActionsFactory, T2> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentActionsFactory, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, EnvironmentActionsFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentActionsFactory, T1, T2, T3, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<EnvironmentActionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentActionsFactory, T2, T3, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, EnvironmentActionsFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentActionsFactory, T3, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentActionsFactory, T3> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentActionsFactory, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentActionsFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentActionsFactory, T1, T2, T3, T4, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<EnvironmentActionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentActionsFactory, T2, T3, T4, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentActionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentActionsFactory, T3, T4, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentActionsFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentActionsFactory, T4, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentActionsFactory, T4> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentActionsFactory, InnerEnvironmentActionsAwsConsoleLinkParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentActionsFactory> combinedResult, Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}
