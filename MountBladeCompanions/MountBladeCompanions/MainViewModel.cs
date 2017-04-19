using MountBladeCompanions.Data;
using MountBladeCompanions.Operators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountBladeCompanions
{
    class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Relationship> Relationships { get; set; }

        private readonly Analyzer _analyzer;

        public MainViewModel()
        {
            var init = new Initializer();
            Relationships = new ObservableCollection<Relationship>(init.GetInitialData());

            _analyzer = new Analyzer(Relationships);


        }
    }
}
