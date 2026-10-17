// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionDestinationConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.DestinationConfiguration>
{

    internal InnerCompositionS3DestinationConfigurationFactory S3Factory { get; set; }

    internal InnerCompositionChannelDestinationConfigurationFactory ChannelFactory { get; set; }

    protected override Humidifier.IVS.CompositionTypes.DestinationConfiguration Create()
    {
        var destinationConfigurationResult = CreateDestinationConfiguration();
        factoryAction?.Invoke(destinationConfigurationResult);

        return destinationConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.DestinationConfiguration CreateDestinationConfiguration()
    {
        var destinationConfigurationResult = new Humidifier.IVS.CompositionTypes.DestinationConfiguration();

        return destinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.CompositionTypes.DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
        result.Channel ??= ChannelFactory?.Build();
    }

} // End Of Class

public static class InnerCompositionDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, InnerCompositionS3DestinationConfigurationFactory> WithS3(this InnerCompositionDestinationConfigurationFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerCompositionS3DestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, InnerCompositionChannelDestinationConfigurationFactory> WithChannel(this InnerCompositionDestinationConfigurationFactory parentFactory, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.ChannelFactory = new InnerCompositionChannelDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ChannelFactory);
    }

    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3, T4, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3, T4, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3, T4, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory, T4, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositionDestinationConfigurationFactory, InnerCompositionS3DestinationConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.S3DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithChannel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithChannel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2>(this CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3>(this CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3, T4, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3, T4>(this CombinedResult<InnerCompositionDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3, T4, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3, T4>(this CombinedResult<T1, InnerCompositionDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3, T4, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCompositionDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory, T4, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCompositionDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCompositionDestinationConfigurationFactory, InnerCompositionChannelDestinationConfigurationFactory> WithChannel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCompositionDestinationConfigurationFactory> combinedResult, Action<Humidifier.IVS.CompositionTypes.ChannelDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannel(combinedResult.T5, subFactoryAction).T2);
}
