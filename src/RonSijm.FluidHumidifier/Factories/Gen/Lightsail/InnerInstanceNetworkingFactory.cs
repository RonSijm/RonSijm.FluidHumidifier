// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerInstanceNetworkingFactory(Action<Humidifier.Lightsail.InstanceTypes.Networking> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.InstanceTypes.Networking>
{

    internal InnerInstanceMonthlyTransferFactory MonthlyTransferFactory { get; set; }

    protected override Humidifier.Lightsail.InstanceTypes.Networking Create()
    {
        var networkingResult = CreateNetworking();
        factoryAction?.Invoke(networkingResult);

        return networkingResult;
    }

    private Humidifier.Lightsail.InstanceTypes.Networking CreateNetworking()
    {
        var networkingResult = new Humidifier.Lightsail.InstanceTypes.Networking();

        return networkingResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.InstanceTypes.Networking result)
    {
        base.CreateChildren(result);

        result.MonthlyTransfer ??= MonthlyTransferFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceNetworkingFactoryExtensions
{
    public static CombinedResult<InnerInstanceNetworkingFactory, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer(this InnerInstanceNetworkingFactory parentFactory, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null)
    {
        parentFactory.MonthlyTransferFactory = new InnerInstanceMonthlyTransferFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonthlyTransferFactory);
    }

    public static CombinedResult<InnerInstanceNetworkingFactory, T1, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1>(this CombinedResult<InnerInstanceNetworkingFactory, T1> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkingFactory, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1>(this CombinedResult<T1, InnerInstanceNetworkingFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkingFactory, T1, T2, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2>(this CombinedResult<InnerInstanceNetworkingFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkingFactory, T2, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2>(this CombinedResult<T1, InnerInstanceNetworkingFactory, T2> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkingFactory, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2>(this CombinedResult<T1, T2, InnerInstanceNetworkingFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkingFactory, T1, T2, T3, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3>(this CombinedResult<InnerInstanceNetworkingFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkingFactory, T2, T3, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3>(this CombinedResult<T1, InnerInstanceNetworkingFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkingFactory, T3, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceNetworkingFactory, T3> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceNetworkingFactory, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceNetworkingFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceNetworkingFactory, T1, T2, T3, T4, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3, T4>(this CombinedResult<InnerInstanceNetworkingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceNetworkingFactory, T2, T3, T4, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceNetworkingFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceNetworkingFactory, T3, T4, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceNetworkingFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceNetworkingFactory, T4, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceNetworkingFactory, T4> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceNetworkingFactory, InnerInstanceMonthlyTransferFactory> WithMonthlyTransfer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceNetworkingFactory> combinedResult, Action<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthlyTransfer(combinedResult.T5, subFactoryAction));
}
