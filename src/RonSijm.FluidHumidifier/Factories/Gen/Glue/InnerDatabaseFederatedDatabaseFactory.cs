// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerDatabaseFederatedDatabaseFactory(Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> factoryAction = null) : SubResourceFactory<Humidifier.Glue.DatabaseTypes.FederatedDatabase>
{

    protected override Humidifier.Glue.DatabaseTypes.FederatedDatabase Create()
    {
        var federatedDatabaseResult = CreateFederatedDatabase();
        factoryAction?.Invoke(federatedDatabaseResult);

        return federatedDatabaseResult;
    }

    private Humidifier.Glue.DatabaseTypes.FederatedDatabase CreateFederatedDatabase()
    {
        var federatedDatabaseResult = new Humidifier.Glue.DatabaseTypes.FederatedDatabase();

        return federatedDatabaseResult;
    }

} // End Of Class

public static class InnerDatabaseFederatedDatabaseFactoryExtensions
{
}
