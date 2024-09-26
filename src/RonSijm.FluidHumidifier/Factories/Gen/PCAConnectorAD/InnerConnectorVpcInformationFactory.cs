// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerConnectorVpcInformationFactory(Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation>
{

    protected override Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation Create()
    {
        var vpcInformationResult = CreateVpcInformation();
        factoryAction?.Invoke(vpcInformationResult);

        return vpcInformationResult;
    }

    private Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation CreateVpcInformation()
    {
        var vpcInformationResult = new Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation();

        return vpcInformationResult;
    }

} // End Of Class

public static class InnerConnectorVpcInformationFactoryExtensions
{
}
