// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerConfigurationSetSnsDestinationFactory(Action<Humidifier.SMSVOICE.ConfigurationSetTypes.SnsDestination> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.ConfigurationSetTypes.SnsDestination>
{

    protected override Humidifier.SMSVOICE.ConfigurationSetTypes.SnsDestination Create()
    {
        var snsDestinationResult = CreateSnsDestination();
        factoryAction?.Invoke(snsDestinationResult);

        return snsDestinationResult;
    }

    private Humidifier.SMSVOICE.ConfigurationSetTypes.SnsDestination CreateSnsDestination()
    {
        var snsDestinationResult = new Humidifier.SMSVOICE.ConfigurationSetTypes.SnsDestination();

        return snsDestinationResult;
    }

} // End Of Class

public static class InnerConfigurationSetSnsDestinationFactoryExtensions
{
}
