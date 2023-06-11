using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfExercise 
{
    public class Sum : INotifyPropertyChanged
    {
        private string num1;
        private string result;
        private string num2;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Num1
        {
            get { return num1; } 
            set {
                int number;
                bool isNum = int.TryParse(value, out number);
                if (isNum) num1 = value;
                onPropertyChanged("Num1");
                onPropertyChanged("Result");
            }
        }
        public string Num2
        {
            get { return num2; }
            set
            {
                int number;
                bool isNum = int.TryParse(value, out number);
                if (isNum) num2 = value;
                onPropertyChanged("Num1");
                onPropertyChanged("Result");
            }
        }

        public string Result
        {
            get { int res =int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                result = res.ToString();
                onPropertyChanged("Result");
            }
        }

        private void onPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
