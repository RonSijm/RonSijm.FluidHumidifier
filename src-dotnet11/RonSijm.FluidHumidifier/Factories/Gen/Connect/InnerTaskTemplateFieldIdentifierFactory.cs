// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerTaskTemplateFieldIdentifierFactory(Action<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.Connect.TaskTemplateTypes.FieldIdentifier>
{

    protected override Humidifier.Connect.TaskTemplateTypes.FieldIdentifier Create()
    {
        var fieldIdentifierResult = CreateFieldIdentifier();
        factoryAction?.Invoke(fieldIdentifierResult);

        return fieldIdentifierResult;
    }

    private Humidifier.Connect.TaskTemplateTypes.FieldIdentifier CreateFieldIdentifier()
    {
        var fieldIdentifierResult = new Humidifier.Connect.TaskTemplateTypes.FieldIdentifier();

        return fieldIdentifierResult;
    }

} // End Of Class

public static class InnerTaskTemplateFieldIdentifierFactoryExtensions
{
}
