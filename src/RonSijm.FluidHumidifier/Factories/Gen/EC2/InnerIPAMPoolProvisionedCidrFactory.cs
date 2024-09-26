// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMPoolProvisionedCidrFactory(Action<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr>
{

    protected override Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr Create()
    {
        var provisionedCidrResult = CreateProvisionedCidr();
        factoryAction?.Invoke(provisionedCidrResult);

        return provisionedCidrResult;
    }

    private Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr CreateProvisionedCidr()
    {
        var provisionedCidrResult = new Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr();

        return provisionedCidrResult;
    }

} // End Of Class

public static class InnerIPAMPoolProvisionedCidrFactoryExtensions
{
}
