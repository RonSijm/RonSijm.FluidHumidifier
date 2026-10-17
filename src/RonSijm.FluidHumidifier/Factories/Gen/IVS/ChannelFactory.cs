// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class ChannelFactory(string resourceName = null, Action<Humidifier.IVS.Channel> factoryAction = null) : ResourceFactory<Humidifier.IVS.Channel>(resourceName)
{

    internal InnerChannelMultitrackInputConfigurationFactory MultitrackInputConfigurationFactory { get; set; }

    protected override Humidifier.IVS.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.IVS.Channel CreateChannel()
    {
        var channelResult = new Humidifier.IVS.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }
    public override void CreateChildren(Humidifier.IVS.Channel result)
    {
        base.CreateChildren(result);

        result.MultitrackInputConfiguration ??= MultitrackInputConfigurationFactory?.Build();
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
    public static CombinedResult<ChannelFactory, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration(this ChannelFactory parentFactory, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null)
    {
        parentFactory.MultitrackInputConfigurationFactory = new InnerChannelMultitrackInputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultitrackInputConfigurationFactory);
    }

    public static CombinedResult<ChannelFactory, T1, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelMultitrackInputConfigurationFactory> WithMultitrackInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.IVS.ChannelTypes.MultitrackInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultitrackInputConfiguration(combinedResult.T5, subFactoryAction).T2);
}
