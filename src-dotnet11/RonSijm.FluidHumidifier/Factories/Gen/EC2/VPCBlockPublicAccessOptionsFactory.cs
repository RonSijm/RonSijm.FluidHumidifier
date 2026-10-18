// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCBlockPublicAccessOptionsFactory(string resourceName = null, Action<Humidifier.EC2.VPCBlockPublicAccessOptions> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCBlockPublicAccessOptions>(resourceName)
{

    protected override Humidifier.EC2.VPCBlockPublicAccessOptions Create()
    {
        var vPCBlockPublicAccessOptionsResult = CreateVPCBlockPublicAccessOptions();
        factoryAction?.Invoke(vPCBlockPublicAccessOptionsResult);

        return vPCBlockPublicAccessOptionsResult;
    }

    private Humidifier.EC2.VPCBlockPublicAccessOptions CreateVPCBlockPublicAccessOptions()
    {
        var vPCBlockPublicAccessOptionsResult = new Humidifier.EC2.VPCBlockPublicAccessOptions
        {
            GivenName = InputResourceName,
        };

        return vPCBlockPublicAccessOptionsResult;
    }

} // End Of Class

public static class VPCBlockPublicAccessOptionsFactoryExtensions
{
}
