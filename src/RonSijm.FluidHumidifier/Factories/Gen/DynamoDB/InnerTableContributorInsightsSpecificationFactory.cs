// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableContributorInsightsSpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification>
{

    protected override Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification Create()
    {
        var contributorInsightsSpecificationResult = CreateContributorInsightsSpecification();
        factoryAction?.Invoke(contributorInsightsSpecificationResult);

        return contributorInsightsSpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification CreateContributorInsightsSpecification()
    {
        var contributorInsightsSpecificationResult = new Humidifier.DynamoDB.TableTypes.ContributorInsightsSpecification();

        return contributorInsightsSpecificationResult;
    }

} // End Of Class

public static class InnerTableContributorInsightsSpecificationFactoryExtensions
{
}
