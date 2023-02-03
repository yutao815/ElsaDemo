using ElsaDemo;
using System.Reflection.PortableExecutable;

var host = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
    webBuilder=> webBuilder.UseStartup<Startup>()
    ).Build();

host.Run();
