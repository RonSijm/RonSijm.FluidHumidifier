// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NatGatewayFactory(string resourceName = null, Action<Humidifier.EC2.NatGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.NatGateway>(resourceName)
{

    internal List<InnerNatGatewayAvailabilityZoneAddressFactory> AvailabilityZoneAddressesFactories { get; set; } = [];

    protected override Humidifier.EC2.NatGateway Create()
    {
        var natGatewayResult = CreateNatGateway();
        factoryAction?.Invoke(natGatewayResult);

        return natGatewayResult;
    }

    private Humidifier.EC2.NatGateway CreateNatGateway()
    {
        var natGatewayResult = new Humidifier.EC2.NatGateway
        {
            GivenName = InputResourceName,
        };

        return natGatewayResult;
    }
    public override void CreateChildren(Humidifier.EC2.NatGateway result)
    {
        base.CreateChildren(result);

        result.AvailabilityZoneAddresses = AvailabilityZoneAddressesFactories.Any() ? AvailabilityZoneAddressesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class NatGatewayFactoryExtensions
{
    public static CombinedResult<NatGatewayFactory, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses(this NatGatewayFactory parentFactory, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null)
    {
        var factory = new InnerNatGatewayAvailabilityZoneAddressFactory(subFactoryAction);
        parentFactory.AvailabilityZoneAddressesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NatGatewayFactory, T1, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1>(this CombinedResult<NatGatewayFactory, T1> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NatGatewayFactory, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1>(this CombinedResult<T1, NatGatewayFactory> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NatGatewayFactory, T1, T2, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2>(this CombinedResult<NatGatewayFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NatGatewayFactory, T2, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2>(this CombinedResult<T1, NatGatewayFactory, T2> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NatGatewayFactory, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2>(this CombinedResult<T1, T2, NatGatewayFactory> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NatGatewayFactory, T1, T2, T3, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3>(this CombinedResult<NatGatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NatGatewayFactory, T2, T3, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3>(this CombinedResult<T1, NatGatewayFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NatGatewayFactory, T3, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3>(this CombinedResult<T1, T2, NatGatewayFactory, T3> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NatGatewayFactory, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3>(this CombinedResult<T1, T2, T3, NatGatewayFactory> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NatGatewayFactory, T1, T2, T3, T4, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3, T4>(this CombinedResult<NatGatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NatGatewayFactory, T2, T3, T4, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3, T4>(this CombinedResult<T1, NatGatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NatGatewayFactory, T3, T4, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, NatGatewayFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NatGatewayFactory, T4, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NatGatewayFactory, T4> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NatGatewayFactory, InnerNatGatewayAvailabilityZoneAddressFactory> WithAvailabilityZoneAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NatGatewayFactory> combinedResult, Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneAddresses(combinedResult.T5, subFactoryAction).T2);
}
