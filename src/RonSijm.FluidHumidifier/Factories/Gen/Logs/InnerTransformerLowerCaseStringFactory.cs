// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerLowerCaseStringFactory(Action<Humidifier.Logs.TransformerTypes.LowerCaseString> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.LowerCaseString>
{

    protected override Humidifier.Logs.TransformerTypes.LowerCaseString Create()
    {
        var lowerCaseStringResult = CreateLowerCaseString();
        factoryAction?.Invoke(lowerCaseStringResult);

        return lowerCaseStringResult;
    }

    private Humidifier.Logs.TransformerTypes.LowerCaseString CreateLowerCaseString()
    {
        var lowerCaseStringResult = new Humidifier.Logs.TransformerTypes.LowerCaseString();

        return lowerCaseStringResult;
    }

} // End Of Class

public static class InnerTransformerLowerCaseStringFactoryExtensions
{
}
