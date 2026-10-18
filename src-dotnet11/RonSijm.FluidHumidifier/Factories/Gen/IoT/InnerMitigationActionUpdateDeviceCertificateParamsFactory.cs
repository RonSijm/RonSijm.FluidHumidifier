// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerMitigationActionUpdateDeviceCertificateParamsFactory(Action<Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams> factoryAction = null) : SubResourceFactory<Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams>
{

    protected override Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams Create()
    {
        var updateDeviceCertificateParamsResult = CreateUpdateDeviceCertificateParams();
        factoryAction?.Invoke(updateDeviceCertificateParamsResult);

        return updateDeviceCertificateParamsResult;
    }

    private Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams CreateUpdateDeviceCertificateParams()
    {
        var updateDeviceCertificateParamsResult = new Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams();

        return updateDeviceCertificateParamsResult;
    }

} // End Of Class

public static class InnerMitigationActionUpdateDeviceCertificateParamsFactoryExtensions
{
}
