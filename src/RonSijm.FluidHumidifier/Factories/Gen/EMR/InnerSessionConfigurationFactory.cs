// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerSessionConfigurationFactory(Action<Humidifier.EMR.SessionTypes.Configuration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.SessionTypes.Configuration>
{

    protected override Humidifier.EMR.SessionTypes.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.EMR.SessionTypes.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.EMR.SessionTypes.Configuration();

        return configurationResult;
    }

} // End Of Class

public static class InnerSessionConfigurationFactoryExtensions
{
}
