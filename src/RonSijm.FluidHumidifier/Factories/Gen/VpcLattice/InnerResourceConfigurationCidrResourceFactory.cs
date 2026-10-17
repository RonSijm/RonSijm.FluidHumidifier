// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerResourceConfigurationCidrResourceFactory(Action<Humidifier.VpcLattice.ResourceConfigurationTypes.CidrResource> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ResourceConfigurationTypes.CidrResource>
{

    protected override Humidifier.VpcLattice.ResourceConfigurationTypes.CidrResource Create()
    {
        var cidrResourceResult = CreateCidrResource();
        factoryAction?.Invoke(cidrResourceResult);

        return cidrResourceResult;
    }

    private Humidifier.VpcLattice.ResourceConfigurationTypes.CidrResource CreateCidrResource()
    {
        var cidrResourceResult = new Humidifier.VpcLattice.ResourceConfigurationTypes.CidrResource();

        return cidrResourceResult;
    }

} // End Of Class

public static class InnerResourceConfigurationCidrResourceFactoryExtensions
{
}
