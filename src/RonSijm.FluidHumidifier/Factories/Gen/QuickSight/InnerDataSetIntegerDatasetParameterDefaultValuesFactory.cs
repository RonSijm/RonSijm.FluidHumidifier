// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetIntegerDatasetParameterDefaultValuesFactory(Action<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues>
{

    protected override Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues Create()
    {
        var integerDatasetParameterDefaultValuesResult = CreateIntegerDatasetParameterDefaultValues();
        factoryAction?.Invoke(integerDatasetParameterDefaultValuesResult);

        return integerDatasetParameterDefaultValuesResult;
    }

    private Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues CreateIntegerDatasetParameterDefaultValues()
    {
        var integerDatasetParameterDefaultValuesResult = new Humidifier.QuickSight.DataSetTypes.IntegerDatasetParameterDefaultValues();

        return integerDatasetParameterDefaultValuesResult;
    }

} // End Of Class

public static class InnerDataSetIntegerDatasetParameterDefaultValuesFactoryExtensions
{
}
