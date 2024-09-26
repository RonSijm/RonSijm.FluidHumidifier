// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerIPSetIPSetDescriptorFactory(Action<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor>
{

    protected override Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor Create()
    {
        var iPSetDescriptorResult = CreateIPSetDescriptor();
        factoryAction?.Invoke(iPSetDescriptorResult);

        return iPSetDescriptorResult;
    }

    private Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor CreateIPSetDescriptor()
    {
        var iPSetDescriptorResult = new Humidifier.WAFRegional.IPSetTypes.IPSetDescriptor();

        return iPSetDescriptorResult;
    }

} // End Of Class

public static class InnerIPSetIPSetDescriptorFactoryExtensions
{
}
