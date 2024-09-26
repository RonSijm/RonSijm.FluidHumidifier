// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT1Click;

public class InnerProjectPlacementTemplateFactory(Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> factoryAction = null) : SubResourceFactory<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate>
{

    protected override Humidifier.IoT1Click.ProjectTypes.PlacementTemplate Create()
    {
        var placementTemplateResult = CreatePlacementTemplate();
        factoryAction?.Invoke(placementTemplateResult);

        return placementTemplateResult;
    }

    private Humidifier.IoT1Click.ProjectTypes.PlacementTemplate CreatePlacementTemplate()
    {
        var placementTemplateResult = new Humidifier.IoT1Click.ProjectTypes.PlacementTemplate();

        return placementTemplateResult;
    }

} // End Of Class

public static class InnerProjectPlacementTemplateFactoryExtensions
{
}
