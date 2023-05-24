using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMPILADORCS
{
    public partial class Compilador : Form
    {
        int Estado, Posicion,columna, direccion;
        char Caracter;
        bool Encontro;
        string Token, wlinea,wSalida;
        int id_usuario,id_lenguaje;
        string lenguaje,usuario;
        dynamic palabrareservada;

        int[,] Matriz;
        public Compilador(int id_usuario, int id_lenguaje)
        {
            this.id_usuario = id_usuario;
            this.id_lenguaje = id_lenguaje;
            lenguaje = Conexion.query("select nombre from lenguajes where id_lenguaje = " + id_lenguaje.ToString()).Rows[0][0].ToString();
            usuario = Conexion.query("select nombre from usuarios where id_usuario = " + id_usuario.ToString()).Rows[0][0].ToString();
            InitializeComponent();
        }

        private void Archivo_txt_Click(object sender, EventArgs e)
        {
            //Programamos para abrir un archivo y trabajar en el
            openFileDialog1.ShowDialog();
            string archivo;
            archivo = openFileDialog1.FileName;
            StreamReader fileReader;//Acomodar para leer linea por linea 
            fileReader = new StreamReader(archivo);
            string stringReader; //Declara la variable 
            while (!fileReader.EndOfStream)
            { //Entra al ciclo y sigue hasta que termine de leer el archivo txt 
                stringReader = fileReader.ReadLine(); //Lee las lineas 
                Entrada_txt.Items.Add(stringReader); //Se agrega el archivo en nuestro listbox de entrada
            }
        }

        private void Compilar_txt_Click(object sender, EventArgs e)
        {
            //Se programa el botón de compilar
            int Renglon = 0;
            while (Renglon < Entrada_txt.Items.Count)
            {
                Entrada_txt.SelectedIndex = Renglon; //Me posiciono en un elemento de la lista
                wlinea = Entrada_txt.Text; //Regresa el valor de donde estoy posicionado
                BuscaTokens(); //Trae todos los tokens agregados en el archivo
                Renglon = Renglon + 1;
            }
            string rutasalida = "Salidas/output";
            DateTime fecha = DateTime.Now;
            rutasalida = rutasalida + lenguaje + usuario + fecha.ToString("dd_MM_yyyy_HH_mm_ss")+".txt";
            StreamWriter write = new StreamWriter(rutasalida);
            for(int i=0; i<Salida_txt.Items.Count; i++)
            {
                Salida_txt.SelectedIndex = i;
                write.WriteLine(Salida_txt.SelectedItem);
            }
            write.Close();
            Conexion.query("insert into compilo(id_usuario,id_lenguaje,fecha,ruta_salida) values (" + id_usuario + "," + id_lenguaje + ",'" + fecha.ToString("yyyy/MM/dd HH:mm:ss") + "','" + rutasalida + "')");
            MessageBox.Show("Compilacion exitosa");
        }

        private void BuscaTokens()
        {
            //Procedimiento para agregar los tokens
            Estado = 0;
            Token = "";
            Posicion = 0;
            //Len regresa la cantidad de caracteres de una variable de texto
            //Mid regresa un caracter de una variable de texto
            while (Posicion < wlinea.Length)
            {
                Caracter = Convert.ToChar(wlinea.Substring(Posicion, 1));
                CalcularColumna(); //Calcula la columna que le corresponde al caracter
                Estado = Matriz[Estado, columna];
                if (Estado >= 100)
                {//Es estado aceptor?
                    if (Token.Length >= 0)
                        ReconoceToken();

                    Estado = 0;
                    Token = "";
                    Salida_txt.Items.Add(Token); //Agregar en el listbox de salida los tokens
                }
                else
                {
                    if (Estado != 0)
                        Token = Token + Caracter;
                }

                Posicion = Posicion + 1;
            }
            if (Token.Length > 0)
            {
                Caracter = ' ';
                CalcularColumna();
                Estado = Matriz[Estado, columna];
                ReconoceToken();
            }
        }

        private void Buscapreservadas()
        {
            int Renglon2;
            Renglon2 = 0;
            direccion = -1;
            while ((!palabrareservada) && (Renglon2 < P_reservadas.Items.Count))
            {
                P_reservadas.SelectedIndex = Renglon2;
                if (Token.ToUpper() == P_reservadas.Text.ToUpper())//Compara las variables en modo mayuscula
                    palabrareservada = true;
                direccion = Renglon2;
                Renglon2 = Renglon2 + 1;
            }
            
        }

        private void Compilador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exportar_Pb_Click(object sender, EventArgs e)
        {
            Exportar exporta = new Exportar();
            exporta.Show();
        }

        private void BuscaIdentificadores()
        {
            //Procedimiento para encontrar identificadores
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while ((!Encontro) && (Renglon2 < IDs_txt.Items.Count))
            {
                IDs_txt.SelectedIndex = Renglon2;
                if (Token.ToUpper() == IDs_txt.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2 + 1;
            }
            if (!Encontro)
            {
                IDs_txt.Items.Add(Token);
                direccion = IDs_txt.Items.Count - 1;
            }
        }

        private void ReconoceToken()
        {
            //Programamos reconoce token para saber que tipo de token es cada palabra
            if (Estado == 100) {
                palabrareservada = false;
                Buscapreservadas();
                if (palabrareservada)
                    wSalida = Token + " PR " + direccion.ToString();
                else {
                    BuscaIdentificadores();
                    wSalida = Token + " ID " + direccion.ToString();
                }
                Posicion = Posicion - 1;
            }
            if (Estado == 101) {
                ConstantesEnteras();
                wSalida = Token + "Ctes.Enteras" + direccion.ToString();
                Posicion = Posicion - 1;
            }
            if (Estado == 102) {
                ConstantesReales();
                wSalida = Token + "Ctes.Reales" + direccion.ToString();
                Posicion = Posicion - 1;
            }
            if (Estado == 103) {
                Token = Token + Caracter;
                ConstantesString();
                wSalida = Token + "Ctes.String" + direccion.ToString();
            }
            if (Estado == 105) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
            }
            if (Estado == 106) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";


        }
            if (Estado == 107) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";


        }
            if (Estado == 108) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";




        }
            if (Estado == 114) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";

        }
            if (Estado == 115) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 116) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 117) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 118) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 119) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 120) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 121) {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
    
        }
            if (Estado == 104){
                Token = Token + Caracter;
                wSalida = Token + "Commentario";
    
        }
            Salida_txt.Items.Add(wSalida); //Añadimos el token en el listbox salida con el tipo de token que es
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ruta_matriz = "matriz" + lenguaje + ".txt";
            string ruta_palabras = "palabras" + lenguaje + ".txt";
            StreamReader matriz = new StreamReader(ruta_matriz);
            StreamReader palabras = new StreamReader(ruta_palabras);
            string[] reservadas = palabras.ReadToEnd().Split('\n');
            palabras.Close();
            for(int i=0; i < reservadas.Length; i++)
            {
                P_reservadas.Items.Add(reservadas[i]);
            }
            int tamaño2 = matriz.ReadLine().Split(',').Length;
            int tamaño1 = 1;
            while (!matriz.EndOfStream)
            {
                matriz.ReadLine();
                tamaño1 = tamaño1 + 1;
            }
            matriz.Close();
            matriz = new StreamReader(ruta_matriz);
            Matriz = new int[tamaño1, tamaño2];
            for(int i=0; i<tamaño1; i++)
            {
                string[] estados = matriz.ReadLine().Split(',');
                for(int j=0; j<tamaño2; j++)
                {
                    Matriz[i,j] = Convert.ToInt32(estados[j]);
                }
            }
            matriz.Close();
        }

        private void CalcularColumna()
        {
            //Calcula el valor de la columna de cada caracter
            if (Caracter >= 'A' && Caracter <= 'Z')
                columna = 0;
            else if (Caracter >= 'a' && Caracter <= 'z')
                columna = 0;
            else if (Caracter >= '0' && Caracter <= '9')
                columna = 1;
            else if (Caracter == '.')
                columna = 2;
            else if (Caracter == '"')
                columna = 3;
            else if (Caracter == '/')
                columna = 4;
            else if (Caracter == '*')
                columna = 5;
            else if (Caracter == '+')
                columna = 6;
            else if (Caracter == '-')
                columna = 7;
            else if (Caracter == '<')
                columna = 8;
            else if (Caracter == '>')
                columna = 9;
            else if (Caracter == '(')
                columna = 10;
            else if (Caracter == ')')
                columna = 11;
            else if (Caracter == '[')
                columna = 12;
            else if (Caracter == ']')
                columna = 13;
            else if (Caracter == '{')
                columna = 14;
            else if (Caracter == '}')
                columna = 15;
            else if (Caracter == ';')
                columna = 16;
            else if (Caracter == ' ')
                columna = 17;
            else if (Caracter == '=')
                columna = 18;
            else if (Caracter == '_')
                columna = 19;
        
        }

        private void ConstantesEnteras()
        {
            //Procedimiento para las constantes enteras
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while (!Encontro && (Renglon2 < C_Enteras.Items.Count))
            { //Entra al ciclo, si encuentra un token le asigna un numero
                C_Enteras.SelectedIndex = Renglon2;
                if (Token.ToUpper() == C_Enteras.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2 + 1;
            }
            if (!Encontro)
            {
                C_Enteras.Items.Add(Token);
                direccion = C_Enteras.Items.Count - 1;
            }
        }

        private void ConstantesReales()
        {
            //Procedimiento para las constantes reales
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while (!Encontro && (Renglon2 < C_Reales.Items.Count))
            { //Entra al ciclo, si encuentra un token le asigna un numero
                C_Reales.SelectedIndex = Renglon2;
                if (Token.ToUpper() == C_Reales.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2 + 1;
            }
            if (!Encontro)
            {
                C_Reales.Items.Add(Token);
                direccion = C_Reales.Items.Count - 1;
            }
        }

        private void ConstantesString()
        {
            //Procedimiento para las constantes string
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while (!Encontro && (Renglon2 < String_txt.Items.Count))
            {
                String_txt.SelectedIndex = Renglon2;
                if (Token.ToUpper() == String_txt.Text.ToUpper())
                {
                    Encontro = true;
                    direccion = Renglon2;
                }
                Renglon2 = Renglon2 + 1;
            }
            if (!Encontro)
            {
                String_txt.Items.Add(Token);
                direccion = String_txt.Items.Count - 1;
            }
        }
    }
}
