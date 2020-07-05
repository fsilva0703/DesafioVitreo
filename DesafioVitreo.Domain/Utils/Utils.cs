using DesafioVitreo.Domain.Interface.Utils;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Security.Cryptography;
using System.Text;

namespace DesafioVitreo.Domain.Utils
{
    public class Utils : IUtils
    {
        private MemoryCacheEntryOptions _cacheEntryOptions;
        private readonly IMemoryCache _cache;

        private static string ts = "1";
        private static string publicKey = "cdb7af1ef4a3c260a36fc5c2ee256748";
        private static string privateKey = "e316821073aa7526a8ed41a7a8ae72c03d3fc86a";


        public Utils()
        {
            _cache = new MemoryCache(new MemoryCacheOptions(){});

            _cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSize(1)
                .SetAbsoluteExpiration(new TimeSpan(0, 10, 0));
        }
        public string GerarHash()
        {
            try
            {
                string apicache = null;

                string key = $"Hash_{ts}_{publicKey}_{privateKey}";

                if (!_cache.TryGetValue(key, out apicache))
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
                    var gerador = MD5.Create();
                    byte[] bytesHash = gerador.ComputeHash(bytes);

                    apicache = BitConverter.ToString(bytesHash).ToLower().Replace("-", String.Empty);

                    _cache.Set(key, apicache, _cacheEntryOptions);
                }

                return "ts=" + ts + "&apikey=" + publicKey + "&hash=" + apicache;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
