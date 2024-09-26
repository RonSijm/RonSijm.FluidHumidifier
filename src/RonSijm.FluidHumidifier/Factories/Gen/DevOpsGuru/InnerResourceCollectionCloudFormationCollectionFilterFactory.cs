// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class InnerResourceCollectionCloudFormationCollectionFilterFactory(Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter>
{

    protected override Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter Create()
    {
        var cloudFormationCollectionFilterResult = CreateCloudFormationCollectionFilter();
        factoryAction?.Invoke(cloudFormationCollectionFilterResult);

        return cloudFormationCollectionFilterResult;
    }

    private Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter CreateCloudFormationCollectionFilter()
    {
        var cloudFormationCollectionFilterResult = new Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter();

        return cloudFormationCollectionFilterResult;
    }

} // End Of Class

public static class InnerResourceCollectionCloudFormationCollectionFilterFactoryExtensions
{
}
