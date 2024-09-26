// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class SchemaFactory(string resourceName = null, Action<Humidifier.Personalize.Schema> factoryAction = null) : ResourceFactory<Humidifier.Personalize.Schema>(resourceName)
{

    protected override Humidifier.Personalize.Schema Create()
    {
        var schemaResult = CreateSchema();
        factoryAction?.Invoke(schemaResult);

        return schemaResult;
    }

    private Humidifier.Personalize.Schema CreateSchema()
    {
        var schemaResult = new Humidifier.Personalize.Schema
        {
            GivenName = InputResourceName,
        };

        return schemaResult;
    }

} // End Of Class

public static class SchemaFactoryExtensions
{
}
