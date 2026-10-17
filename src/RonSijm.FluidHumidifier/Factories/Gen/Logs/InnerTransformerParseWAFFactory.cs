// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseWAFFactory(Action<Humidifier.Logs.TransformerTypes.ParseWAF> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseWAF>
{

    protected override Humidifier.Logs.TransformerTypes.ParseWAF Create()
    {
        var parseWAFResult = CreateParseWAF();
        factoryAction?.Invoke(parseWAFResult);

        return parseWAFResult;
    }

    private Humidifier.Logs.TransformerTypes.ParseWAF CreateParseWAF()
    {
        var parseWAFResult = new Humidifier.Logs.TransformerTypes.ParseWAF();

        return parseWAFResult;
    }

} // End Of Class

public static class InnerTransformerParseWAFFactoryExtensions
{
}
