using Microsoft.Extensions.Localization;
using MudBlazor;

namespace HomePage.wwwroot.Services;

public class DictionaryMudLocalizer : MudLocalizer
{
    private Dictionary<string, string> _localization;

    public DictionaryMudLocalizer()
    {
        _localization = new()
        {
            { "MudDataGrid.IsEmpty", "ist leer" },
            { "MudDataGrid.IsNotEmpty", "ist nicht leer" },
            { "MudDataGrid.Contains", "enthält" },
            { "MudDataGrid.NotContains", "enthält nicht" },
        };
    }
    
    public override LocalizedString this[string key]
    {
        get
        {
            var currentCulture = Thread.CurrentThread.CurrentUICulture.Parent.TwoLetterISOLanguageName;
            
            if (currentCulture.Equals("de", StringComparison.InvariantCultureIgnoreCase)
                && _localization.TryGetValue(key, out var res))
            {
                return new(key, res);
            }
            else
            {
                return new(key, key, true);
            }
        }
    }
}