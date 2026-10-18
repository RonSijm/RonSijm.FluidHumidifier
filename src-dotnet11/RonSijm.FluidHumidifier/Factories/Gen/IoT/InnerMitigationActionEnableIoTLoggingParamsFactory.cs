// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerMitigationActionEnableIoTLoggingParamsFactory(Action<Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams> factoryAction = null) : SubResourceFactory<Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams>
{

    protected override Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams Create()
    {
        var enableIoTLoggingParamsResult = CreateEnableIoTLoggingParams();
        factoryAction?.Invoke(enableIoTLoggingParamsResult);

        return enableIoTLoggingParamsResult;
    }

    private Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams CreateEnableIoTLoggingParams()
    {
        var enableIoTLoggingParamsResult = new Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams();

        return enableIoTLoggingParamsResult;
    }

} // End Of Class

public static class InnerMitigationActionEnableIoTLoggingParamsFactoryExtensions
{
}
