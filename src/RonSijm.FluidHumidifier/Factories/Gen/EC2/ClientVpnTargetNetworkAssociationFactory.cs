// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ClientVpnTargetNetworkAssociationFactory(string resourceName = null, Action<Humidifier.EC2.ClientVpnTargetNetworkAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.ClientVpnTargetNetworkAssociation>(resourceName)
{

    protected override Humidifier.EC2.ClientVpnTargetNetworkAssociation Create()
    {
        var clientVpnTargetNetworkAssociationResult = CreateClientVpnTargetNetworkAssociation();
        factoryAction?.Invoke(clientVpnTargetNetworkAssociationResult);

        return clientVpnTargetNetworkAssociationResult;
    }

    private Humidifier.EC2.ClientVpnTargetNetworkAssociation CreateClientVpnTargetNetworkAssociation()
    {
        var clientVpnTargetNetworkAssociationResult = new Humidifier.EC2.ClientVpnTargetNetworkAssociation
        {
            GivenName = InputResourceName,
        };

        return clientVpnTargetNetworkAssociationResult;
    }

} // End Of Class

public static class ClientVpnTargetNetworkAssociationFactoryExtensions
{
}
