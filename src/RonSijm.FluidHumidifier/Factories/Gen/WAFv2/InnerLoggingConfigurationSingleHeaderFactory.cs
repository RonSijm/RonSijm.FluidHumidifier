// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerLoggingConfigurationSingleHeaderFactory(Action<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader>
{

    protected override Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader Create()
    {
        var singleHeaderResult = CreateSingleHeader();
        factoryAction?.Invoke(singleHeaderResult);

        return singleHeaderResult;
    }

    private Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader CreateSingleHeader()
    {
        var singleHeaderResult = new Humidifier.WAFv2.LoggingConfigurationTypes.SingleHeader();

        return singleHeaderResult;
    }

} // End Of Class

public static class InnerLoggingConfigurationSingleHeaderFactoryExtensions
{
}
