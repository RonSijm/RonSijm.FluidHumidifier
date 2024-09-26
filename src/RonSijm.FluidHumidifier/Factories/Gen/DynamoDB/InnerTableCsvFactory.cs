// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableCsvFactory(Action<Humidifier.DynamoDB.TableTypes.Csv> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.Csv>
{

    protected override Humidifier.DynamoDB.TableTypes.Csv Create()
    {
        var csvResult = CreateCsv();
        factoryAction?.Invoke(csvResult);

        return csvResult;
    }

    private Humidifier.DynamoDB.TableTypes.Csv CreateCsv()
    {
        var csvResult = new Humidifier.DynamoDB.TableTypes.Csv();

        return csvResult;
    }

} // End Of Class

public static class InnerTableCsvFactoryExtensions
{
}
