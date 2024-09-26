// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class GraphQLSchemaFactory(string resourceName = null, Action<Humidifier.AppSync.GraphQLSchema> factoryAction = null) : ResourceFactory<Humidifier.AppSync.GraphQLSchema>(resourceName)
{

    protected override Humidifier.AppSync.GraphQLSchema Create()
    {
        var graphQLSchemaResult = CreateGraphQLSchema();
        factoryAction?.Invoke(graphQLSchemaResult);

        return graphQLSchemaResult;
    }

    private Humidifier.AppSync.GraphQLSchema CreateGraphQLSchema()
    {
        var graphQLSchemaResult = new Humidifier.AppSync.GraphQLSchema
        {
            GivenName = InputResourceName,
        };

        return graphQLSchemaResult;
    }

} // End Of Class

public static class GraphQLSchemaFactoryExtensions
{
}
