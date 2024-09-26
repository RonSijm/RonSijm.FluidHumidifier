// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBProxyTagFormatFactory(Action<Humidifier.RDS.DBProxyTypes.TagFormat> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBProxyTypes.TagFormat>
{

    protected override Humidifier.RDS.DBProxyTypes.TagFormat Create()
    {
        var tagFormatResult = CreateTagFormat();
        factoryAction?.Invoke(tagFormatResult);

        return tagFormatResult;
    }

    private Humidifier.RDS.DBProxyTypes.TagFormat CreateTagFormat()
    {
        var tagFormatResult = new Humidifier.RDS.DBProxyTypes.TagFormat();

        return tagFormatResult;
    }

} // End Of Class

public static class InnerDBProxyTagFormatFactoryExtensions
{
}
