// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class ConnectAttachmentFactory(string resourceName = null, Action<Humidifier.NetworkManager.ConnectAttachment> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.ConnectAttachment>(resourceName)
{

    internal InnerConnectAttachmentConnectAttachmentOptionsFactory OptionsFactory { get; set; }

    protected override Humidifier.NetworkManager.ConnectAttachment Create()
    {
        var connectAttachmentResult = CreateConnectAttachment();
        factoryAction?.Invoke(connectAttachmentResult);

        return connectAttachmentResult;
    }

    private Humidifier.NetworkManager.ConnectAttachment CreateConnectAttachment()
    {
        var connectAttachmentResult = new Humidifier.NetworkManager.ConnectAttachment
        {
            GivenName = InputResourceName,
        };

        return connectAttachmentResult;
    }
    public override void CreateChildren(Humidifier.NetworkManager.ConnectAttachment result)
    {
        base.CreateChildren(result);

        result.Options ??= OptionsFactory?.Build();
    }

} // End Of Class

public static class ConnectAttachmentFactoryExtensions
{
    public static CombinedResult<ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions(this ConnectAttachmentFactory parentFactory, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerConnectAttachmentConnectAttachmentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<ConnectAttachmentFactory, T1, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<ConnectAttachmentFactory, T1> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<T1, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<ConnectAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, ConnectAttachmentFactory, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction).T2);
}
