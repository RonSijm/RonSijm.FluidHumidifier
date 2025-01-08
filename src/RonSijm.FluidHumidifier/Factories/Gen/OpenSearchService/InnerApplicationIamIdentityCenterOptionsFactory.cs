// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerApplicationIamIdentityCenterOptionsFactory(Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions>
{

    protected override Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions Create()
    {
        var iamIdentityCenterOptionsResult = CreateIamIdentityCenterOptions();
        factoryAction?.Invoke(iamIdentityCenterOptionsResult);

        return iamIdentityCenterOptionsResult;
    }

    private Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions CreateIamIdentityCenterOptions()
    {
        var iamIdentityCenterOptionsResult = new Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions();

        return iamIdentityCenterOptionsResult;
    }

} // End Of Class

public static class InnerApplicationIamIdentityCenterOptionsFactoryExtensions
{
}
