// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerTypeConverterFactory(Action<Humidifier.Logs.TransformerTypes.TypeConverter> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.TypeConverter>
{

    protected override Humidifier.Logs.TransformerTypes.TypeConverter Create()
    {
        var typeConverterResult = CreateTypeConverter();
        factoryAction?.Invoke(typeConverterResult);

        return typeConverterResult;
    }

    private Humidifier.Logs.TransformerTypes.TypeConverter CreateTypeConverter()
    {
        var typeConverterResult = new Humidifier.Logs.TransformerTypes.TypeConverter();

        return typeConverterResult;
    }

} // End Of Class

public static class InnerTransformerTypeConverterFactoryExtensions
{
}
