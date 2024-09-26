// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCCidrBlockFactory(string resourceName = null, Action<Humidifier.EC2.VPCCidrBlock> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCCidrBlock>(resourceName)
{

    protected override Humidifier.EC2.VPCCidrBlock Create()
    {
        var vPCCidrBlockResult = CreateVPCCidrBlock();
        factoryAction?.Invoke(vPCCidrBlockResult);

        return vPCCidrBlockResult;
    }

    private Humidifier.EC2.VPCCidrBlock CreateVPCCidrBlock()
    {
        var vPCCidrBlockResult = new Humidifier.EC2.VPCCidrBlock
        {
            GivenName = InputResourceName,
        };

        return vPCCidrBlockResult;
    }

} // End Of Class

public static class VPCCidrBlockFactoryExtensions
{
}
