// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerFormFieldPositionFactory(Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition>
{

    protected override Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition Create()
    {
        var fieldPositionResult = CreateFieldPosition();
        factoryAction?.Invoke(fieldPositionResult);

        return fieldPositionResult;
    }

    private Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition CreateFieldPosition()
    {
        var fieldPositionResult = new Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition();

        return fieldPositionResult;
    }

} // End Of Class

public static class InnerFormFieldPositionFactoryExtensions
{
}
