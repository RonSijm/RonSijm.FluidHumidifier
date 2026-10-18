// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerUserPhotosItemsFactory(Action<Humidifier.IdentityStore.UserTypes.PhotosItems> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.UserTypes.PhotosItems>
{

    protected override Humidifier.IdentityStore.UserTypes.PhotosItems Create()
    {
        var photosItemsResult = CreatePhotosItems();
        factoryAction?.Invoke(photosItemsResult);

        return photosItemsResult;
    }

    private Humidifier.IdentityStore.UserTypes.PhotosItems CreatePhotosItems()
    {
        var photosItemsResult = new Humidifier.IdentityStore.UserTypes.PhotosItems();

        return photosItemsResult;
    }

} // End Of Class

public static class InnerUserPhotosItemsFactoryExtensions
{
}
