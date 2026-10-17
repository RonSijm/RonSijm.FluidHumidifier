// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentEksConfigurationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration>
{

    internal InnerComputeEnvironmentEksAccessEntryFactory AccessEntryFactory { get; set; }

    protected override Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration Create()
    {
        var eksConfigurationResult = CreateEksConfiguration();
        factoryAction?.Invoke(eksConfigurationResult);

        return eksConfigurationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration CreateEksConfiguration()
    {
        var eksConfigurationResult = new Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration();

        return eksConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration result)
    {
        base.CreateChildren(result);

        result.AccessEntry ??= AccessEntryFactory?.Build();
    }

} // End Of Class

public static class InnerComputeEnvironmentEksConfigurationFactoryExtensions
{
    public static CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry(this InnerComputeEnvironmentEksConfigurationFactory parentFactory, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null)
    {
        parentFactory.AccessEntryFactory = new InnerComputeEnvironmentEksAccessEntryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessEntryFactory);
    }

    public static CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1>(this CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEntry(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1>(this CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEntry(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, T2, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2>(this CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, T2, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2>(this CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, T2> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeEnvironmentEksConfigurationFactory, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2>(this CombinedResult<T1, T2, InnerComputeEnvironmentEksConfigurationFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, T2, T3, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3>(this CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, T2, T3, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3>(this CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeEnvironmentEksConfigurationFactory, T3, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3>(this CombinedResult<T1, T2, InnerComputeEnvironmentEksConfigurationFactory, T3> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputeEnvironmentEksConfigurationFactory, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComputeEnvironmentEksConfigurationFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, T2, T3, T4, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3, T4>(this CombinedResult<InnerComputeEnvironmentEksConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, T2, T3, T4, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3, T4>(this CombinedResult<T1, InnerComputeEnvironmentEksConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeEnvironmentEksConfigurationFactory, T3, T4, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComputeEnvironmentEksConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputeEnvironmentEksConfigurationFactory, T4, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComputeEnvironmentEksConfigurationFactory, T4> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerComputeEnvironmentEksConfigurationFactory, InnerComputeEnvironmentEksAccessEntryFactory> WithAccessEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComputeEnvironmentEksConfigurationFactory> combinedResult, Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEntry(combinedResult.T5, subFactoryAction).T2);
}
