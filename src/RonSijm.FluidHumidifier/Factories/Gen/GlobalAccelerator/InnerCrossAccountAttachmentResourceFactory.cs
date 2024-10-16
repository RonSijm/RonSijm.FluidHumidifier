// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class InnerCrossAccountAttachmentResourceFactory(Action<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource> factoryAction = null) : SubResourceFactory<Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource>
{

    protected override Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource Create()
    {
        var resourceResult = CreateResource();
        factoryAction?.Invoke(resourceResult);

        return resourceResult;
    }

    private Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource CreateResource()
    {
        var resourceResult = new Humidifier.GlobalAccelerator.CrossAccountAttachmentTypes.Resource();

        return resourceResult;
    }

} // End Of Class

public static class InnerCrossAccountAttachmentResourceFactoryExtensions
{
}
