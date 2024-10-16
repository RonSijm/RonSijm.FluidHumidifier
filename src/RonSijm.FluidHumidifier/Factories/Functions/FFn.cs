using Humidifier.Base;
using Humidifier.Interfaces;

// ReSharper disable once CheckNamespace
namespace Humidifier
{
    public static class FFn
    {
        public static FFnARN FFnARN<T>(this IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFnARN(factory);

            return wrapper;
        }

        public static FFnGetAtt FFnGetARN<T>(this IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFnGetAtt(factory, "Arn");

            return wrapper;
        }

        public static FFnGetAtt FFnGetAtt<T>(this IResultFactory<T> factory, string attributeName) where T : BaseResource
        {
            var wrapper = new FFnGetAtt(factory, attributeName);

            return wrapper;
        }

        public static FFnREF FFnREF(this IResultFactory factory)
        {
            var wrapper = new FFnREF(factory);

            return wrapper;
        }

        public static FFnImportValue ImportValue(this IResultFactory factory)
        {
            var wrapper = new FFnImportValue(factory);
            return wrapper;
        }


        public static FFnREF FFnREF<T>(this IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFnREF(factory);

            return wrapper;
        }

        public static FFnName FFnName<T>(this IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFnName(factory);

            return wrapper;
        }

        public static FFnName FFnName(this IResultFactory factory)
        {
            var wrapper = new FFnName(factory);

            return wrapper;
        }

        public static FFnRawFunc FFnRawFunc(this IResultFactory factory, Func<string, string> stringFunction)
        {
            var wrapper = new FFnRawFunc(factory, stringFunction);

            return wrapper;
        }

        public static FFnTokenFunc FFnTokenFunc(this IResultFactory factory, Func<string, string> stringFunction)
        {
            var wrapper = new FFnTokenFunc(factory, stringFunction);

            return wrapper;
        }

        public static FFnSubNameFunc FFnSubNameFunc(this IResultFactory factory, Func<string, string> stringFunction, Dictionary<string, dynamic> variables = null)
        {
            var wrapper = new FFnSubNameFunc(factory, stringFunction, variables);

            return wrapper;
        }

        public static Lazy<string> Property<T>(this IResultFactory<T> factory, Func<IResultFactory<T>, string> stringFunction) where T : BaseResource
        {
            var result = new Lazy<string>(() => stringFunction.Invoke(factory));

            return result;
        }

        public static FFnName FFnName(this BaseResource resource)
        {
            var holder = new ResultHolder(resource);
            var wrapper = new FFnName(holder);

            return wrapper;
        }

        public static FnStringJoin FnStringJoin(params dynamic[] conditions)
        {
            var wrapper = new FnStringJoin(conditions);

            return wrapper;
        }

        public static FFnREFList FFnREFList<T>(this List<ResourceFactory<T>> factories) where T : BaseResource
        {
            var untyped = factories.Cast<IResultFactory>().ToList();
            var wrapper = new FFnREFList(untyped);

            return wrapper;
        }

        public static FFnREFList FFnREFList(this IResultFactory factory)
        {
            var wrapper = new FFnREFList([factory]);

            return wrapper;
        }

        public static FFnREFList FFnREFList(this List<IResultFactory> factories)
        {
            var wrapper = new FFnREFList(factories);

            return wrapper;
        }

        public static FFNamedList FFNamedList<T>(this IResultFactory<T> factory) where T : BaseResource
        {
            var wrapper = new FFNamedList([factory]);

            return wrapper;
        }

        public static FFNamedList FFNamedList(params IResultFactory[] factory)
        {
            var wrapper = new FFNamedList(factory.ToList());

            return wrapper;
        }

        public static FFNamedList FFNamedList<T>(this List<IResultFactory<T>> factories) where T : BaseResource
        {
            var untyped = factories.Cast<IResultFactory>().ToList();
            var wrapper = new FFNamedList(untyped);

            return wrapper;
        }

        public static FFNamedList FFNamedList(this List<IResultFactory> factories)
        {
            var wrapper = new FFNamedList(factories);

            return wrapper;
        }
    }
}