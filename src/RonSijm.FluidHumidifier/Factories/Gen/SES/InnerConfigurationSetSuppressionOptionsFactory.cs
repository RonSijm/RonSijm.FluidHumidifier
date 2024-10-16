// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetSuppressionOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.SuppressionOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.SuppressionOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.SuppressionOptions Create()
    {
        var suppressionOptionsResult = CreateSuppressionOptions();
        factoryAction?.Invoke(suppressionOptionsResult);

        return suppressionOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.SuppressionOptions CreateSuppressionOptions()
    {
        var suppressionOptionsResult = new Humidifier.SES.ConfigurationSetTypes.SuppressionOptions();

        return suppressionOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetSuppressionOptionsFactoryExtensions
{
}
