// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorSCEP;

public class InnerConnectorIntuneConfigurationFactory(Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration>
{

    protected override Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration Create()
    {
        var intuneConfigurationResult = CreateIntuneConfiguration();
        factoryAction?.Invoke(intuneConfigurationResult);

        return intuneConfigurationResult;
    }

    private Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration CreateIntuneConfiguration()
    {
        var intuneConfigurationResult = new Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration();

        return intuneConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorIntuneConfigurationFactoryExtensions
{
}
