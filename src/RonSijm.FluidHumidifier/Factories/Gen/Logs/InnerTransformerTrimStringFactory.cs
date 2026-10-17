// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerTrimStringFactory(Action<Humidifier.Logs.TransformerTypes.TrimString> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.TrimString>
{

    protected override Humidifier.Logs.TransformerTypes.TrimString Create()
    {
        var trimStringResult = CreateTrimString();
        factoryAction?.Invoke(trimStringResult);

        return trimStringResult;
    }

    private Humidifier.Logs.TransformerTypes.TrimString CreateTrimString()
    {
        var trimStringResult = new Humidifier.Logs.TransformerTypes.TrimString();

        return trimStringResult;
    }

} // End Of Class

public static class InnerTransformerTrimStringFactoryExtensions
{
}
