// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerCodegenJobGraphQLRenderConfigFactory(Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig>
{

    protected override Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig Create()
    {
        var graphQLRenderConfigResult = CreateGraphQLRenderConfig();
        factoryAction?.Invoke(graphQLRenderConfigResult);

        return graphQLRenderConfigResult;
    }

    private Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig CreateGraphQLRenderConfig()
    {
        var graphQLRenderConfigResult = new Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig();

        return graphQLRenderConfigResult;
    }

} // End Of Class

public static class InnerCodegenJobGraphQLRenderConfigFactoryExtensions
{
}
