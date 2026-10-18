// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProjectCfnTemplateProviderDetailFactory(Action<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail>
{

    protected override Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail Create()
    {
        var cfnTemplateProviderDetailResult = CreateCfnTemplateProviderDetail();
        factoryAction?.Invoke(cfnTemplateProviderDetailResult);

        return cfnTemplateProviderDetailResult;
    }

    private Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail CreateCfnTemplateProviderDetail()
    {
        var cfnTemplateProviderDetailResult = new Humidifier.SageMaker.ProjectTypes.CfnTemplateProviderDetail();

        return cfnTemplateProviderDetailResult;
    }

} // End Of Class

public static class InnerProjectCfnTemplateProviderDetailFactoryExtensions
{
}
