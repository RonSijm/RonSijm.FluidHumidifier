// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDateTimeDatasetParameterDefaultValuesFactory(Action<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues>
{

    protected override Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues Create()
    {
        var dateTimeDatasetParameterDefaultValuesResult = CreateDateTimeDatasetParameterDefaultValues();
        factoryAction?.Invoke(dateTimeDatasetParameterDefaultValuesResult);

        return dateTimeDatasetParameterDefaultValuesResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues CreateDateTimeDatasetParameterDefaultValues()
    {
        var dateTimeDatasetParameterDefaultValuesResult = new Humidifier.QuickSight.DataSetTypes.DateTimeDatasetParameterDefaultValues();

        return dateTimeDatasetParameterDefaultValuesResult;
    }

} // End Of Class

public static class InnerDataSetDateTimeDatasetParameterDefaultValuesFactoryExtensions
{
}
