// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayLoggingFormatFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat>
{

    protected override Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat Create()
    {
        var loggingFormatResult = CreateLoggingFormat();
        factoryAction?.Invoke(loggingFormatResult);

        return loggingFormatResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat CreateLoggingFormat()
    {
        var loggingFormatResult = new Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat();

        return loggingFormatResult;
    }

} // End Of Class

public static class InnerVirtualGatewayLoggingFormatFactoryExtensions
{
}
