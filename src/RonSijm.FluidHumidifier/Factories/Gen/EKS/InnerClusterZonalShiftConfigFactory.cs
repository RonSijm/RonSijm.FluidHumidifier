// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterZonalShiftConfigFactory(Action<Humidifier.EKS.ClusterTypes.ZonalShiftConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ZonalShiftConfig>
{

    protected override Humidifier.EKS.ClusterTypes.ZonalShiftConfig Create()
    {
        var zonalShiftConfigResult = CreateZonalShiftConfig();
        factoryAction?.Invoke(zonalShiftConfigResult);

        return zonalShiftConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.ZonalShiftConfig CreateZonalShiftConfig()
    {
        var zonalShiftConfigResult = new Humidifier.EKS.ClusterTypes.ZonalShiftConfig();

        return zonalShiftConfigResult;
    }

} // End Of Class

public static class InnerClusterZonalShiftConfigFactoryExtensions
{
}
