// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class InnerEnvironmentFsxStorageConfigurationFactory(Action<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration>
{

    protected override Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration Create()
    {
        var fsxStorageConfigurationResult = CreateFsxStorageConfiguration();
        factoryAction?.Invoke(fsxStorageConfigurationResult);

        return fsxStorageConfigurationResult;
    }

    private Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration CreateFsxStorageConfiguration()
    {
        var fsxStorageConfigurationResult = new Humidifier.M2.EnvironmentTypes.FsxStorageConfiguration();

        return fsxStorageConfigurationResult;
    }

} // End Of Class

public static class InnerEnvironmentFsxStorageConfigurationFactoryExtensions
{
}
