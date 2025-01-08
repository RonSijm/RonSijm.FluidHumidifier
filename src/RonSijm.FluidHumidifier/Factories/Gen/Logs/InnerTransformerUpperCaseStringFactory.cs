// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerUpperCaseStringFactory(Action<Humidifier.Logs.TransformerTypes.UpperCaseString> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.UpperCaseString>
{

    protected override Humidifier.Logs.TransformerTypes.UpperCaseString Create()
    {
        var upperCaseStringResult = CreateUpperCaseString();
        factoryAction?.Invoke(upperCaseStringResult);

        return upperCaseStringResult;
    }

    private Humidifier.Logs.TransformerTypes.UpperCaseString CreateUpperCaseString()
    {
        var upperCaseStringResult = new Humidifier.Logs.TransformerTypes.UpperCaseString();

        return upperCaseStringResult;
    }

} // End Of Class

public static class InnerTransformerUpperCaseStringFactoryExtensions
{
}
