// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerServiceNetworkSharingConfigFactory(Action<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig>
{

    protected override Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig Create()
    {
        var sharingConfigResult = CreateSharingConfig();
        factoryAction?.Invoke(sharingConfigResult);

        return sharingConfigResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig CreateSharingConfig()
    {
        var sharingConfigResult = new Humidifier.VpcLattice.ServiceNetworkTypes.SharingConfig();

        return sharingConfigResult;
    }

} // End Of Class

public static class InnerServiceNetworkSharingConfigFactoryExtensions
{
}
