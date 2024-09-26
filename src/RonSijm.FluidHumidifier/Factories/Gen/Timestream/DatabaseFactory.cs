// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class DatabaseFactory(string resourceName = null, Action<Humidifier.Timestream.Database> factoryAction = null) : ResourceFactory<Humidifier.Timestream.Database>(resourceName)
{

    protected override Humidifier.Timestream.Database Create()
    {
        var databaseResult = CreateDatabase();
        factoryAction?.Invoke(databaseResult);

        return databaseResult;
    }

    private Humidifier.Timestream.Database CreateDatabase()
    {
        var databaseResult = new Humidifier.Timestream.Database
        {
            GivenName = InputResourceName,
        };

        return databaseResult;
    }

} // End Of Class

public static class DatabaseFactoryExtensions
{
}
