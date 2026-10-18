// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportAuthZ;

public class InnerSupportPermitResourceSetFactory(Action<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet> factoryAction = null) : SubResourceFactory<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet>
{

    protected override Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet Create()
    {
        var resourceSetResult = CreateResourceSet();
        factoryAction?.Invoke(resourceSetResult);

        return resourceSetResult;
    }

    private Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet CreateResourceSet()
    {
        var resourceSetResult = new Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet();

        return resourceSetResult;
    }

} // End Of Class

public static class InnerSupportPermitResourceSetFactoryExtensions
{
}
