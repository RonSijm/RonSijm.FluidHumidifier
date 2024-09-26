// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerDatabaseDatabaseIdentifierFactory(Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier>
{

    protected override Humidifier.Glue.DatabaseTypes.DatabaseIdentifier Create()
    {
        var databaseIdentifierResult = CreateDatabaseIdentifier();
        factoryAction?.Invoke(databaseIdentifierResult);

        return databaseIdentifierResult;
    }

    private Humidifier.Glue.DatabaseTypes.DatabaseIdentifier CreateDatabaseIdentifier()
    {
        var databaseIdentifierResult = new Humidifier.Glue.DatabaseTypes.DatabaseIdentifier();

        return databaseIdentifierResult;
    }

} // End Of Class

public static class InnerDatabaseDatabaseIdentifierFactoryExtensions
{
}
