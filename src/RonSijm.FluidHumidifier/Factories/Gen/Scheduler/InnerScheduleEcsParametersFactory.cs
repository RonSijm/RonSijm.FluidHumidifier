// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleEcsParametersFactory(Action<Humidifier.Scheduler.ScheduleTypes.EcsParameters> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.EcsParameters>
{

    internal InnerScheduleNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    protected override Humidifier.Scheduler.ScheduleTypes.EcsParameters Create()
    {
        var ecsParametersResult = CreateEcsParameters();
        factoryAction?.Invoke(ecsParametersResult);

        return ecsParametersResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.EcsParameters CreateEcsParameters()
    {
        var ecsParametersResult = new Humidifier.Scheduler.ScheduleTypes.EcsParameters();

        return ecsParametersResult;
    }
    public override void CreateChildren(Humidifier.Scheduler.ScheduleTypes.EcsParameters result)
    {
        base.CreateChildren(result);

        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScheduleEcsParametersFactoryExtensions
{
    public static CombinedResult<InnerScheduleEcsParametersFactory, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration(this InnerScheduleEcsParametersFactory parentFactory, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerScheduleNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<InnerScheduleEcsParametersFactory, T1, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<InnerScheduleEcsParametersFactory, T1> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleEcsParametersFactory, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, InnerScheduleEcsParametersFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScheduleEcsParametersFactory, T1, T2, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<InnerScheduleEcsParametersFactory, T1, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleEcsParametersFactory, T2, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, InnerScheduleEcsParametersFactory, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduleEcsParametersFactory, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerScheduleEcsParametersFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScheduleEcsParametersFactory, T1, T2, T3, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<InnerScheduleEcsParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleEcsParametersFactory, T2, T3, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerScheduleEcsParametersFactory, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduleEcsParametersFactory, T3, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduleEcsParametersFactory, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduleEcsParametersFactory, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduleEcsParametersFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScheduleEcsParametersFactory, T1, T2, T3, T4, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerScheduleEcsParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleEcsParametersFactory, T2, T3, T4, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduleEcsParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduleEcsParametersFactory, T3, T4, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduleEcsParametersFactory, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduleEcsParametersFactory, T4, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduleEcsParametersFactory, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScheduleEcsParametersFactory, InnerScheduleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduleEcsParametersFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction));
}
