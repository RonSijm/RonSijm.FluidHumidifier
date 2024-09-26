// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeArtifact;

public class InnerPackageGroupRestrictionTypeFactory(Action<Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType> factoryAction = null) : SubResourceFactory<Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType>
{

    protected override Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType Create()
    {
        var restrictionTypeResult = CreateRestrictionType();
        factoryAction?.Invoke(restrictionTypeResult);

        return restrictionTypeResult;
    }

    private Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType CreateRestrictionType()
    {
        var restrictionTypeResult = new Humidifier.CodeArtifact.PackageGroupTypes.RestrictionType();

        return restrictionTypeResult;
    }

} // End Of Class

public static class InnerPackageGroupRestrictionTypeFactoryExtensions
{
}
