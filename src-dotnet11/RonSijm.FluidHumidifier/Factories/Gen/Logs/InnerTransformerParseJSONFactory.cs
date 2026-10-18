// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseJSONFactory(Action<Humidifier.Logs.TransformerTypes.ParseJSON> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseJSON>
{

    protected override Humidifier.Logs.TransformerTypes.ParseJSON Create()
    {
        var parseJSONResult = CreateParseJSON();
        factoryAction?.Invoke(parseJSONResult);

        return parseJSONResult;
    }

    private Humidifier.Logs.TransformerTypes.ParseJSON CreateParseJSON()
    {
        var parseJSONResult = new Humidifier.Logs.TransformerTypes.ParseJSON();

        return parseJSONResult;
    }

} // End Of Class

public static class InnerTransformerParseJSONFactoryExtensions
{
}
