// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseVPCFactory(Action<Humidifier.Logs.TransformerTypes.ParseVPC> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseVPC>
{

    protected override Humidifier.Logs.TransformerTypes.ParseVPC Create()
    {
        var parseVPCResult = CreateParseVPC();
        factoryAction?.Invoke(parseVPCResult);

        return parseVPCResult;
    }

    private Humidifier.Logs.TransformerTypes.ParseVPC CreateParseVPC()
    {
        var parseVPCResult = new Humidifier.Logs.TransformerTypes.ParseVPC();

        return parseVPCResult;
    }

} // End Of Class

public static class InnerTransformerParseVPCFactoryExtensions
{
}
