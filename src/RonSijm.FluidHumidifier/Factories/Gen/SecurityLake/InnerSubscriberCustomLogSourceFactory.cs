// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerSubscriberCustomLogSourceFactory(Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource>
{

    protected override Humidifier.SecurityLake.SubscriberTypes.CustomLogSource Create()
    {
        var customLogSourceResult = CreateCustomLogSource();
        factoryAction?.Invoke(customLogSourceResult);

        return customLogSourceResult;
    }

    private Humidifier.SecurityLake.SubscriberTypes.CustomLogSource CreateCustomLogSource()
    {
        var customLogSourceResult = new Humidifier.SecurityLake.SubscriberTypes.CustomLogSource();

        return customLogSourceResult;
    }

} // End Of Class

public static class InnerSubscriberCustomLogSourceFactoryExtensions
{
}
