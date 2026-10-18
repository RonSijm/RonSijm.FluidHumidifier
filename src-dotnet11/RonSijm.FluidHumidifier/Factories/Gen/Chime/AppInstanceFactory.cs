// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class AppInstanceFactory(string resourceName = null, Action<Humidifier.Chime.AppInstance> factoryAction = null) : ResourceFactory<Humidifier.Chime.AppInstance>(resourceName)
{

    protected override Humidifier.Chime.AppInstance Create()
    {
        var appInstanceResult = CreateAppInstance();
        factoryAction?.Invoke(appInstanceResult);

        return appInstanceResult;
    }

    private Humidifier.Chime.AppInstance CreateAppInstance()
    {
        var appInstanceResult = new Humidifier.Chime.AppInstance
        {
            GivenName = InputResourceName,
        };

        return appInstanceResult;
    }

} // End Of Class

public static class AppInstanceFactoryExtensions
{
}
