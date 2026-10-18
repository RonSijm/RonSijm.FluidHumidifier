// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SecondaryNetworkFactory(string resourceName = null, Action<Humidifier.EC2.SecondaryNetwork> factoryAction = null) : ResourceFactory<Humidifier.EC2.SecondaryNetwork>(resourceName)
{

    protected override Humidifier.EC2.SecondaryNetwork Create()
    {
        var secondaryNetworkResult = CreateSecondaryNetwork();
        factoryAction?.Invoke(secondaryNetworkResult);

        return secondaryNetworkResult;
    }

    private Humidifier.EC2.SecondaryNetwork CreateSecondaryNetwork()
    {
        var secondaryNetworkResult = new Humidifier.EC2.SecondaryNetwork
        {
            GivenName = InputResourceName,
        };

        return secondaryNetworkResult;
    }

} // End Of Class

public static class SecondaryNetworkFactoryExtensions
{
}
