// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableGlueTableReferenceFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference Create()
    {
        var glueTableReferenceResult = CreateGlueTableReference();
        factoryAction?.Invoke(glueTableReferenceResult);

        return glueTableReferenceResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference CreateGlueTableReference()
    {
        var glueTableReferenceResult = new Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference();

        return glueTableReferenceResult;
    }

} // End Of Class

public static class InnerConfiguredTableGlueTableReferenceFactoryExtensions
{
}
