// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class QEV2IdcApplicationFactory(string resourceName = null, Action<Humidifier.Redshift.QEV2IdcApplication> factoryAction = null) : ResourceFactory<Humidifier.Redshift.QEV2IdcApplication>(resourceName)
{

    protected override Humidifier.Redshift.QEV2IdcApplication Create()
    {
        var qEV2IdcApplicationResult = CreateQEV2IdcApplication();
        factoryAction?.Invoke(qEV2IdcApplicationResult);

        return qEV2IdcApplicationResult;
    }

    private Humidifier.Redshift.QEV2IdcApplication CreateQEV2IdcApplication()
    {
        var qEV2IdcApplicationResult = new Humidifier.Redshift.QEV2IdcApplication
        {
            GivenName = InputResourceName,
        };

        return qEV2IdcApplicationResult;
    }

} // End Of Class

public static class QEV2IdcApplicationFactoryExtensions
{
}
