using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Xamarin.Forms;

public class ConfigurationService
{
    public IConfiguration Configuration { get; private set; }

    public ConfigurationService()
    {
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json",
                         optional: true,
                         reloadOnChange: true)
            .Build();
    }
}