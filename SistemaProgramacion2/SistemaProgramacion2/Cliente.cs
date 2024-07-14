using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProgramacion2
{
    public class Cliente
    {
        public int    id { get; set; } 
        public string nombre { get; set; }
        public string nit { get; set;}
        public string convertirEnTexto()
        {
            
            string line = "";
            line = line + this.id+","+this.nombre+","+this.nit;
            return line;
        }
        public static Cliente crearDesdeTexto(string line)
        {
            string[] valores = line.Split(',');
            int idCliente = 0;
            string nombreCliente = "";
            string nitCliente = "";
            Cliente c = new Cliente();
            try
            {
                if (valores.Length > 1)
                    idCliente = int.Parse(valores[0]);
                if (valores.Length > 2)
                    nombreCliente = valores[1];
                if (valores.Length >= 3)
                    nitCliente = valores[2];
            }
            catch (Exception ex)
            {

            }
            c.nit = nitCliente;
            c.id = idCliente;
            c.nombre = nombreCliente;

            return c;
        }
        public static void guardarClientes(List<Cliente> clientes, string fileName)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(fileName);
                
                foreach (Cliente cliente in clientes) {
                    string line = cliente.convertirEnTexto();
                    sw.WriteLine(line);  
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public static List<Cliente> leerClientes(string fileName)
        {
            String line;
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fileName);
             
                line = "";
                //Continue to read until you reach end of file
                while ( (line = sr.ReadLine()) != null)
                {
                    
                    //Read the next line
                    
                    Cliente c = Cliente.crearDesdeTexto(line);
                    clientes.Add(c);
                    //write the line to console window
                    Console.WriteLine(line);
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return clientes;
        }
    }
    
    
}
