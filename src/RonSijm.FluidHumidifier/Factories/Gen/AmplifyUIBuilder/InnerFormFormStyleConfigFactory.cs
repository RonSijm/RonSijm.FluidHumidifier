// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerFormFormStyleConfigFactory(Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig>
{

    protected override Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig Create()
    {
        var formStyleConfigResult = CreateFormStyleConfig();
        factoryAction?.Invoke(formStyleConfigResult);

        return formStyleConfigResult;
    }

    private Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig CreateFormStyleConfig()
    {
        var formStyleConfigResult = new Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig();

        return formStyleConfigResult;
    }

} // End Of Class

public static class InnerFormFormStyleConfigFactoryExtensions
{
}
