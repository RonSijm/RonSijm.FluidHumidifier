// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetEventDestinationSnsDestinationFactory(Action<Humidifier.SES.ConfigurationSetEventDestinationTypes.SnsDestination> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetEventDestinationTypes.SnsDestination>
{

    protected override Humidifier.SES.ConfigurationSetEventDestinationTypes.SnsDestination Create()
    {
        var snsDestinationResult = CreateSnsDestination();
        factoryAction?.Invoke(snsDestinationResult);

        return snsDestinationResult;
    }

    private Humidifier.SES.ConfigurationSetEventDestinationTypes.SnsDestination CreateSnsDestination()
    {
        var snsDestinationResult = new Humidifier.SES.ConfigurationSetEventDestinationTypes.SnsDestination();

        return snsDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetEventDestinationSnsDestinationFactoryExtensions
{
}
