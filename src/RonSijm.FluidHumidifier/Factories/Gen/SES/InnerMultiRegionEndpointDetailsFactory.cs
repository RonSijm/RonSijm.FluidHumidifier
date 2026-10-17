// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMultiRegionEndpointDetailsFactory(Action<Humidifier.SES.MultiRegionEndpointTypes.Details> factoryAction = null) : SubResourceFactory<Humidifier.SES.MultiRegionEndpointTypes.Details>
{

    protected override Humidifier.SES.MultiRegionEndpointTypes.Details Create()
    {
        var detailsResult = CreateDetails();
        factoryAction?.Invoke(detailsResult);

        return detailsResult;
    }

    private Humidifier.SES.MultiRegionEndpointTypes.Details CreateDetails()
    {
        var detailsResult = new Humidifier.SES.MultiRegionEndpointTypes.Details();

        return detailsResult;
    }

} // End Of Class

public static class InnerMultiRegionEndpointDetailsFactoryExtensions
{
}
