// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSchemaRegistryFactory(Action<Humidifier.Glue.SchemaTypes.Registry> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SchemaTypes.Registry>
{

    protected override Humidifier.Glue.SchemaTypes.Registry Create()
    {
        var registryResult = CreateRegistry();
        factoryAction?.Invoke(registryResult);

        return registryResult;
    }

    private Humidifier.Glue.SchemaTypes.Registry CreateRegistry()
    {
        var registryResult = new Humidifier.Glue.SchemaTypes.Registry();

        return registryResult;
    }

} // End Of Class

public static class InnerSchemaRegistryFactoryExtensions
{
}
