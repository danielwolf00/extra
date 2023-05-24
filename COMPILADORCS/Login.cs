using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace COMPILADORCS
{
    public partial class Login : Form
    {
        DataTable usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void Signin_Btn_Click(object sender, EventArgs e)
        {
            if(Nombre_Txt.Text != "" && Contraseña_Txt.Text != "")
            {
                string contraseña = Encrypt(Contraseña_Txt.Text);
                int n = Conexion.query("select * from usuarios where nombre = '"+Nombre_Txt.Text+"'").Rows.Count;
                if(n > 0)
                {
                    MessageBox.Show("El usuario ya existe");
                }
                else
                {
                    Conexion.query("insert into usuarios(nombre,contra) values('"+Nombre_Txt.Text+"','"+contraseña+"')");
                    MessageBox.Show("Usuario registrado con exito");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }
        }

        private void Inicio_Btn_Click(object sender, EventArgs e)
        {
            if (Nombre_Txt.Text != "" && Contraseña_Txt.Text != "")
            {
                string contraseña = Encrypt(Contraseña_Txt.Text);
                usuario = Conexion.query("select id_usuario from usuarios where nombre = '" + Nombre_Txt.Text + "' and contra = '"+contraseña+"'");
                if(usuario.Rows.Count == 0)
                {
                    MessageBox.Show("Nombre o contraseña invalidos");
                }else
                {
                    Lenguaje_Btn.Enabled = true;
                    Lenguaje_Cb.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos");
            }
        }

        private void Lenguaje_Btn_Click(object sender, EventArgs e)
        {
            if(Lenguaje_Cb.Text != "")
            {
                Compilador compilador = new Compilador(Convert.ToInt32(usuario.Rows[0][0]), Lenguaje_Cb.SelectedIndex+1);
                Visible = false;
                compilador.Show();
            }
            else
            {
                MessageBox.Show("Elige un lenguaje");
            }
        }

        private string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
