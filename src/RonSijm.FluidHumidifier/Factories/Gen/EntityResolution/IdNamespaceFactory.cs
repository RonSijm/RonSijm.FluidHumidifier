// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class IdNamespaceFactory(string resourceName = null, Action<Humidifier.EntityResolution.IdNamespace> factoryAction = null) : ResourceFactory<Humidifier.EntityResolution.IdNamespace>(resourceName)
{

    internal List<InnerIdNamespaceIdNamespaceInputSourceFactory> InputSourceConfigFactories { get; set; } = [];

    internal List<InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> IdMappingWorkflowPropertiesFactories { get; set; } = [];

    protected override Humidifier.EntityResolution.IdNamespace Create()
    {
        var idNamespaceResult = CreateIdNamespace();
        factoryAction?.Invoke(idNamespaceResult);

        return idNamespaceResult;
    }

    private Humidifier.EntityResolution.IdNamespace CreateIdNamespace()
    {
        var idNamespaceResult = new Humidifier.EntityResolution.IdNamespace
        {
            GivenName = InputResourceName,
        };

        return idNamespaceResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.IdNamespace result)
    {
        base.CreateChildren(result);

        result.InputSourceConfig = InputSourceConfigFactories.Any() ? InputSourceConfigFactories.Select(x => x.Build()).ToList() : null;
        result.IdMappingWorkflowProperties = IdMappingWorkflowPropertiesFactories.Any() ? IdMappingWorkflowPropertiesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IdNamespaceFactoryExtensions
{
    public static CombinedResult<IdNamespaceFactory, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig(this IdNamespaceFactory parentFactory, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null)
    {
        var factory = new InnerIdNamespaceIdNamespaceInputSourceFactory(subFactoryAction);
        parentFactory.InputSourceConfigFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IdNamespaceFactory, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties(this IdNamespaceFactory parentFactory, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null)
    {
        var factory = new InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory(subFactoryAction);
        parentFactory.IdMappingWorkflowPropertiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IdNamespaceFactory, T1, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1>(this CombinedResult<IdNamespaceFactory, T1> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1>(this CombinedResult<T1, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, T2, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2>(this CombinedResult<IdNamespaceFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, T2, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2>(this CombinedResult<T1, IdNamespaceFactory, T2> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceFactory, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2>(this CombinedResult<T1, T2, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, T2, T3, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<IdNamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, T2, T3, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<T1, IdNamespaceFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceFactory, T3, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, IdNamespaceFactory, T3> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceFactory, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, T2, T3, T4, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<IdNamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, T2, T3, T4, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, IdNamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceFactory, T3, T4, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdNamespaceFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceFactory, T4, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdNamespaceFactory, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdNamespaceFactory, InnerIdNamespaceIdNamespaceInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1>(this CombinedResult<IdNamespaceFactory, T1> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1>(this CombinedResult<T1, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, T2, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2>(this CombinedResult<IdNamespaceFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, T2, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2>(this CombinedResult<T1, IdNamespaceFactory, T2> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceFactory, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2>(this CombinedResult<T1, T2, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, T2, T3, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3>(this CombinedResult<IdNamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, T2, T3, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3>(this CombinedResult<T1, IdNamespaceFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceFactory, T3, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3>(this CombinedResult<T1, T2, IdNamespaceFactory, T3> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceFactory, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdNamespaceFactory, T1, T2, T3, T4, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3, T4>(this CombinedResult<IdNamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdNamespaceFactory, T2, T3, T4, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3, T4>(this CombinedResult<T1, IdNamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdNamespaceFactory, T3, T4, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdNamespaceFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdNamespaceFactory, T4, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdNamespaceFactory, T4> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdNamespaceFactory, InnerIdNamespaceIdNamespaceIdMappingWorkflowPropertiesFactory> WithIdMappingWorkflowProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdNamespaceFactory> combinedResult, Action<Humidifier.EntityResolution.IdNamespaceTypes.IdNamespaceIdMappingWorkflowProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingWorkflowProperties(combinedResult.T5, subFactoryAction));
}
