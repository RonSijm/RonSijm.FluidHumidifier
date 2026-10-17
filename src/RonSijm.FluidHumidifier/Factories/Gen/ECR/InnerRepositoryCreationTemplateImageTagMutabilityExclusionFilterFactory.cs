// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRepositoryCreationTemplateImageTagMutabilityExclusionFilterFactory(Action<Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter>
{

    protected override Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter Create()
    {
        var imageTagMutabilityExclusionFilterResult = CreateImageTagMutabilityExclusionFilter();
        factoryAction?.Invoke(imageTagMutabilityExclusionFilterResult);

        return imageTagMutabilityExclusionFilterResult;
    }

    private Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter CreateImageTagMutabilityExclusionFilter()
    {
        var imageTagMutabilityExclusionFilterResult = new Humidifier.ECR.RepositoryCreationTemplateTypes.ImageTagMutabilityExclusionFilter();

        return imageTagMutabilityExclusionFilterResult;
    }

} // End Of Class

public static class InnerRepositoryCreationTemplateImageTagMutabilityExclusionFilterFactoryExtensions
{
}
