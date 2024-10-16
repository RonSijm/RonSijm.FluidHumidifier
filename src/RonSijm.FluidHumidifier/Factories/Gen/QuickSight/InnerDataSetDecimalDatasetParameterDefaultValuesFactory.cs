// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDecimalDatasetParameterDefaultValuesFactory(Action<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues>
{

    protected override Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues Create()
    {
        var decimalDatasetParameterDefaultValuesResult = CreateDecimalDatasetParameterDefaultValues();
        factoryAction?.Invoke(decimalDatasetParameterDefaultValuesResult);

        return decimalDatasetParameterDefaultValuesResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues CreateDecimalDatasetParameterDefaultValues()
    {
        var decimalDatasetParameterDefaultValuesResult = new Humidifier.QuickSight.DataSetTypes.DecimalDatasetParameterDefaultValues();

        return decimalDatasetParameterDefaultValuesResult;
    }

} // End Of Class

public static class InnerDataSetDecimalDatasetParameterDefaultValuesFactoryExtensions
{
}
