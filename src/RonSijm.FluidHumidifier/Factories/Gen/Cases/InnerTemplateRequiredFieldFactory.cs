// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerTemplateRequiredFieldFactory(Action<Humidifier.Cases.TemplateTypes.RequiredField> factoryAction = null) : SubResourceFactory<Humidifier.Cases.TemplateTypes.RequiredField>
{

    protected override Humidifier.Cases.TemplateTypes.RequiredField Create()
    {
        var requiredFieldResult = CreateRequiredField();
        factoryAction?.Invoke(requiredFieldResult);

        return requiredFieldResult;
    }

    private Humidifier.Cases.TemplateTypes.RequiredField CreateRequiredField()
    {
        var requiredFieldResult = new Humidifier.Cases.TemplateTypes.RequiredField();

        return requiredFieldResult;
    }

} // End Of Class

public static class InnerTemplateRequiredFieldFactoryExtensions
{
}
