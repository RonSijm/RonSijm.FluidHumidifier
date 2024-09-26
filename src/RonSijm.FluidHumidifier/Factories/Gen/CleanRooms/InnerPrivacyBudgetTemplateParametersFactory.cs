// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerPrivacyBudgetTemplateParametersFactory(Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters>
{

    protected override Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters Create()
    {
        var parametersResult = CreateParameters();
        factoryAction?.Invoke(parametersResult);

        return parametersResult;
    }

    private Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters CreateParameters()
    {
        var parametersResult = new Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters();

        return parametersResult;
    }

} // End Of Class

public static class InnerPrivacyBudgetTemplateParametersFactoryExtensions
{
}
