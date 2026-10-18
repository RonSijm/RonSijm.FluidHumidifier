// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class DataLakeAssociationFactory(string resourceName = null, Action<Humidifier.Connect.DataLakeAssociation> factoryAction = null) : ResourceFactory<Humidifier.Connect.DataLakeAssociation>(resourceName)
{

    protected override Humidifier.Connect.DataLakeAssociation Create()
    {
        var dataLakeAssociationResult = CreateDataLakeAssociation();
        factoryAction?.Invoke(dataLakeAssociationResult);

        return dataLakeAssociationResult;
    }

    private Humidifier.Connect.DataLakeAssociation CreateDataLakeAssociation()
    {
        var dataLakeAssociationResult = new Humidifier.Connect.DataLakeAssociation
        {
            GivenName = InputResourceName,
        };

        return dataLakeAssociationResult;
    }

} // End Of Class

public static class DataLakeAssociationFactoryExtensions
{
}
