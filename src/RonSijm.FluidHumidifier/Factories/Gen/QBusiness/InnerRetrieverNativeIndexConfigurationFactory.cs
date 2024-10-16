// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerRetrieverNativeIndexConfigurationFactory(Action<Humidifier.QBusiness.RetrieverTypes.NativeIndexConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.RetrieverTypes.NativeIndexConfiguration>
{

    protected override Humidifier.QBusiness.RetrieverTypes.NativeIndexConfiguration Create()
    {
        var nativeIndexConfigurationResult = CreateNativeIndexConfiguration();
        factoryAction?.Invoke(nativeIndexConfigurationResult);

        return nativeIndexConfigurationResult;
    }

    private Humidifier.QBusiness.RetrieverTypes.NativeIndexConfiguration CreateNativeIndexConfiguration()
    {
        var nativeIndexConfigurationResult = new Humidifier.QBusiness.RetrieverTypes.NativeIndexConfiguration();

        return nativeIndexConfigurationResult;
    }

} // End Of Class

public static class InnerRetrieverNativeIndexConfigurationFactoryExtensions
{
}
