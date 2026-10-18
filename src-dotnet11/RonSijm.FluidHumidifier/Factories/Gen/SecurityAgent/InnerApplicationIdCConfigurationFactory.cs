// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerApplicationIdCConfigurationFactory(Action<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration>
{

    protected override Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration Create()
    {
        var idCConfigurationResult = CreateIdCConfiguration();
        factoryAction?.Invoke(idCConfigurationResult);

        return idCConfigurationResult;
    }

    private Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration CreateIdCConfiguration()
    {
        var idCConfigurationResult = new Humidifier.SecurityAgent.ApplicationTypes.IdCConfiguration();

        return idCConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationIdCConfigurationFactoryExtensions
{
}
