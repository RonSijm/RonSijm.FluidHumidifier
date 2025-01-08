// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseKeyValueFactory(Action<Humidifier.Logs.TransformerTypes.ParseKeyValue> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseKeyValue>
{

    protected override Humidifier.Logs.TransformerTypes.ParseKeyValue Create()
    {
        var parseKeyValueResult = CreateParseKeyValue();
        factoryAction?.Invoke(parseKeyValueResult);

        return parseKeyValueResult;
    }

    private Humidifier.Logs.TransformerTypes.ParseKeyValue CreateParseKeyValue()
    {
        var parseKeyValueResult = new Humidifier.Logs.TransformerTypes.ParseKeyValue();

        return parseKeyValueResult;
    }

} // End Of Class

public static class InnerTransformerParseKeyValueFactoryExtensions
{
}
