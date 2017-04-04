#if NETFX_CORE
using System.Threading.Tasks;
#endif

namespace Plugin
{
    public class Plugin
    {
        public static string SayHello()
        {
#if NETFX_CORE
            var task = Plugin.GetString();
            task.Wait();
            return task.Result;
#else
            return "Hello";
#endif
        }

#if NETFX_CORE
        private static async Task<string> GetString()
        {
            await Task.Delay(100);
            return "Hello";
        }
#endif
    }
}
