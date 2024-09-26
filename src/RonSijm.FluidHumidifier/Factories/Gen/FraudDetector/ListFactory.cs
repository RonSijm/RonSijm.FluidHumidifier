// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class ListFactory(string resourceName = null, Action<Humidifier.FraudDetector.List> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.List>(resourceName)
{

    protected override Humidifier.FraudDetector.List Create()
    {
        var listResult = CreateList();
        factoryAction?.Invoke(listResult);

        return listResult;
    }

    private Humidifier.FraudDetector.List CreateList()
    {
        var listResult = new Humidifier.FraudDetector.List
        {
            GivenName = InputResourceName,
        };

        return listResult;
    }

} // End Of Class

public static class ListFactoryExtensions
{
}
