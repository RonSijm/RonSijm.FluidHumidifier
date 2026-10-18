// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class HubV2Factory(string resourceName = null, Action<Humidifier.SecurityHub.HubV2> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.HubV2>(resourceName)
{

    internal InnerHubV2NetworkScanningFactory NetworkScanningFactory { get; set; }

    protected override Humidifier.SecurityHub.HubV2 Create()
    {
        var hubV2Result = CreateHubV2();
        factoryAction?.Invoke(hubV2Result);

        return hubV2Result;
    }

    private Humidifier.SecurityHub.HubV2 CreateHubV2()
    {
        var hubV2Result = new Humidifier.SecurityHub.HubV2
        {
            GivenName = InputResourceName,
        };

        return hubV2Result;
    }
    public override void CreateChildren(Humidifier.SecurityHub.HubV2 result)
    {
        base.CreateChildren(result);

        result.NetworkScanning ??= NetworkScanningFactory?.Build();
    }

} // End Of Class

public static class HubV2FactoryExtensions
{
    public static CombinedResult<HubV2Factory, InnerHubV2NetworkScanningFactory> WithNetworkScanning(this HubV2Factory parentFactory, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null)
    {
        parentFactory.NetworkScanningFactory = new InnerHubV2NetworkScanningFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkScanningFactory);
    }

    public static CombinedResult<HubV2Factory, T1, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1>(this CombinedResult<HubV2Factory, T1> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkScanning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubV2Factory, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1>(this CombinedResult<T1, HubV2Factory> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkScanning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<HubV2Factory, T1, T2, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2>(this CombinedResult<HubV2Factory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubV2Factory, T2, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2>(this CombinedResult<T1, HubV2Factory, T2> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HubV2Factory, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2>(this CombinedResult<T1, T2, HubV2Factory> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<HubV2Factory, T1, T2, T3, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3>(this CombinedResult<HubV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubV2Factory, T2, T3, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3>(this CombinedResult<T1, HubV2Factory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HubV2Factory, T3, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3>(this CombinedResult<T1, T2, HubV2Factory, T3> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HubV2Factory, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3>(this CombinedResult<T1, T2, T3, HubV2Factory> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<HubV2Factory, T1, T2, T3, T4, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3, T4>(this CombinedResult<HubV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HubV2Factory, T2, T3, T4, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3, T4>(this CombinedResult<T1, HubV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HubV2Factory, T3, T4, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3, T4>(this CombinedResult<T1, T2, HubV2Factory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HubV2Factory, T4, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HubV2Factory, T4> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, HubV2Factory, InnerHubV2NetworkScanningFactory> WithNetworkScanning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HubV2Factory> combinedResult, Action<Humidifier.SecurityHub.HubV2Types.NetworkScanning> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkScanning(combinedResult.T5, subFactoryAction).T2);
}
