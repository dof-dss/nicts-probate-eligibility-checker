using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace test_nidirect
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    webBuilder.ConfigureKestrel((context, options) =>
                    {
                        options.ConfigureHttpsDefaults(httpsOptions =>
                        {
                            httpsOptions.SslProtocols = System.Security.Authentication.SslProtocols.Tls12 | System.Security.Authentication.SslProtocols.Tls13;

                            if (!System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
                            {
                                httpsOptions.OnAuthenticate = (conContext, sslAuthOptions) =>
                                {
                                    sslAuthOptions.CipherSuitesPolicy = new System.Net.Security.CipherSuitesPolicy(
                                        new System.Net.Security.TlsCipherSuite[]
                                        {
											// Highly secure TLS 1.3 cipher suits:
											System.Net.Security.TlsCipherSuite.TLS_AES_128_GCM_SHA256,
                                            System.Net.Security.TlsCipherSuite.TLS_AES_256_GCM_SHA384,
                                            System.Net.Security.TlsCipherSuite.TLS_CHACHA20_POLY1305_SHA256,

											// Medium secure compatibility TLS 1.2 cipher suits:
											System.Net.Security.TlsCipherSuite.TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,
                                            System.Net.Security.TlsCipherSuite.TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,
                                            System.Net.Security.TlsCipherSuite.TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256,
                                            System.Net.Security.TlsCipherSuite.TLS_DHE_RSA_WITH_AES_128_GCM_SHA256,
                                        }
                                        );
                                };
                            }
                        });
                    });
                });
    }
}
