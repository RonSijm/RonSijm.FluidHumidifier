// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class TargetAccountConfigurationFactory(string resourceName = null, Action<Humidifier.FIS.TargetAccountConfiguration> factoryAction = null) : ResourceFactory<Humidifier.FIS.TargetAccountConfiguration>(resourceName)
{

    protected override Humidifier.FIS.TargetAccountConfiguration Create()
    {
        var targetAccountConfigurationResult = CreateTargetAccountConfiguration();
        factoryAction?.Invoke(targetAccountConfigurationResult);

        return targetAccountConfigurationResult;
    }

    private Humidifier.FIS.TargetAccountConfiguration CreateTargetAccountConfiguration()
    {
        var targetAccountConfigurationResult = new Humidifier.FIS.TargetAccountConfiguration
        {
            GivenName = InputResourceName,
        };

        return targetAccountConfigurationResult;
    }

} // End Of Class

public static class TargetAccountConfigurationFactoryExtensions
{
}
