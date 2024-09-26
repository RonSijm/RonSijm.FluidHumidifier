// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableContributorInsightsSpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification Create()
    {
        var contributorInsightsSpecificationResult = CreateContributorInsightsSpecification();
        factoryAction?.Invoke(contributorInsightsSpecificationResult);

        return contributorInsightsSpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification CreateContributorInsightsSpecification()
    {
        var contributorInsightsSpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.ContributorInsightsSpecification();

        return contributorInsightsSpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTableContributorInsightsSpecificationFactoryExtensions
{
}
