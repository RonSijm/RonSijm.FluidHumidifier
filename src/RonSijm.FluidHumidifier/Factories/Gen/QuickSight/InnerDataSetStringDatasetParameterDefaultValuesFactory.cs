// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetStringDatasetParameterDefaultValuesFactory(Action<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues>
{

    protected override Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues Create()
    {
        var stringDatasetParameterDefaultValuesResult = CreateStringDatasetParameterDefaultValues();
        factoryAction?.Invoke(stringDatasetParameterDefaultValuesResult);

        return stringDatasetParameterDefaultValuesResult;
    }

    private Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues CreateStringDatasetParameterDefaultValues()
    {
        var stringDatasetParameterDefaultValuesResult = new Humidifier.QuickSight.DataSetTypes.StringDatasetParameterDefaultValues();

        return stringDatasetParameterDefaultValuesResult;
    }

} // End Of Class

public static class InnerDataSetStringDatasetParameterDefaultValuesFactoryExtensions
{
}
