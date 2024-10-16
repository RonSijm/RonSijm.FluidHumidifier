// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQueryTargetConfigurationFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration>
{

    internal InnerScheduledQueryTimestreamConfigurationFactory TimestreamConfigurationFactory { get; set; }

    protected override Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration Create()
    {
        var targetConfigurationResult = CreateTargetConfiguration();
        factoryAction?.Invoke(targetConfigurationResult);

        return targetConfigurationResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration CreateTargetConfiguration()
    {
        var targetConfigurationResult = new Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration();

        return targetConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.ScheduledQueryTypes.TargetConfiguration result)
    {
        base.CreateChildren(result);

        result.TimestreamConfiguration ??= TimestreamConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledQueryTargetConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScheduledQueryTargetConfigurationFactory, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration(this InnerScheduledQueryTargetConfigurationFactory parentFactory, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null)
    {
        parentFactory.TimestreamConfigurationFactory = new InnerScheduledQueryTimestreamConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimestreamConfigurationFactory);
    }

    public static CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1>(this CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1>(this CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, T2, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2>(this CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, T2, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2>(this CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryTargetConfigurationFactory, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerScheduledQueryTargetConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, T2, T3, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3>(this CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, T2, T3, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryTargetConfigurationFactory, T3, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledQueryTargetConfigurationFactory, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryTargetConfigurationFactory, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledQueryTargetConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, T2, T3, T4, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerScheduledQueryTargetConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, T2, T3, T4, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledQueryTargetConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryTargetConfigurationFactory, T3, T4, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledQueryTargetConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryTargetConfigurationFactory, T4, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledQueryTargetConfigurationFactory, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledQueryTargetConfigurationFactory, InnerScheduledQueryTimestreamConfigurationFactory> WithTimestreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledQueryTargetConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.TimestreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestreamConfiguration(combinedResult.T5, subFactoryAction));
}
