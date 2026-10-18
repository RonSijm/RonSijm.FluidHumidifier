// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerSplitStringFactory(Action<Humidifier.Logs.TransformerTypes.SplitString> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.SplitString>
{

    protected override Humidifier.Logs.TransformerTypes.SplitString Create()
    {
        var splitStringResult = CreateSplitString();
        factoryAction?.Invoke(splitStringResult);

        return splitStringResult;
    }

    private Humidifier.Logs.TransformerTypes.SplitString CreateSplitString()
    {
        var splitStringResult = new Humidifier.Logs.TransformerTypes.SplitString();

        return splitStringResult;
    }

} // End Of Class

public static class InnerTransformerSplitStringFactoryExtensions
{
}
