// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class CustomDBEngineVersionFactory(string resourceName = null, Action<Humidifier.RDS.CustomDBEngineVersion> factoryAction = null) : ResourceFactory<Humidifier.RDS.CustomDBEngineVersion>(resourceName)
{

    protected override Humidifier.RDS.CustomDBEngineVersion Create()
    {
        var customDBEngineVersionResult = CreateCustomDBEngineVersion();
        factoryAction?.Invoke(customDBEngineVersionResult);

        return customDBEngineVersionResult;
    }

    private Humidifier.RDS.CustomDBEngineVersion CreateCustomDBEngineVersion()
    {
        var customDBEngineVersionResult = new Humidifier.RDS.CustomDBEngineVersion
        {
            GivenName = InputResourceName,
        };

        return customDBEngineVersionResult;
    }

} // End Of Class

public static class CustomDBEngineVersionFactoryExtensions
{
}
