// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQueryTimestreamConfigurationFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration>
{

    internal InnerScheduledQueryMultiMeasureMappingsFactory MultiMeasureMappingsFactory { get; set; }

    protected override Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration Create()
    {
        var timestreamConfigurationResult = CreateTimestreamConfiguration();
        factoryAction?.Invoke(timestreamConfigurationResult);

        return timestreamConfigurationResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration CreateTimestreamConfiguration()
    {
        var timestreamConfigurationResult = new Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration();

        return timestreamConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration result)
    {
        base.CreateChildren(result);

        result.MultiMeasureMappings ??= MultiMeasureMappingsFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledQueryTimestreamConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings(this InnerScheduledQueryTimestreamConfigurationFactory parentFactory, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null)
    {
        parentFactory.MultiMeasureMappingsFactory = new InnerScheduledQueryMultiMeasureMappingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultiMeasureMappingsFactory);
    }

    public static CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1>(this CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1>(this CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, T2, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2>(this CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, T2, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2>(this CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryTimestreamConfigurationFactory, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2>(this CombinedResult<T1, T2, InnerScheduledQueryTimestreamConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, T2, T3, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3>(this CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, T2, T3, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3>(this CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryTimestreamConfigurationFactory, T3, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledQueryTimestreamConfigurationFactory, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryTimestreamConfigurationFactory, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledQueryTimestreamConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, T2, T3, T4, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3, T4>(this CombinedResult<InnerScheduledQueryTimestreamConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, T2, T3, T4, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledQueryTimestreamConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryTimestreamConfigurationFactory, T3, T4, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledQueryTimestreamConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryTimestreamConfigurationFactory, T4, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledQueryTimestreamConfigurationFactory, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledQueryTimestreamConfigurationFactory, InnerScheduledQueryMultiMeasureMappingsFactory> WithMultiMeasureMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledQueryTimestreamConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiMeasureMappings(combinedResult.T5, subFactoryAction));
}
