// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationHDFSQopConfigurationFactory(Action<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationHDFSTypes.QopConfiguration>
{

    protected override Humidifier.DataSync.LocationHDFSTypes.QopConfiguration Create()
    {
        var qopConfigurationResult = CreateQopConfiguration();
        factoryAction?.Invoke(qopConfigurationResult);

        return qopConfigurationResult;
    }

    private Humidifier.DataSync.LocationHDFSTypes.QopConfiguration CreateQopConfiguration()
    {
        var qopConfigurationResult = new Humidifier.DataSync.LocationHDFSTypes.QopConfiguration();

        return qopConfigurationResult;
    }

} // End Of Class

public static class InnerLocationHDFSQopConfigurationFactoryExtensions
{
}
