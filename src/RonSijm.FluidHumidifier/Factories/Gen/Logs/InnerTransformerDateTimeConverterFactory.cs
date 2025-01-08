// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerDateTimeConverterFactory(Action<Humidifier.Logs.TransformerTypes.DateTimeConverter> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.DateTimeConverter>
{

    protected override Humidifier.Logs.TransformerTypes.DateTimeConverter Create()
    {
        var dateTimeConverterResult = CreateDateTimeConverter();
        factoryAction?.Invoke(dateTimeConverterResult);

        return dateTimeConverterResult;
    }

    private Humidifier.Logs.TransformerTypes.DateTimeConverter CreateDateTimeConverter()
    {
        var dateTimeConverterResult = new Humidifier.Logs.TransformerTypes.DateTimeConverter();

        return dateTimeConverterResult;
    }

} // End Of Class

public static class InnerTransformerDateTimeConverterFactoryExtensions
{
}
