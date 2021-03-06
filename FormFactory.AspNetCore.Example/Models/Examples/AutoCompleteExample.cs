using System.Collections.Generic;
using FormFactory.Attributes;

namespace FormFactory.Example.Models.Examples
{
    public class AutoCompleteExample
    {

        [Required]
        [Display(Prompt="Type to find your location")]
        public string Location { get; set; }
        public IEnumerable<string> Location_suggestions()
        {
            return new[] {"Europe", "Asia"};
        }

        [Required]
        [Display(Name="What country are you in?", Prompt="Type to find your location")]
        [Description("AJAX suggestions using [SuggestionsUrl(\"...someurl...\")]")]
        [SuggestionsUrl("/home/CountrySuggestions")]
        public string CountryViaAjax { get; set; }
    }
}