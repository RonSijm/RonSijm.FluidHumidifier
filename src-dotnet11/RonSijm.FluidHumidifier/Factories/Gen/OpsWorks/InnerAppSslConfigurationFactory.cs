// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerAppSslConfigurationFactory(Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.AppTypes.SslConfiguration>
{

    protected override Humidifier.OpsWorks.AppTypes.SslConfiguration Create()
    {
        var sslConfigurationResult = CreateSslConfiguration();
        factoryAction?.Invoke(sslConfigurationResult);

        return sslConfigurationResult;
    }

    private Humidifier.OpsWorks.AppTypes.SslConfiguration CreateSslConfiguration()
    {
        var sslConfigurationResult = new Humidifier.OpsWorks.AppTypes.SslConfiguration();

        return sslConfigurationResult;
    }

} // End Of Class

public static class InnerAppSslConfigurationFactoryExtensions
{
}
