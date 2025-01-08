// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseRoute53Factory(Action<Humidifier.Logs.TransformerTypes.ParseRoute53> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseRoute53>
{

    protected override Humidifier.Logs.TransformerTypes.ParseRoute53 Create()
    {
        var parseRoute53Result = CreateParseRoute53();
        factoryAction?.Invoke(parseRoute53Result);

        return parseRoute53Result;
    }

    private Humidifier.Logs.TransformerTypes.ParseRoute53 CreateParseRoute53()
    {
        var parseRoute53Result = new Humidifier.Logs.TransformerTypes.ParseRoute53();

        return parseRoute53Result;
    }

} // End Of Class

public static class InnerTransformerParseRoute53FactoryExtensions
{
}
