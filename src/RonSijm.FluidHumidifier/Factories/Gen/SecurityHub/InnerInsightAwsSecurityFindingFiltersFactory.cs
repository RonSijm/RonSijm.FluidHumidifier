// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerInsightAwsSecurityFindingFiltersFactory(Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters>
{

    protected override Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters Create()
    {
        var awsSecurityFindingFiltersResult = CreateAwsSecurityFindingFilters();
        factoryAction?.Invoke(awsSecurityFindingFiltersResult);

        return awsSecurityFindingFiltersResult;
    }

    private Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters CreateAwsSecurityFindingFilters()
    {
        var awsSecurityFindingFiltersResult = new Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters();

        return awsSecurityFindingFiltersResult;
    }

} // End Of Class

public static class InnerInsightAwsSecurityFindingFiltersFactoryExtensions
{
}
