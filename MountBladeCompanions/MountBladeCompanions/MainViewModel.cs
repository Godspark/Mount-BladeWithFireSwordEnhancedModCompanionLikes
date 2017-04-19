using MountBladeCompanions.CoreClasses;
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
    class MainViewModel : PropertyChangedBase
    {
        public ObservableCollection<Relationship> Relationships { get; set; }
        public ObservableCollection<Companion> AllCompanions { get; set; }

        private readonly Analyzer _analyzer;

        private string _outputText;

        public string OutputText
        {
            get { return _outputText; }
            set
            {
                _outputText = value;
                NotifyOnPropertyChanged(() => OutputText);
            }
        }


        public MainViewModel()
        {
            var init = new Initializer();
            Relationships = new ObservableCollection<Relationship>(init.GetInitialData());
            AllCompanions = new ObservableCollection<Companion>(init.GetAllCompanions());
            _analyzer = new Analyzer(Relationships, AllCompanions);


            foreach (var a in _analyzer.Analyze(new Companion("Sarabun")))
            {
                OutputText += a.Name + "\r\n";
            }

        }
    }
}
