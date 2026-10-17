// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerConnectionFunctionConnectionFunctionConfigFactory(Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig>
{

    protected override Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig Create()
    {
        var connectionFunctionConfigResult = CreateConnectionFunctionConfig();
        factoryAction?.Invoke(connectionFunctionConfigResult);

        return connectionFunctionConfigResult;
    }

    private Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig CreateConnectionFunctionConfig()
    {
        var connectionFunctionConfigResult = new Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig();

        return connectionFunctionConfigResult;
    }

} // End Of Class

public static class InnerConnectionFunctionConnectionFunctionConfigFactoryExtensions
{
}
