// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerGrokFactory(Action<Humidifier.Logs.TransformerTypes.Grok> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.Grok>
{

    protected override Humidifier.Logs.TransformerTypes.Grok Create()
    {
        var grokResult = CreateGrok();
        factoryAction?.Invoke(grokResult);

        return grokResult;
    }

    private Humidifier.Logs.TransformerTypes.Grok CreateGrok()
    {
        var grokResult = new Humidifier.Logs.TransformerTypes.Grok();

        return grokResult;
    }

} // End Of Class

public static class InnerTransformerGrokFactoryExtensions
{
}
