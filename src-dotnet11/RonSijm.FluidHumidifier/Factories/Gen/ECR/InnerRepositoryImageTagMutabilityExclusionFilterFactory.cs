// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRepositoryImageTagMutabilityExclusionFilterFactory(Action<Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter>
{

    protected override Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter Create()
    {
        var imageTagMutabilityExclusionFilterResult = CreateImageTagMutabilityExclusionFilter();
        factoryAction?.Invoke(imageTagMutabilityExclusionFilterResult);

        return imageTagMutabilityExclusionFilterResult;
    }

    private Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter CreateImageTagMutabilityExclusionFilter()
    {
        var imageTagMutabilityExclusionFilterResult = new Humidifier.ECR.RepositoryTypes.ImageTagMutabilityExclusionFilter();

        return imageTagMutabilityExclusionFilterResult;
    }

} // End Of Class

public static class InnerRepositoryImageTagMutabilityExclusionFilterFactoryExtensions
{
}
