using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Threading;

namespace ViewModell
{

    // Implementación del ViewModel
    public class MainViewModel : INotifyPropertyChanged
    {
        private Persona personaSeleccionada;
        public ObservableCollection<Persona> listaPersonas { get; set; }

        // Evento PropertyChanged requerido por INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        private bool isButtonEnabled;
        private double progressValue;
        private DispatcherTimer timer;
        private int timeRemaining;

        // Propiedad que se actualiza y dispara el evento
        public Persona PersonaSeleccionada
        {
            get => personaSeleccionada;
            set
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                    OnPropertyChanged(nameof(personaSeleccionada));
                }
            }
        }

        public double ProgressValue
        {
            get => progressValue;
            set
            {
                progressValue = value;
                OnPropertyChanged();
                

                
            }
        }
        // Método para disparar el evento PropertyChanged
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void agregarPersona(string nombre, int edad)
        {

            Persona p = new Persona(nombre,edad);
            listaPersonas.Add(p);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            if (timeRemaining <= 0)
            {
                timer.Stop();
                isButtonEnabled = false;
                ProgressValue = 0;
            }
            else
            {
                ProgressValue = (timeRemaining / 60.0) * 100;
            }
        }
        private void StartTimer()
        {
            timeRemaining = 60;
            progressValue = 100;
            isButtonEnabled= true;
            timer.Start();
        }

        public MainViewModel()
        {
            listaPersonas = new ObservableCollection<Persona>();
            progressValue = 0;
            timer = new DispatcherTimer();
            timeRemaining = 60;

            timer.Interval=TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            StartTimer();
         
        }

        
    }
}
