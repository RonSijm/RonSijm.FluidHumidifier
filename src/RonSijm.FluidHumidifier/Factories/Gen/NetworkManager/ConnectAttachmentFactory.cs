// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class ConnectAttachmentFactory(string resourceName = null, Action<Humidifier.NetworkManager.ConnectAttachment> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.ConnectAttachment>(resourceName)
{

    internal InnerConnectAttachmentProposedSegmentChangeFactory ProposedSegmentChangeFactory { get; set; }

    internal InnerConnectAttachmentConnectAttachmentOptionsFactory OptionsFactory { get; set; }

    internal InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory ProposedNetworkFunctionGroupChangeFactory { get; set; }

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

        result.ProposedSegmentChange ??= ProposedSegmentChangeFactory?.Build();
        result.Options ??= OptionsFactory?.Build();
        result.ProposedNetworkFunctionGroupChange ??= ProposedNetworkFunctionGroupChangeFactory?.Build();
    }

} // End Of Class

public static class ConnectAttachmentFactoryExtensions
{
    public static CombinedResult<ConnectAttachmentFactory, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange(this ConnectAttachmentFactory parentFactory, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null)
    {
        parentFactory.ProposedSegmentChangeFactory = new InnerConnectAttachmentProposedSegmentChangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProposedSegmentChangeFactory);
    }

    public static CombinedResult<ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions(this ConnectAttachmentFactory parentFactory, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null)
    {
        parentFactory.OptionsFactory = new InnerConnectAttachmentConnectAttachmentOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OptionsFactory);
    }

    public static CombinedResult<ConnectAttachmentFactory, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange(this ConnectAttachmentFactory parentFactory, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null)
    {
        parentFactory.ProposedNetworkFunctionGroupChangeFactory = new InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProposedNetworkFunctionGroupChangeFactory);
    }

    public static CombinedResult<ConnectAttachmentFactory, T1, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1>(this CombinedResult<ConnectAttachmentFactory, T1> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1>(this CombinedResult<T1, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2>(this CombinedResult<ConnectAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2>(this CombinedResult<T1, ConnectAttachmentFactory, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2>(this CombinedResult<T1, T2, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3, T4>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3, T4>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory, InnerConnectAttachmentProposedSegmentChangeFactory> WithProposedSegmentChange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedSegmentChange(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<ConnectAttachmentFactory, T1> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1>(this CombinedResult<T1, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<ConnectAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, ConnectAttachmentFactory, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2>(this CombinedResult<T1, T2, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory, InnerConnectAttachmentConnectAttachmentOptionsFactory> WithOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1>(this CombinedResult<ConnectAttachmentFactory, T1> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1>(this CombinedResult<T1, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2>(this CombinedResult<ConnectAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2>(this CombinedResult<T1, ConnectAttachmentFactory, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2>(this CombinedResult<T1, T2, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3, T4>(this CombinedResult<ConnectAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3, T4>(this CombinedResult<T1, ConnectAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectAttachmentFactory, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory, InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory> WithProposedNetworkFunctionGroupChange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectAttachmentFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProposedNetworkFunctionGroupChange(combinedResult.T5, subFactoryAction));
}
