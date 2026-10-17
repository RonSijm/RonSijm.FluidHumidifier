// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class IdentitySourceFactory(string resourceName = null, Action<Humidifier.MPA.IdentitySource> factoryAction = null) : ResourceFactory<Humidifier.MPA.IdentitySource>(resourceName)
{

    internal InnerIdentitySourceIdentitySourceParametersFactory IdentitySourceParametersFactory { get; set; }

    protected override Humidifier.MPA.IdentitySource Create()
    {
        var identitySourceResult = CreateIdentitySource();
        factoryAction?.Invoke(identitySourceResult);

        return identitySourceResult;
    }

    private Humidifier.MPA.IdentitySource CreateIdentitySource()
    {
        var identitySourceResult = new Humidifier.MPA.IdentitySource
        {
            GivenName = InputResourceName,
        };

        return identitySourceResult;
    }
    public override void CreateChildren(Humidifier.MPA.IdentitySource result)
    {
        base.CreateChildren(result);

        result.IdentitySourceParameters ??= IdentitySourceParametersFactory?.Build();
    }

} // End Of Class

public static class IdentitySourceFactoryExtensions
{
    public static CombinedResult<IdentitySourceFactory, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters(this IdentitySourceFactory parentFactory, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null)
    {
        parentFactory.IdentitySourceParametersFactory = new InnerIdentitySourceIdentitySourceParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentitySourceParametersFactory);
    }

    public static CombinedResult<IdentitySourceFactory, T1, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1>(this CombinedResult<IdentitySourceFactory, T1> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IdentitySourceFactory, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1>(this CombinedResult<T1, IdentitySourceFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IdentitySourceFactory, T1, T2, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2>(this CombinedResult<IdentitySourceFactory, T1, T2> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IdentitySourceFactory, T2, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2>(this CombinedResult<T1, IdentitySourceFactory, T2> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IdentitySourceFactory, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2>(this CombinedResult<T1, T2, IdentitySourceFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IdentitySourceFactory, T1, T2, T3, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3>(this CombinedResult<IdentitySourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IdentitySourceFactory, T2, T3, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3>(this CombinedResult<T1, IdentitySourceFactory, T2, T3> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IdentitySourceFactory, T3, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3>(this CombinedResult<T1, T2, IdentitySourceFactory, T3> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IdentitySourceFactory, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdentitySourceFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IdentitySourceFactory, T1, T2, T3, T4, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3, T4>(this CombinedResult<IdentitySourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IdentitySourceFactory, T2, T3, T4, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, IdentitySourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IdentitySourceFactory, T3, T4, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdentitySourceFactory, T3, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IdentitySourceFactory, T4, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdentitySourceFactory, T4> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IdentitySourceFactory, InnerIdentitySourceIdentitySourceParametersFactory> WithIdentitySourceParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdentitySourceFactory> combinedResult, Action<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentitySourceParameters(combinedResult.T5, subFactoryAction).T2);
}
