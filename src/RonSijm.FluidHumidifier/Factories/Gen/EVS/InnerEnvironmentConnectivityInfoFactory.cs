// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EVS;

public class InnerEnvironmentConnectivityInfoFactory(Action<Humidifier.EVS.EnvironmentTypes.ConnectivityInfo> factoryAction = null) : SubResourceFactory<Humidifier.EVS.EnvironmentTypes.ConnectivityInfo>
{

    protected override Humidifier.EVS.EnvironmentTypes.ConnectivityInfo Create()
    {
        var connectivityInfoResult = CreateConnectivityInfo();
        factoryAction?.Invoke(connectivityInfoResult);

        return connectivityInfoResult;
    }

    private Humidifier.EVS.EnvironmentTypes.ConnectivityInfo CreateConnectivityInfo()
    {
        var connectivityInfoResult = new Humidifier.EVS.EnvironmentTypes.ConnectivityInfo();

        return connectivityInfoResult;
    }

} // End Of Class

public static class InnerEnvironmentConnectivityInfoFactoryExtensions
{
}
