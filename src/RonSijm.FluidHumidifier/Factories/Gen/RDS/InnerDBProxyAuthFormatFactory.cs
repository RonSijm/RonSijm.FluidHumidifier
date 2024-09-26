// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBProxyAuthFormatFactory(Action<Humidifier.RDS.DBProxyTypes.AuthFormat> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBProxyTypes.AuthFormat>
{

    protected override Humidifier.RDS.DBProxyTypes.AuthFormat Create()
    {
        var authFormatResult = CreateAuthFormat();
        factoryAction?.Invoke(authFormatResult);

        return authFormatResult;
    }

    private Humidifier.RDS.DBProxyTypes.AuthFormat CreateAuthFormat()
    {
        var authFormatResult = new Humidifier.RDS.DBProxyTypes.AuthFormat();

        return authFormatResult;
    }

} // End Of Class

public static class InnerDBProxyAuthFormatFactoryExtensions
{
}
