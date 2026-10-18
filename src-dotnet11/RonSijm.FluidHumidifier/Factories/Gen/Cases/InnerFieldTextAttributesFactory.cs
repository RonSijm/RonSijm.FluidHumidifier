// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerFieldTextAttributesFactory(Action<Humidifier.Cases.FieldTypes.TextAttributes> factoryAction = null) : SubResourceFactory<Humidifier.Cases.FieldTypes.TextAttributes>
{

    protected override Humidifier.Cases.FieldTypes.TextAttributes Create()
    {
        var textAttributesResult = CreateTextAttributes();
        factoryAction?.Invoke(textAttributesResult);

        return textAttributesResult;
    }

    private Humidifier.Cases.FieldTypes.TextAttributes CreateTextAttributes()
    {
        var textAttributesResult = new Humidifier.Cases.FieldTypes.TextAttributes();

        return textAttributesResult;
    }

} // End Of Class

public static class InnerFieldTextAttributesFactoryExtensions
{
}
