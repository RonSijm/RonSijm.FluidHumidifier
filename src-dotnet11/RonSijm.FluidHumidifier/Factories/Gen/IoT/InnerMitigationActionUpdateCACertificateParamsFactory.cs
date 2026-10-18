// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerMitigationActionUpdateCACertificateParamsFactory(Action<Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams> factoryAction = null) : SubResourceFactory<Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams>
{

    protected override Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams Create()
    {
        var updateCACertificateParamsResult = CreateUpdateCACertificateParams();
        factoryAction?.Invoke(updateCACertificateParamsResult);

        return updateCACertificateParamsResult;
    }

    private Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams CreateUpdateCACertificateParams()
    {
        var updateCACertificateParamsResult = new Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams();

        return updateCACertificateParamsResult;
    }

} // End Of Class

public static class InnerMitigationActionUpdateCACertificateParamsFactoryExtensions
{
}
