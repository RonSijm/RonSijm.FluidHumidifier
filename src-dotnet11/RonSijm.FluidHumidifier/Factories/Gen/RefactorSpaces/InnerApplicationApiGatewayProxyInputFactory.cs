// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class InnerApplicationApiGatewayProxyInputFactory(Action<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput> factoryAction = null) : SubResourceFactory<Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput>
{

    protected override Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput Create()
    {
        var apiGatewayProxyInputResult = CreateApiGatewayProxyInput();
        factoryAction?.Invoke(apiGatewayProxyInputResult);

        return apiGatewayProxyInputResult;
    }

    private Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput CreateApiGatewayProxyInput()
    {
        var apiGatewayProxyInputResult = new Humidifier.RefactorSpaces.ApplicationTypes.ApiGatewayProxyInput();

        return apiGatewayProxyInputResult;
    }

} // End Of Class

public static class InnerApplicationApiGatewayProxyInputFactoryExtensions
{
}
