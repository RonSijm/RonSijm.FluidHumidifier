// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerPredefinedAttributeValuesFactory(Action<Humidifier.Connect.PredefinedAttributeTypes.Values> factoryAction = null) : SubResourceFactory<Humidifier.Connect.PredefinedAttributeTypes.Values>
{

    protected override Humidifier.Connect.PredefinedAttributeTypes.Values Create()
    {
        var valuesResult = CreateValues();
        factoryAction?.Invoke(valuesResult);

        return valuesResult;
    }

    private Humidifier.Connect.PredefinedAttributeTypes.Values CreateValues()
    {
        var valuesResult = new Humidifier.Connect.PredefinedAttributeTypes.Values();

        return valuesResult;
    }

} // End Of Class

public static class InnerPredefinedAttributeValuesFactoryExtensions
{
}
