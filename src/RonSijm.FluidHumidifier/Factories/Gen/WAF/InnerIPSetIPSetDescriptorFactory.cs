// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerIPSetIPSetDescriptorFactory(Action<Humidifier.WAF.IPSetTypes.IPSetDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.WAF.IPSetTypes.IPSetDescriptor>
{

    protected override Humidifier.WAF.IPSetTypes.IPSetDescriptor Create()
    {
        var iPSetDescriptorResult = CreateIPSetDescriptor();
        factoryAction?.Invoke(iPSetDescriptorResult);

        return iPSetDescriptorResult;
    }

    private Humidifier.WAF.IPSetTypes.IPSetDescriptor CreateIPSetDescriptor()
    {
        var iPSetDescriptorResult = new Humidifier.WAF.IPSetTypes.IPSetDescriptor();

        return iPSetDescriptorResult;
    }

} // End Of Class

public static class InnerIPSetIPSetDescriptorFactoryExtensions
{
}
