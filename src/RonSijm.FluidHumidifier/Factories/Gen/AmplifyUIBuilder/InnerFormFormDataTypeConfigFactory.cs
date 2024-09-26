// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerFormFormDataTypeConfigFactory(Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig>
{

    protected override Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig Create()
    {
        var formDataTypeConfigResult = CreateFormDataTypeConfig();
        factoryAction?.Invoke(formDataTypeConfigResult);

        return formDataTypeConfigResult;
    }

    private Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig CreateFormDataTypeConfig()
    {
        var formDataTypeConfigResult = new Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig();

        return formDataTypeConfigResult;
    }

} // End Of Class

public static class InnerFormFormDataTypeConfigFactoryExtensions
{
}
