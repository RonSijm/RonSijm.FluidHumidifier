// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerSessionSessionS3LoggingConfigurationFactory(Action<Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration>
{

    protected override Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration Create()
    {
        var sessionS3LoggingConfigurationResult = CreateSessionS3LoggingConfiguration();
        factoryAction?.Invoke(sessionS3LoggingConfigurationResult);

        return sessionS3LoggingConfigurationResult;
    }

    private Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration CreateSessionS3LoggingConfiguration()
    {
        var sessionS3LoggingConfigurationResult = new Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration();

        return sessionS3LoggingConfigurationResult;
    }

} // End Of Class

public static class InnerSessionSessionS3LoggingConfigurationFactoryExtensions
{
}
