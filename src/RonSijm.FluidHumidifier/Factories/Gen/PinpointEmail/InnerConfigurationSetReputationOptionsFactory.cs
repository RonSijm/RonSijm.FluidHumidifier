// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetReputationOptionsFactory(Action<Humidifier.PinpointEmail.ConfigurationSetTypes.ReputationOptions> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetTypes.ReputationOptions>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetTypes.ReputationOptions Create()
    {
        var reputationOptionsResult = CreateReputationOptions();
        factoryAction?.Invoke(reputationOptionsResult);

        return reputationOptionsResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetTypes.ReputationOptions CreateReputationOptions()
    {
        var reputationOptionsResult = new Humidifier.PinpointEmail.ConfigurationSetTypes.ReputationOptions();

        return reputationOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetReputationOptionsFactoryExtensions
{
}
