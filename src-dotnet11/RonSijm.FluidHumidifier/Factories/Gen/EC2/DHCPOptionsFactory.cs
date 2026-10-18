// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class DHCPOptionsFactory(string resourceName = null, Action<Humidifier.EC2.DHCPOptions> factoryAction = null) : ResourceFactory<Humidifier.EC2.DHCPOptions>(resourceName)
{

    protected override Humidifier.EC2.DHCPOptions Create()
    {
        var dHCPOptionsResult = CreateDHCPOptions();
        factoryAction?.Invoke(dHCPOptionsResult);

        return dHCPOptionsResult;
    }

    private Humidifier.EC2.DHCPOptions CreateDHCPOptions()
    {
        var dHCPOptionsResult = new Humidifier.EC2.DHCPOptions
        {
            GivenName = InputResourceName,
        };

        return dHCPOptionsResult;
    }

} // End Of Class

public static class DHCPOptionsFactoryExtensions
{
}
