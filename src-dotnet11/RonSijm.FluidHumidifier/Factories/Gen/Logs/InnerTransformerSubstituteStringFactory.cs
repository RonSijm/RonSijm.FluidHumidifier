// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerSubstituteStringFactory(Action<Humidifier.Logs.TransformerTypes.SubstituteString> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.SubstituteString>
{

    protected override Humidifier.Logs.TransformerTypes.SubstituteString Create()
    {
        var substituteStringResult = CreateSubstituteString();
        factoryAction?.Invoke(substituteStringResult);

        return substituteStringResult;
    }

    private Humidifier.Logs.TransformerTypes.SubstituteString CreateSubstituteString()
    {
        var substituteStringResult = new Humidifier.Logs.TransformerTypes.SubstituteString();

        return substituteStringResult;
    }

} // End Of Class

public static class InnerTransformerSubstituteStringFactoryExtensions
{
}
