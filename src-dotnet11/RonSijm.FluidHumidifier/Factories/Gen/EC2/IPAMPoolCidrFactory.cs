// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMPoolCidrFactory(string resourceName = null, Action<Humidifier.EC2.IPAMPoolCidr> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMPoolCidr>(resourceName)
{

    protected override Humidifier.EC2.IPAMPoolCidr Create()
    {
        var iPAMPoolCidrResult = CreateIPAMPoolCidr();
        factoryAction?.Invoke(iPAMPoolCidrResult);

        return iPAMPoolCidrResult;
    }

    private Humidifier.EC2.IPAMPoolCidr CreateIPAMPoolCidr()
    {
        var iPAMPoolCidrResult = new Humidifier.EC2.IPAMPoolCidr
        {
            GivenName = InputResourceName,
        };

        return iPAMPoolCidrResult;
    }

} // End Of Class

public static class IPAMPoolCidrFactoryExtensions
{
}
