// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SubnetCidrBlockFactory(string resourceName = null, Action<Humidifier.EC2.SubnetCidrBlock> factoryAction = null) : ResourceFactory<Humidifier.EC2.SubnetCidrBlock>(resourceName)
{

    protected override Humidifier.EC2.SubnetCidrBlock Create()
    {
        var subnetCidrBlockResult = CreateSubnetCidrBlock();
        factoryAction?.Invoke(subnetCidrBlockResult);

        return subnetCidrBlockResult;
    }

    private Humidifier.EC2.SubnetCidrBlock CreateSubnetCidrBlock()
    {
        var subnetCidrBlockResult = new Humidifier.EC2.SubnetCidrBlock
        {
            GivenName = InputResourceName,
        };

        return subnetCidrBlockResult;
    }

} // End Of Class

public static class SubnetCidrBlockFactoryExtensions
{
}
