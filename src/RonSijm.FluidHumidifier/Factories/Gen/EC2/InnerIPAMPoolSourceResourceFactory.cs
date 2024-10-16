// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMPoolSourceResourceFactory(Action<Humidifier.EC2.IPAMPoolTypes.SourceResource> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMPoolTypes.SourceResource>
{

    protected override Humidifier.EC2.IPAMPoolTypes.SourceResource Create()
    {
        var sourceResourceResult = CreateSourceResource();
        factoryAction?.Invoke(sourceResourceResult);

        return sourceResourceResult;
    }

    private Humidifier.EC2.IPAMPoolTypes.SourceResource CreateSourceResource()
    {
        var sourceResourceResult = new Humidifier.EC2.IPAMPoolTypes.SourceResource();

        return sourceResourceResult;
    }

} // End Of Class

public static class InnerIPAMPoolSourceResourceFactoryExtensions
{
}
