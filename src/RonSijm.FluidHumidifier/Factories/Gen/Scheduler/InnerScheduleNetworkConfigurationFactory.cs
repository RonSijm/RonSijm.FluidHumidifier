// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleNetworkConfigurationFactory(Action<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration>
{

    internal InnerScheduleAwsVpcConfigurationFactory AwsvpcConfigurationFactory { get; set; }

    protected override Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Scheduler.ScheduleTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.AwsvpcConfiguration ??= AwsvpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScheduleNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScheduleNetworkConfigurationFactory, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration(this InnerScheduleNetworkConfigurationFactory parentFactory, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.AwsvpcConfigurationFactory = new InnerScheduleAwsVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsvpcConfigurationFactory);
    }

    public static CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1>(this CombinedResult<InnerScheduleNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1>(this CombinedResult<T1, InnerScheduleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, T2, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, T2, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduleNetworkConfigurationFactory, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerScheduleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, T2, T3, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, T2, T3, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduleNetworkConfigurationFactory, T3, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduleNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduleNetworkConfigurationFactory, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, T2, T3, T4, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerScheduleNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, T2, T3, T4, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduleNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduleNetworkConfigurationFactory, T3, T4, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduleNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduleNetworkConfigurationFactory, T4, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduleNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScheduleNetworkConfigurationFactory, InnerScheduleAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T5, subFactoryAction));
}
