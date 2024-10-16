// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerConfigurationProfileValidatorsFactory(Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.ConfigurationProfileTypes.Validators>
{

    protected override Humidifier.AppConfig.ConfigurationProfileTypes.Validators Create()
    {
        var validatorsResult = CreateValidators();
        factoryAction?.Invoke(validatorsResult);

        return validatorsResult;
    }

    private Humidifier.AppConfig.ConfigurationProfileTypes.Validators CreateValidators()
    {
        var validatorsResult = new Humidifier.AppConfig.ConfigurationProfileTypes.Validators();

        return validatorsResult;
    }

} // End Of Class

public static class InnerConfigurationProfileValidatorsFactoryExtensions
{
}
