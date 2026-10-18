// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerDatasetKendraSourceDetailFactory(Action<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail>
{

    protected override Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail Create()
    {
        var kendraSourceDetailResult = CreateKendraSourceDetail();
        factoryAction?.Invoke(kendraSourceDetailResult);

        return kendraSourceDetailResult;
    }

    private Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail CreateKendraSourceDetail()
    {
        var kendraSourceDetailResult = new Humidifier.IoTSiteWise.DatasetTypes.KendraSourceDetail();

        return kendraSourceDetailResult;
    }

} // End Of Class

public static class InnerDatasetKendraSourceDetailFactoryExtensions
{
}
