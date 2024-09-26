// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetEventDestinationSnsDestinationFactory(Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.SnsDestination> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.SnsDestination>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.SnsDestination Create()
    {
        var snsDestinationResult = CreateSnsDestination();
        factoryAction?.Invoke(snsDestinationResult);

        return snsDestinationResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.SnsDestination CreateSnsDestination()
    {
        var snsDestinationResult = new Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.SnsDestination();

        return snsDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationSnsDestinationFactoryExtensions
{
}
