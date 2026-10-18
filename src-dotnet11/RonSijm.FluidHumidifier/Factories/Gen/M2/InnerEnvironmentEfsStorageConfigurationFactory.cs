// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class InnerEnvironmentEfsStorageConfigurationFactory(Action<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration>
{

    protected override Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration Create()
    {
        var efsStorageConfigurationResult = CreateEfsStorageConfiguration();
        factoryAction?.Invoke(efsStorageConfigurationResult);

        return efsStorageConfigurationResult;
    }

    private Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration CreateEfsStorageConfiguration()
    {
        var efsStorageConfigurationResult = new Humidifier.M2.EnvironmentTypes.EfsStorageConfiguration();

        return efsStorageConfigurationResult;
    }

} // End Of Class

public static class InnerEnvironmentEfsStorageConfigurationFactoryExtensions
{
}
