// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class ClusterParameterGroupFactory(string resourceName = null, Action<Humidifier.Redshift.ClusterParameterGroup> factoryAction = null) : ResourceFactory<Humidifier.Redshift.ClusterParameterGroup>(resourceName)
{

    internal List<InnerClusterParameterGroupParameterFactory> ParametersFactories { get; set; } = [];

    protected override Humidifier.Redshift.ClusterParameterGroup Create()
    {
        var clusterParameterGroupResult = CreateClusterParameterGroup();
        factoryAction?.Invoke(clusterParameterGroupResult);

        return clusterParameterGroupResult;
    }

    private Humidifier.Redshift.ClusterParameterGroup CreateClusterParameterGroup()
    {
        var clusterParameterGroupResult = new Humidifier.Redshift.ClusterParameterGroup
        {
            GivenName = InputResourceName,
        };

        return clusterParameterGroupResult;
    }
    public override void CreateChildren(Humidifier.Redshift.ClusterParameterGroup result)
    {
        base.CreateChildren(result);

        result.Parameters = ParametersFactories.Any() ? ParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ClusterParameterGroupFactoryExtensions
{
    public static CombinedResult<ClusterParameterGroupFactory, InnerClusterParameterGroupParameterFactory> WithParameters(this ClusterParameterGroupFactory parentFactory, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null)
    {
        var factory = new InnerClusterParameterGroupParameterFactory(subFactoryAction);
        parentFactory.ParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ClusterParameterGroupFactory, T1, InnerClusterParameterGroupParameterFactory> WithParameters<T1>(this CombinedResult<ClusterParameterGroupFactory, T1> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterParameterGroupFactory, InnerClusterParameterGroupParameterFactory> WithParameters<T1>(this CombinedResult<T1, ClusterParameterGroupFactory> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterParameterGroupFactory, T1, T2, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2>(this CombinedResult<ClusterParameterGroupFactory, T1, T2> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterParameterGroupFactory, T2, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, ClusterParameterGroupFactory, T2> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterParameterGroupFactory, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, ClusterParameterGroupFactory> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterParameterGroupFactory, T1, T2, T3, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<ClusterParameterGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterParameterGroupFactory, T2, T3, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, ClusterParameterGroupFactory, T2, T3> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterParameterGroupFactory, T3, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, ClusterParameterGroupFactory, T3> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterParameterGroupFactory, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterParameterGroupFactory> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterParameterGroupFactory, T1, T2, T3, T4, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<ClusterParameterGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterParameterGroupFactory, T2, T3, T4, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, ClusterParameterGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterParameterGroupFactory, T3, T4, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterParameterGroupFactory, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterParameterGroupFactory, T4, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterParameterGroupFactory, T4> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterParameterGroupFactory, InnerClusterParameterGroupParameterFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterParameterGroupFactory> combinedResult, Action<Humidifier.Redshift.ClusterParameterGroupTypes.Parameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}
