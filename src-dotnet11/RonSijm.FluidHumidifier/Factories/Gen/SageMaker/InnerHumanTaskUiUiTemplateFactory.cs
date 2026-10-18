// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHumanTaskUiUiTemplateFactory(Action<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate>
{

    protected override Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate Create()
    {
        var uiTemplateResult = CreateUiTemplate();
        factoryAction?.Invoke(uiTemplateResult);

        return uiTemplateResult;
    }

    private Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate CreateUiTemplate()
    {
        var uiTemplateResult = new Humidifier.SageMaker.HumanTaskUiTypes.UiTemplate();

        return uiTemplateResult;
    }

} // End Of Class

public static class InnerHumanTaskUiUiTemplateFactoryExtensions
{
}
