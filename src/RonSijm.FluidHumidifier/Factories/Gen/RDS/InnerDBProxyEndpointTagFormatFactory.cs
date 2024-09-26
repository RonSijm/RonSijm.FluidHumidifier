// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBProxyEndpointTagFormatFactory(Action<Humidifier.RDS.DBProxyEndpointTypes.TagFormat> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBProxyEndpointTypes.TagFormat>
{

    protected override Humidifier.RDS.DBProxyEndpointTypes.TagFormat Create()
    {
        var tagFormatResult = CreateTagFormat();
        factoryAction?.Invoke(tagFormatResult);

        return tagFormatResult;
    }

    private Humidifier.RDS.DBProxyEndpointTypes.TagFormat CreateTagFormat()
    {
        var tagFormatResult = new Humidifier.RDS.DBProxyEndpointTypes.TagFormat();

        return tagFormatResult;
    }

} // End Of Class

public static class InnerDBProxyEndpointTagFormatFactoryExtensions
{
}
