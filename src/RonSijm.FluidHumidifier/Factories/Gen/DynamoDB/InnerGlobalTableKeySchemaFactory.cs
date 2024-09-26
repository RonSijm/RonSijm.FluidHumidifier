// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableKeySchemaFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.KeySchema> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.KeySchema>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.KeySchema Create()
    {
        var keySchemaResult = CreateKeySchema();
        factoryAction?.Invoke(keySchemaResult);

        return keySchemaResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.KeySchema CreateKeySchema()
    {
        var keySchemaResult = new Humidifier.DynamoDB.GlobalTableTypes.KeySchema();

        return keySchemaResult;
    }

} // End Of Class

public static class InnerGlobalTableKeySchemaFactoryExtensions
{
}
