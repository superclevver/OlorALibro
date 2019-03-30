using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.IO;

namespace OlorALibro
{
    public static class Metodos
    {

        public static BindingList<Actividad> actividad = new BindingList<Actividad>();
        public static BindingList<Libreria> libreri = new BindingList<Libreria>();
        public static DatosRed red = new DatosRed();
        public static BindingList<Usuario> usuario = new BindingList<Usuario>();

        //--------------------GUARDAR JSONS--------------------//
        //-----------------------------------------------------//
        public static void guardarActividades()
        {
            JArray JArrayActividad = (JArray)JToken.FromObject(actividad); // agafem la llista i desde el objecte (fromObject) crea el JToken i el pasa a JArray
            StreamWriter fitxer = File.CreateText("..\\..\\Json\\actividades.json"); // agafa el fitxer i el "converteix" amb json || @ per que sapiga que es una ruta
            JsonTextWriter jsonWriter = new JsonTextWriter(fitxer); // escriu en el fitxer que hem creat abans 

            JArrayActividad.WriteTo(jsonWriter); // guarda lo del array al jsonWriter            
            jsonWriter.Close();
        }
        public static void guardarLibrerias()
        {
            JArray JArrayLibrerias = (JArray)JToken.FromObject(libreri);
            StreamWriter fitxer = File.CreateText(@"..\..\\Json\\librerias.json");
            JsonTextWriter jsonWriter = new JsonTextWriter(fitxer); 

            JArrayLibrerias.WriteTo(jsonWriter);
            jsonWriter.Close();
        }
        public static void guardarDatosDeRed()
        {
            JObject JArrayDatosDeRed = (JObject)JToken.FromObject(Metodos.red);
            StreamWriter fitxer = File.CreateText(@"..\..\\Json\\datos_de_red.json");
            JsonTextWriter jsonWriter = new JsonTextWriter(fitxer);

            JArrayDatosDeRed.WriteTo(jsonWriter);           
            jsonWriter.Close();
        }
        public static void guardarUsuarios()
        {
            JArray JArrayUsuarios = (JArray)JToken.FromObject(Metodos.usuario); // agafem la llista i desde el objecte (fromObject) crea el JToken i el pasa a JArray
            StreamWriter fitxer = File.CreateText(@"..\..\\Json\\usuarios.json"); // agafa el fitxer i el "converteix" amb json || @ per que sapiga que es una ruta
            JsonTextWriter jsonWriter = new JsonTextWriter(fitxer); // escriu en el fitxer que hem creat abans 

            JArrayUsuarios.WriteTo(jsonWriter); // guarda lo del array al jsonWriter
            jsonWriter.Close();
        }

        //--------------------LEER JSON--------------------//
        //------------------------------------------------//
        public static void leerActividades()
        {
            if (File.Exists(@"..\..\\Json\\actividades.json")) // si existeix el sobrescribim
            {
                JArray JArrayActividad = JArray.Parse(File.ReadAllText(@"..\..\\Json\\actividades.json")); // Llegeix el fitxer
                Metodos.actividad = JArrayActividad.ToObject<BindingList<Actividad>>(); // agafem el fitxer i el converteix en llista 

            }
            else       // sino existeix el crea
            {
                Metodos.actividad = new BindingList<Actividad>();
            }
        }
        public static void leerLibrerias()
        {
            if (File.Exists(@"..\..\\Json\\librerias.json")) 
            {
                JArray JArrayLibrerias = JArray.Parse(File.ReadAllText(@"..\..\\Json\\librerias.json"));
                Metodos.libreri = JArrayLibrerias.ToObject<BindingList<Libreria>>(); 
            }
            else 
            {
                Metodos.libreri = new BindingList<Libreria>();
            }
        }   
        public static void leerDatosDeRed()
        {
            if (File.Exists(@"..\..\\Json\\datos_de_red.json"))
            {
                JObject JArrayDatosDeRed = JObject.Parse(File.ReadAllText(@"..\..\\Json\\datos_de_red.json"));
                Metodos.red = JArrayDatosDeRed.ToObject<DatosRed>();
            }
            else
            {
                Metodos.red = new DatosRed();
            }
        }
        public static void leerUsuarios()
        {
            if (File.Exists(@"..\..\\Json\\usuarios.json")) // si existeix el sobrescribim
            {
                JArray JArrayUsuarios = JArray.Parse(File.ReadAllText(@"..\..\\Json\\usuarios.json")); // Llegeix el fitxer
                Metodos.usuario = JArrayUsuarios.ToObject<BindingList<Usuario>>(); // agafem el fitxer i el converteix en llista 

            }
            else       // sino existeix el crea
            {
                Metodos.usuario = new BindingList<Usuario>();
            }
        }
        
    }
}
