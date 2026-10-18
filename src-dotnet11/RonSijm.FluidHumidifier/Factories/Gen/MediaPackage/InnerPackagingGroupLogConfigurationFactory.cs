// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingGroupLogConfigurationFactory(Action<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration>
{

    protected override Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.MediaPackage.PackagingGroupTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerPackagingGroupLogConfigurationFactoryExtensions
{
}
