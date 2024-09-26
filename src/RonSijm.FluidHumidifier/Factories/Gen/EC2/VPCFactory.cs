// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCFactory(string resourceName = null, Action<Humidifier.EC2.VPC> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPC>(resourceName)
{

    protected override Humidifier.EC2.VPC Create()
    {
        var vPCResult = CreateVPC();
        factoryAction?.Invoke(vPCResult);

        return vPCResult;
    }

    private Humidifier.EC2.VPC CreateVPC()
    {
        var vPCResult = new Humidifier.EC2.VPC
        {
            GivenName = InputResourceName,
        };

        return vPCResult;
    }

} // End Of Class

public static class VPCFactoryExtensions
{
}
