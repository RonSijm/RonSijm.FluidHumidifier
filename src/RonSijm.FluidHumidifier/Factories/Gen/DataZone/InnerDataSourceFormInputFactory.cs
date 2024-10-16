// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceFormInputFactory(Action<Humidifier.DataZone.DataSourceTypes.FormInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.FormInput>
{

    protected override Humidifier.DataZone.DataSourceTypes.FormInput Create()
    {
        var formInputResult = CreateFormInput();
        factoryAction?.Invoke(formInputResult);

        return formInputResult;
    }

    private Humidifier.DataZone.DataSourceTypes.FormInput CreateFormInput()
    {
        var formInputResult = new Humidifier.DataZone.DataSourceTypes.FormInput();

        return formInputResult;
    }

} // End Of Class

public static class InnerDataSourceFormInputFactoryExtensions
{
}
