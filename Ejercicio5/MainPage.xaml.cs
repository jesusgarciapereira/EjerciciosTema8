using Ejercicio5.Models.DAL;
using Ejercicio5.Models.ENTIDADES;
using System.Collections.ObjectModel;

namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {

        // Declaración de una ObservableCollection para almacenar objetos de tipo clsPersona
        ObservableCollection<clsPersona> coleccionPersonas = new ObservableCollection<clsPersona>();

        // Propiedad pública para acceder a la colección de personas
        public ObservableCollection<clsPersona> per { get { return coleccionPersonas; } }

        public MainPage()
        {
            // Inicializa los componentes de la página
            InitializeComponent();

            // Creamos un listado de personas 
            List<clsPersona> listado = new List<clsPersona>();

            // Inicializamos el listado con la funcion de la clase listados
            listado = ListadoPersonas.ObtenerListaPersonas();

            // Recorremos el listado de personas
            foreach (clsPersona persona in listado)
            {
                // Añadimos cada objeto persona al ObservableCollection
                coleccionPersonas.Add(persona);
            }

            // Asignamos la ObservableCollection como la fuente de datos del ListView
            ListadoPersona.ItemsSource = coleccionPersonas;
        }



    }

}