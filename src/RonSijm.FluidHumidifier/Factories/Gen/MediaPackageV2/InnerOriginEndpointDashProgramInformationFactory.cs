// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashProgramInformationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashProgramInformation> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashProgramInformation>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashProgramInformation Create()
    {
        var dashProgramInformationResult = CreateDashProgramInformation();
        factoryAction?.Invoke(dashProgramInformationResult);

        return dashProgramInformationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashProgramInformation CreateDashProgramInformation()
    {
        var dashProgramInformationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashProgramInformation();

        return dashProgramInformationResult;
    }

} // End Of Class

public static class InnerOriginEndpointDashProgramInformationFactoryExtensions
{
}
