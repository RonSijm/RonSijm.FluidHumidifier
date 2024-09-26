// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ApprovedOriginFactory(string resourceName = null, Action<Humidifier.Connect.ApprovedOrigin> factoryAction = null) : ResourceFactory<Humidifier.Connect.ApprovedOrigin>(resourceName)
{

    protected override Humidifier.Connect.ApprovedOrigin Create()
    {
        var approvedOriginResult = CreateApprovedOrigin();
        factoryAction?.Invoke(approvedOriginResult);

        return approvedOriginResult;
    }

    private Humidifier.Connect.ApprovedOrigin CreateApprovedOrigin()
    {
        var approvedOriginResult = new Humidifier.Connect.ApprovedOrigin
        {
            GivenName = InputResourceName,
        };

        return approvedOriginResult;
    }

} // End Of Class

public static class ApprovedOriginFactoryExtensions
{
}
