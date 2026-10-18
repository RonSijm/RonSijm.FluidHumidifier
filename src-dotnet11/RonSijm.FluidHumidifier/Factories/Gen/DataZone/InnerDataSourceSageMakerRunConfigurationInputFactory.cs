// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceSageMakerRunConfigurationInputFactory(Action<Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput>
{

    protected override Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput Create()
    {
        var sageMakerRunConfigurationInputResult = CreateSageMakerRunConfigurationInput();
        factoryAction?.Invoke(sageMakerRunConfigurationInputResult);

        return sageMakerRunConfigurationInputResult;
    }

    private Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput CreateSageMakerRunConfigurationInput()
    {
        var sageMakerRunConfigurationInputResult = new Humidifier.DataZone.DataSourceTypes.SageMakerRunConfigurationInput();

        return sageMakerRunConfigurationInputResult;
    }

} // End Of Class

public static class InnerDataSourceSageMakerRunConfigurationInputFactoryExtensions
{
}
