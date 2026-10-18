// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerEventSourceOnFailureConfigurationFactory(Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration>
{

    protected override Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration Create()
    {
        var onFailureConfigurationResult = CreateOnFailureConfiguration();
        factoryAction?.Invoke(onFailureConfigurationResult);

        return onFailureConfigurationResult;
    }

    private Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration CreateOnFailureConfiguration()
    {
        var onFailureConfigurationResult = new Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration();

        return onFailureConfigurationResult;
    }

} // End Of Class

public static class InnerEventSourceOnFailureConfigurationFactoryExtensions
{
}
