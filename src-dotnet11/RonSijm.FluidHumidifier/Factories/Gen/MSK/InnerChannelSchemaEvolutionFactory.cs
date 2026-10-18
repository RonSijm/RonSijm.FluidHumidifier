// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelSchemaEvolutionFactory(Action<Humidifier.MSK.ChannelTypes.SchemaEvolution> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.SchemaEvolution>
{

    protected override Humidifier.MSK.ChannelTypes.SchemaEvolution Create()
    {
        var schemaEvolutionResult = CreateSchemaEvolution();
        factoryAction?.Invoke(schemaEvolutionResult);

        return schemaEvolutionResult;
    }

    private Humidifier.MSK.ChannelTypes.SchemaEvolution CreateSchemaEvolution()
    {
        var schemaEvolutionResult = new Humidifier.MSK.ChannelTypes.SchemaEvolution();

        return schemaEvolutionResult;
    }

} // End Of Class

public static class InnerChannelSchemaEvolutionFactoryExtensions
{
}
