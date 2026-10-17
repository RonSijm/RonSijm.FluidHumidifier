// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionMlflowPropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.MlflowPropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.MlflowPropertiesInput>
{

    protected override Humidifier.DataZone.ConnectionTypes.MlflowPropertiesInput Create()
    {
        var mlflowPropertiesInputResult = CreateMlflowPropertiesInput();
        factoryAction?.Invoke(mlflowPropertiesInputResult);

        return mlflowPropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.MlflowPropertiesInput CreateMlflowPropertiesInput()
    {
        var mlflowPropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.MlflowPropertiesInput();

        return mlflowPropertiesInputResult;
    }

} // End Of Class

public static class InnerConnectionMlflowPropertiesInputFactoryExtensions
{
}
