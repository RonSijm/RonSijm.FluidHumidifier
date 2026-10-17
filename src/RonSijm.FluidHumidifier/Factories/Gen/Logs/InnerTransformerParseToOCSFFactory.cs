// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseToOCSFFactory(Action<Humidifier.Logs.TransformerTypes.ParseToOCSF> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseToOCSF>
{

    protected override Humidifier.Logs.TransformerTypes.ParseToOCSF Create()
    {
        var parseToOCSFResult = CreateParseToOCSF();
        factoryAction?.Invoke(parseToOCSFResult);

        return parseToOCSFResult;
    }

    private Humidifier.Logs.TransformerTypes.ParseToOCSF CreateParseToOCSF()
    {
        var parseToOCSFResult = new Humidifier.Logs.TransformerTypes.ParseToOCSF();

        return parseToOCSFResult;
    }

} // End Of Class

public static class InnerTransformerParseToOCSFFactoryExtensions
{
}
