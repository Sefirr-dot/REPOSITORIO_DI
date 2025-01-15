using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace AppAdivinarNumero
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string bombaImageSource;
        private double progressValue;
        private DispatcherTimer timer;
        private int timeRemaining;
        private bool isFacilEnabled;
        private bool isDificilEnabled;
        private bool isAdivinarEnabled;

        public string BombaImageSource
        {
            get => bombaImageSource;
            set
            {
                if (bombaImageSource != value)
                {
                    bombaImageSource = value;
                    OnPropertyChanged(nameof(BombaImageSource));
                }
            }
        }

        public double ProgressValue
        {
            get => progressValue;
            set
            {
                if (progressValue != value)
                {
                    progressValue = value;
                    OnPropertyChanged(nameof(ProgressValue));
                }
            }
        }

        public bool IsFacilEnabled
        {
            get => isFacilEnabled;
            set
            {
                if (isFacilEnabled != value)
                {
                    isFacilEnabled = value;
                    OnPropertyChanged(nameof(IsFacilEnabled));
                }
            }
        }

        public bool IsDificilEnabled
        {
            get => isDificilEnabled;
            set
            {
                if (isDificilEnabled != value)
                {
                    isDificilEnabled = value;
                    OnPropertyChanged(nameof(IsDificilEnabled));
                }
            }
        }

        public bool IsAdivinarEnabled
        {
            get => isAdivinarEnabled;
            set
            {
                if (isAdivinarEnabled != value)
                {
                    isAdivinarEnabled = value;
                    OnPropertyChanged(nameof(IsAdivinarEnabled));
                }
            }
        }

        public MainViewModel()
        {
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;

            ResetGame();
        }

        public void StartFacil()
        {
            ResetGame();
            IsFacilEnabled = false;
            IsDificilEnabled = false;
            IsAdivinarEnabled = true;
            ProgressValue = 100; // En modo fácil, la barra se llena y no cambia.
            BombaImageSource = "/bomba.jpg"; // Imagen inicial.
        }

        public void StartDificil()
        {
            ResetGame();
            IsFacilEnabled = false;
            IsDificilEnabled = false;
            IsAdivinarEnabled = true;

            timeRemaining = 60;
            ProgressValue = 100; // Inicia la barra al 100%.
            BombaImageSource = "/bomba.jpg"; // Imagen inicial.
            timer.Start();
        }

        public void ResetGame()
        {
            timer.Stop();
            ProgressValue = 100;
            BombaImageSource = "/bomba.jpg"; // Imagen inicial.
            IsFacilEnabled = true;
            IsDificilEnabled = true;
            IsAdivinarEnabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeRemaining--;

            if (timeRemaining <= 0)
            {
                ResetGame() ;
                timer.Stop();
                ProgressValue = 0;
                BombaImageSource = "/bomba_explosion.jpg"; // Cambia a la imagen de explosión.
                IsAdivinarEnabled = false; // Deshabilita el botón Adivinar.
            }
            else
            {
                
                ProgressValue = (timeRemaining / 60.0) * 100; // Actualiza el progreso proporcionalmente.
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
