using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace GitWpfApplication.Sources
{
    public class CalculatorVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand calcCommand;
        private bool canExecute;
        private int nombre1;
        private int nombre2;
        private int result;

        public CalculatorVM()
        {
            canExecute = true;
        }

        public ICommand CalcCommand
        {
            get
            {
                return calcCommand ?? (calcCommand = new CommandHandler(() => Multiplier(), canExecute));
            }
        }

        public int Nombre1 
        {
            get
            {
                return nombre1;
            } 
            set
            {
                if (nombre1 != value)
                {
                    nombre1 = value;
                    OnPropertychanged("Nombre1");
                }
            }
        }

        public int Nombre2 
        { 
            get
            {
                return nombre2;
            }

            set
            {
                if (nombre2 != value)
                {
                    nombre2 = value;
                    OnPropertychanged("Nombre2");
                }
            }
        }

        public int Result 
        { 
            get
            {
                return result;
            }

            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertychanged("Result");
                }
            }
        }

        public void Multiplier()
        {
            Result = nombre1 * nombre2;
        }

        protected void OnPropertychanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}
