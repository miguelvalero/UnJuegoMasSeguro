using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GeneradorClaves
{
    public partial class Form1 : Form
    {
        int N, clave_e, clave_d;


        private int PotenciaModulo(int numero, int N, int c)
        // Calcula numero elevado a c módulo N
        // Lo hago de esta manera para evitar que el número que se va generando 
        // sea muy grande y desborde la capacidad de las variables
        {
            int t = 1;
            for (int i = 0; i < c; ++i)
                t = t * numero % N; // asi el resultado parcial se mantiene pequeño
            return t;
        }


        private string Encriptar(string mensaje, int N, int c)
        // Cada caracter del mensaje tiene un códugo ASCII que va entre el 32 
        // (correspondiente al espacio en blando) y el 126 (que corresponde a la tilde)
        // Esos son los 94 caracteres imprimibles (consulta la tabla ASCII en Google).
        // Al código de cada caracter le restamos 32 (el código del primero de los imprimibles
        // Asi obtenemos un número entre el 0 y el 94. Ese es el número al que aplicamos
        // la fórmula de encriptación y al resultado de volvemos a sumar 32 para obtener el código
        // de otro de los caracteres imprimibles, que es el que enviaremos en el mensaje codificado
        // Para que esto funcione es necesario que N sea mayor que 94

        {
            int tam = mensaje.Length;
            char[] caracteres = mensaje.ToCharArray();
            char[] resultado = new char[tam];
            for (int i = 0; i < tam; i++)
            {
                int codigo = caracteres[i] - Convert.ToInt32(' '); 
                int res = PotenciaModulo(codigo, N, c);
                resultado[i] = Convert.ToChar(res + Convert.ToInt32(' '));
            }
           

            return new string(resultado);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private Boolean SonPrimosRelativos(int x, int y)
        {
            if (y == 0)
                if (x == 1)
                    return true;
                else
                    return false;
            else
                return SonPrimosRelativos(y, x % y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(numeroBox.Text);
            if (numero >= N)
                MessageBox.Show("El número a encriptar debe ser menor que N");
            else
            {
                int encriptado = PotenciaModulo(numero, N, clave_e);
                numeroEncriptadoLbl.Text = encriptado.ToString();
                int recuperado = PotenciaModulo(encriptado, N, clave_d);
                numeroRecuperadoLbl.Text = recuperado.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (N < 94)
                MessageBox.Show("N debe ser mayor de 94");
            else { 
                string fraseEnciptada = Encriptar(fraseBox.Text, N, clave_e);
                fraseEncriptadaLbl.Text = fraseEnciptada;
                string fraseRecuperada = Encriptar(fraseEnciptada, N, clave_d);
                fraseRecuperadaLbl.Text = fraseRecuperada;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
        }

        private void generar_Click(object sender, EventArgs e)
        // Aquí es donde generamos todas las posibles claves asociadas a los dos
        // números primos elegidos
        // El código es sencillo y debería entenderse fácilmente
        {
            int P = Convert.ToInt32(PBox.Text);
            int Q = Convert.ToInt32(QBox.Text);
            int N = P * Q;
            int PHI_N = (P - 1) * (Q - 1);

            List<int> posiblesValoresPara_e = new List<int>();
            for (int i = 1; i < PHI_N; i++)
                if (SonPrimosRelativos(i, PHI_N))
                    posiblesValoresPara_e.Add(i);

            List<Tuple<int, int, int>> claves = new List<Tuple<int, int, int>>();

            foreach (int i in posiblesValoresPara_e)
                for (int d = 1; d < PHI_N; d++)
                    if (((d * i) % PHI_N == 1) & (i < d))
                    {
                        claves.Add(new Tuple<int, int, int>(N, i, d));
                        break;
                    }

            tabla.ColumnCount = 3;
            tabla.ColumnHeadersVisible = true;


            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            tabla.Columns[0].Name = "N";
            tabla.Columns[0].Width = 50;
            tabla.Columns[1].Name = "e";
            tabla.Columns[1].Width = 50;
            tabla.Columns[2].Name = "d";
            tabla.Columns[2].Width = 50;
            foreach (Tuple<int, int, int> t in claves)
                tabla.Rows.Add(t.Item1, t.Item2, t.Item3);

            tabla.ScrollBars = ScrollBars.None;

            // Ajusto el tamaño de la tabla a su contenido

            int height = 0;
            foreach (DataGridViewRow row in tabla.Rows)
                height += row.Height;
            
            height += tabla.ColumnHeadersHeight;

            int width = 0;
            foreach (DataGridViewColumn col in tabla.Columns)
                width += col.Width;
  

            tabla.ClientSize = new Size(width + 2, height + 2);

            tabla.ClearSelection();
        }


        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        // si clico en una fila de la tabla, selecciono los valores de esa fila
        // y la marco el rojo
        {
            int fila = e.RowIndex;
            // Primero pongo todas las filas en blanco
            foreach (DataGridViewRow row in tabla.Rows)
              row.DefaultCellStyle.BackColor = Color.White;
            N = Convert.ToInt32(tabla.Rows[fila].Cells[0].Value);
            clave_e = Convert.ToInt32(tabla.Rows[fila].Cells[1].Value);
            clave_d = Convert.ToInt32(tabla.Rows[fila].Cells[2].Value);
            tabla.Rows[fila].DefaultCellStyle.BackColor = Color.Red;
            tabla.ClearSelection();

        }
    }
}
