// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceCodeConfigurationValuesFactory(Action<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues>
{

    protected override Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues Create()
    {
        var codeConfigurationValuesResult = CreateCodeConfigurationValues();
        factoryAction?.Invoke(codeConfigurationValuesResult);

        return codeConfigurationValuesResult;
    }

    private Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues CreateCodeConfigurationValues()
    {
        var codeConfigurationValuesResult = new Humidifier.AppRunner.ServiceTypes.CodeConfigurationValues();

        return codeConfigurationValuesResult;
    }

} // End Of Class

public static class InnerServiceCodeConfigurationValuesFactoryExtensions
{
}
