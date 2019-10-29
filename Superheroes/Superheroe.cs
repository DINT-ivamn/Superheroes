using System.ComponentModel;

namespace Superheroes
{
    class Superheroe : INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }
        private string enemigo;
        public string Enemigo
        {
            get => enemigo;
            set
            {
                enemigo = value;
                NotifyPropertyChanged("Enemigo");
            }
        }
        private string foto;
        public string Foto
        {
            get => foto;
            set
            {
                foto = value;
                NotifyPropertyChanged("Foto");
            }
        }
        private bool vengador;
        public bool Vengador
        {
            get => vengador;
            set
            {
                vengador = value;
                NotifyPropertyChanged("Vengador");
            }
        }


        public Superheroe()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static Superheroe GetSample()
        {
            Superheroe heroe = new Superheroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }
    }

}