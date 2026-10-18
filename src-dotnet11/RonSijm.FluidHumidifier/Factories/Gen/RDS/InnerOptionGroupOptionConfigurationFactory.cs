// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerOptionGroupOptionConfigurationFactory(Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RDS.OptionGroupTypes.OptionConfiguration>
{

    protected override Humidifier.RDS.OptionGroupTypes.OptionConfiguration Create()
    {
        var optionConfigurationResult = CreateOptionConfiguration();
        factoryAction?.Invoke(optionConfigurationResult);

        return optionConfigurationResult;
    }

    private Humidifier.RDS.OptionGroupTypes.OptionConfiguration CreateOptionConfiguration()
    {
        var optionConfigurationResult = new Humidifier.RDS.OptionGroupTypes.OptionConfiguration();

        return optionConfigurationResult;
    }

} // End Of Class

public static class InnerOptionGroupOptionConfigurationFactoryExtensions
{
}
