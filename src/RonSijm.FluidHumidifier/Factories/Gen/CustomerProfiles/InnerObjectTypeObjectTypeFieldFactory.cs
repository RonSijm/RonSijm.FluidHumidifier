// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerObjectTypeObjectTypeFieldFactory(Action<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField>
{

    protected override Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField Create()
    {
        var objectTypeFieldResult = CreateObjectTypeField();
        factoryAction?.Invoke(objectTypeFieldResult);

        return objectTypeFieldResult;
    }

    private Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField CreateObjectTypeField()
    {
        var objectTypeFieldResult = new Humidifier.CustomerProfiles.ObjectTypeTypes.ObjectTypeField();

        return objectTypeFieldResult;
    }

} // End Of Class

public static class InnerObjectTypeObjectTypeFieldFactoryExtensions
{
}
