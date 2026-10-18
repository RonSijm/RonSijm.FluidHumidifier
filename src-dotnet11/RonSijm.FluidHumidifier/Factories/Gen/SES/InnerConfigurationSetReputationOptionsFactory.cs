// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetReputationOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.ReputationOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.ReputationOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.ReputationOptions Create()
    {
        var reputationOptionsResult = CreateReputationOptions();
        factoryAction?.Invoke(reputationOptionsResult);

        return reputationOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.ReputationOptions CreateReputationOptions()
    {
        var reputationOptionsResult = new Humidifier.SES.ConfigurationSetTypes.ReputationOptions();

        return reputationOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetReputationOptionsFactoryExtensions
{
}
