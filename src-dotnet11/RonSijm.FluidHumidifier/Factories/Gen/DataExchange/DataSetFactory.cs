// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class DataSetFactory(string resourceName = null, Action<Humidifier.DataExchange.DataSet> factoryAction = null) : ResourceFactory<Humidifier.DataExchange.DataSet>(resourceName)
{

    protected override Humidifier.DataExchange.DataSet Create()
    {
        var dataSetResult = CreateDataSet();
        factoryAction?.Invoke(dataSetResult);

        return dataSetResult;
    }

    private Humidifier.DataExchange.DataSet CreateDataSet()
    {
        var dataSetResult = new Humidifier.DataExchange.DataSet
        {
            GivenName = InputResourceName,
        };

        return dataSetResult;
    }

} // End Of Class

public static class DataSetFactoryExtensions
{
}
