// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class IdMappingWorkflowFactory(string resourceName = null, Action<Humidifier.EntityResolution.IdMappingWorkflow> factoryAction = null) : ResourceFactory<Humidifier.EntityResolution.IdMappingWorkflow>(resourceName)
{

    internal List<InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> InputSourceConfigFactories { get; set; } = [];

    internal List<InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> OutputSourceConfigFactories { get; set; } = [];

    internal InnerIdMappingWorkflowIdMappingTechniquesFactory IdMappingTechniquesFactory { get; set; }

    protected override Humidifier.EntityResolution.IdMappingWorkflow Create()
    {
        var idMappingWorkflowResult = CreateIdMappingWorkflow();
        factoryAction?.Invoke(idMappingWorkflowResult);

        return idMappingWorkflowResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflow CreateIdMappingWorkflow()
    {
        var idMappingWorkflowResult = new Humidifier.EntityResolution.IdMappingWorkflow
        {
            GivenName = InputResourceName,
        };

        return idMappingWorkflowResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.IdMappingWorkflow result)
    {
        base.CreateChildren(result);

        result.InputSourceConfig = InputSourceConfigFactories.Any() ? InputSourceConfigFactories.Select(x => x.Build()).ToList() : null;
        result.OutputSourceConfig = OutputSourceConfigFactories.Any() ? OutputSourceConfigFactories.Select(x => x.Build()).ToList() : null;
        result.IdMappingTechniques ??= IdMappingTechniquesFactory?.Build();
    }

} // End Of Class

public static class IdMappingWorkflowFactoryExtensions
{
    public static CombinedResult<IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig(this IdMappingWorkflowFactory parentFactory, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null)
    {
        var factory = new InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory(subFactoryAction);
        parentFactory.InputSourceConfigFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig(this IdMappingWorkflowFactory parentFactory, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null)
    {
        var factory = new InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory(subFactoryAction);
        parentFactory.OutputSourceConfigFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques(this IdMappingWorkflowFactory parentFactory, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null)
    {
        parentFactory.IdMappingTechniquesFactory = new InnerIdMappingWorkflowIdMappingTechniquesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdMappingTechniquesFactory);
    }

    public static CombinedResult<IdMappingWorkflowFactory, T1, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1>(this CombinedResult<IdMappingWorkflowFactory, T1> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1>(this CombinedResult<T1, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2>(this CombinedResult<IdMappingWorkflowFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2>(this CombinedResult<T1, IdMappingWorkflowFactory, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2>(this CombinedResult<T1, T2, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<IdMappingWorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<T1, IdMappingWorkflowFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, IdMappingWorkflowFactory, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, T4, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, T4, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, T4, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, T4, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory> WithInputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSourceConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1>(this CombinedResult<IdMappingWorkflowFactory, T1> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1>(this CombinedResult<T1, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2>(this CombinedResult<IdMappingWorkflowFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2>(this CombinedResult<T1, IdMappingWorkflowFactory, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2>(this CombinedResult<T1, T2, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3>(this CombinedResult<IdMappingWorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3>(this CombinedResult<T1, IdMappingWorkflowFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, IdMappingWorkflowFactory, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, T4, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3, T4>(this CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, T4, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, T4, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, T4, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory> WithOutputSourceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputSourceConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1>(this CombinedResult<IdMappingWorkflowFactory, T1> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1>(this CombinedResult<T1, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2>(this CombinedResult<IdMappingWorkflowFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2>(this CombinedResult<T1, IdMappingWorkflowFactory, T2> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2>(this CombinedResult<T1, T2, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3>(this CombinedResult<IdMappingWorkflowFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3>(this CombinedResult<T1, IdMappingWorkflowFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3>(this CombinedResult<T1, T2, IdMappingWorkflowFactory, T3> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3>(this CombinedResult<T1, T2, T3, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, T4, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3, T4>(this CombinedResult<IdMappingWorkflowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, T4, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3, T4>(this CombinedResult<T1, IdMappingWorkflowFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, T4, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3, T4>(this CombinedResult<T1, T2, IdMappingWorkflowFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, T4, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IdMappingWorkflowFactory, T4> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IdMappingWorkflowFactory, InnerIdMappingWorkflowIdMappingTechniquesFactory> WithIdMappingTechniques<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IdMappingWorkflowFactory> combinedResult, Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingTechniques> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdMappingTechniques(combinedResult.T5, subFactoryAction));
}
