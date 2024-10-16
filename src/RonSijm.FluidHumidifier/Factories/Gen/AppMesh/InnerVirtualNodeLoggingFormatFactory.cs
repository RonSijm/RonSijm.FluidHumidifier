// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeLoggingFormatFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat Create()
    {
        var loggingFormatResult = CreateLoggingFormat();
        factoryAction?.Invoke(loggingFormatResult);

        return loggingFormatResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat CreateLoggingFormat()
    {
        var loggingFormatResult = new Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat();

        return loggingFormatResult;
    }

} // End Of Class

public static class InnerVirtualNodeLoggingFormatFactoryExtensions
{
}
