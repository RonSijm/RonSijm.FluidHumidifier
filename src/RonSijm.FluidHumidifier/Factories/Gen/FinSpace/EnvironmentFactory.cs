// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FinSpace;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.FinSpace.Environment> factoryAction = null) : ResourceFactory<Humidifier.FinSpace.Environment>(resourceName)
{

    internal InnerEnvironmentFederationParametersFactory FederationParametersFactory { get; set; }

    internal InnerEnvironmentSuperuserParametersFactory SuperuserParametersFactory { get; set; }

    protected override Humidifier.FinSpace.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.FinSpace.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.FinSpace.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.FinSpace.Environment result)
    {
        base.CreateChildren(result);

        result.FederationParameters ??= FederationParametersFactory?.Build();
        result.SuperuserParameters ??= SuperuserParametersFactory?.Build();
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentFederationParametersFactory> WithFederationParameters(this EnvironmentFactory parentFactory, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null)
    {
        parentFactory.FederationParametersFactory = new InnerEnvironmentFederationParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FederationParametersFactory);
    }

    public static CombinedResult<EnvironmentFactory, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters(this EnvironmentFactory parentFactory, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null)
    {
        parentFactory.SuperuserParametersFactory = new InnerEnvironmentSuperuserParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SuperuserParametersFactory);
    }

    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFederationParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFederationParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentFederationParametersFactory> WithFederationParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederationParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentSuperuserParametersFactory> WithSuperuserParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuperuserParameters(combinedResult.T5, subFactoryAction));
}
