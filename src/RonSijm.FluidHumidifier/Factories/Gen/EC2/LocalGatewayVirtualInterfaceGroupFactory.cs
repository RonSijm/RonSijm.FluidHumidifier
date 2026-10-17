// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayVirtualInterfaceGroupFactory(string resourceName = null, Action<Humidifier.EC2.LocalGatewayVirtualInterfaceGroup> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGatewayVirtualInterfaceGroup>(resourceName)
{

    protected override Humidifier.EC2.LocalGatewayVirtualInterfaceGroup Create()
    {
        var localGatewayVirtualInterfaceGroupResult = CreateLocalGatewayVirtualInterfaceGroup();
        factoryAction?.Invoke(localGatewayVirtualInterfaceGroupResult);

        return localGatewayVirtualInterfaceGroupResult;
    }

    private Humidifier.EC2.LocalGatewayVirtualInterfaceGroup CreateLocalGatewayVirtualInterfaceGroup()
    {
        var localGatewayVirtualInterfaceGroupResult = new Humidifier.EC2.LocalGatewayVirtualInterfaceGroup
        {
            GivenName = InputResourceName,
        };

        return localGatewayVirtualInterfaceGroupResult;
    }

} // End Of Class

public static class LocalGatewayVirtualInterfaceGroupFactoryExtensions
{
}
