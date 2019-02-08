using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SearchBarDemo.ViewModels
{
    public class MainViewModels
    {

       List<string> Country = new List<string>
        {
            "India",
            "pakistan",
            "Srilanka",
            "Bangladesh",
            "Afghanistan"
        };

        private List<string> countryList;

        public List<string> CountryList
        {
            get { return countryList; }
            set { countryList = value; }
        }


        private bool isVisible;

        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        private string searchContent;

        public string SearchContent
        {
            get { return searchContent; }
            set { searchContent = value; }
        }



        private ICommand _searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                return _searchCommand ?? (_searchCommand = new Command<string>((text) =>
                {
                    var keyword = text;
                    if (keyword.Length >= 1)
                    {
                        CountryList = Country.Where(c => c.ToLower().Contains(keyword.ToLower())).ToList();
                        IsVisible = true;
                    }
                    else
                    {
                        IsVisible = false;
                    }
                    // The text parameter can now be used for searching.
                }));
            }
        }
    }
}
