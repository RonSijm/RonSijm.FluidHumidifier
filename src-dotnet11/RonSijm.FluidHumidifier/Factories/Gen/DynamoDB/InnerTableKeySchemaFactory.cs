// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableKeySchemaFactory(Action<Humidifier.DynamoDB.TableTypes.KeySchema> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.KeySchema>
{

    protected override Humidifier.DynamoDB.TableTypes.KeySchema Create()
    {
        var keySchemaResult = CreateKeySchema();
        factoryAction?.Invoke(keySchemaResult);

        return keySchemaResult;
    }

    private Humidifier.DynamoDB.TableTypes.KeySchema CreateKeySchema()
    {
        var keySchemaResult = new Humidifier.DynamoDB.TableTypes.KeySchema();

        return keySchemaResult;
    }

} // End Of Class

public static class InnerTableKeySchemaFactoryExtensions
{
}
