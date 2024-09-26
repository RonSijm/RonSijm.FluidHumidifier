// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class VpcConnectorFactory(string resourceName = null, Action<Humidifier.AppRunner.VpcConnector> factoryAction = null) : ResourceFactory<Humidifier.AppRunner.VpcConnector>(resourceName)
{

    protected override Humidifier.AppRunner.VpcConnector Create()
    {
        var vpcConnectorResult = CreateVpcConnector();
        factoryAction?.Invoke(vpcConnectorResult);

        return vpcConnectorResult;
    }

    private Humidifier.AppRunner.VpcConnector CreateVpcConnector()
    {
        var vpcConnectorResult = new Humidifier.AppRunner.VpcConnector
        {
            GivenName = InputResourceName,
        };

        return vpcConnectorResult;
    }

} // End Of Class

public static class VpcConnectorFactoryExtensions
{
}
