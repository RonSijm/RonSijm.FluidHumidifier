// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class DeliveryChannelFactory(string resourceName = null, Action<Humidifier.Config.DeliveryChannel> factoryAction = null) : ResourceFactory<Humidifier.Config.DeliveryChannel>(resourceName)
{

    internal InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory ConfigSnapshotDeliveryPropertiesFactory { get; set; }

    protected override Humidifier.Config.DeliveryChannel Create()
    {
        var deliveryChannelResult = CreateDeliveryChannel();
        factoryAction?.Invoke(deliveryChannelResult);

        return deliveryChannelResult;
    }

    private Humidifier.Config.DeliveryChannel CreateDeliveryChannel()
    {
        var deliveryChannelResult = new Humidifier.Config.DeliveryChannel
        {
            GivenName = InputResourceName,
        };

        return deliveryChannelResult;
    }
    public override void CreateChildren(Humidifier.Config.DeliveryChannel result)
    {
        base.CreateChildren(result);

        result.ConfigSnapshotDeliveryProperties ??= ConfigSnapshotDeliveryPropertiesFactory?.Build();
    }

} // End Of Class

public static class DeliveryChannelFactoryExtensions
{
    public static CombinedResult<DeliveryChannelFactory, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties(this DeliveryChannelFactory parentFactory, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null)
    {
        parentFactory.ConfigSnapshotDeliveryPropertiesFactory = new InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigSnapshotDeliveryPropertiesFactory);
    }

    public static CombinedResult<DeliveryChannelFactory, T1, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1>(this CombinedResult<DeliveryChannelFactory, T1> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeliveryChannelFactory, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1>(this CombinedResult<T1, DeliveryChannelFactory> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeliveryChannelFactory, T1, T2, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2>(this CombinedResult<DeliveryChannelFactory, T1, T2> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeliveryChannelFactory, T2, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2>(this CombinedResult<T1, DeliveryChannelFactory, T2> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeliveryChannelFactory, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2>(this CombinedResult<T1, T2, DeliveryChannelFactory> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeliveryChannelFactory, T1, T2, T3, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3>(this CombinedResult<DeliveryChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeliveryChannelFactory, T2, T3, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3>(this CombinedResult<T1, DeliveryChannelFactory, T2, T3> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeliveryChannelFactory, T3, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3>(this CombinedResult<T1, T2, DeliveryChannelFactory, T3> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeliveryChannelFactory, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeliveryChannelFactory> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeliveryChannelFactory, T1, T2, T3, T4, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3, T4>(this CombinedResult<DeliveryChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeliveryChannelFactory, T2, T3, T4, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3, T4>(this CombinedResult<T1, DeliveryChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeliveryChannelFactory, T3, T4, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeliveryChannelFactory, T3, T4> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeliveryChannelFactory, T4, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeliveryChannelFactory, T4> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeliveryChannelFactory, InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory> WithConfigSnapshotDeliveryProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeliveryChannelFactory> combinedResult, Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigSnapshotDeliveryProperties(combinedResult.T5, subFactoryAction));
}
