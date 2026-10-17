// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPNConcentratorFactory(string resourceName = null, Action<Humidifier.EC2.VPNConcentrator> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPNConcentrator>(resourceName)
{

    protected override Humidifier.EC2.VPNConcentrator Create()
    {
        var vPNConcentratorResult = CreateVPNConcentrator();
        factoryAction?.Invoke(vPNConcentratorResult);

        return vPNConcentratorResult;
    }

    private Humidifier.EC2.VPNConcentrator CreateVPNConcentrator()
    {
        var vPNConcentratorResult = new Humidifier.EC2.VPNConcentrator
        {
            GivenName = InputResourceName,
        };

        return vPNConcentratorResult;
    }

} // End Of Class

public static class VPNConcentratorFactoryExtensions
{
}
