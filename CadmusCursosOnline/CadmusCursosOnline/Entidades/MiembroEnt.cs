using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Entidades
{
    class MiembroEnt
    {
        public int IdMiembro { set; get; }
        public String Usuario { set; get; }
        public String Contrasena { set; get; }
        public String Salt { set; get; }
        public int CupoCurGrat { set; get; }
        public String Nombre { set; get; }
        public String Apellido { set; get; }
        public String DOB { set; get; }
        public String Nacionalidad { set; get; }
        public String FormacionA { set; get; }
        public int NumCursosRecibidos { set; get; }
        public int IdDireccion { set; get; }

        public MiembroEnt(int IdMiembro, String Usuario, String Contrasena, String Salt, int CupoCurGrat, String Nombre, String Apellido, String DOB, String Nacionalidad, String FormacionA, int NumCursosRecibidos, int IdDireccion)
        {
            this.IdMiembro = IdMiembro;
            this.Usuario = Usuario;
            this.Contrasena = Contrasena;
            this.Salt = Salt;
            this.CupoCurGrat = CupoCurGrat;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DOB = DOB;
            this.Nacionalidad = Nacionalidad;
            this.FormacionA = FormacionA;
            this.NumCursosRecibidos = NumCursosRecibidos;
            this.IdDireccion = IdDireccion;
        }

        public MiembroEnt(int IdMiembro, int IdDireccion)
        {
            this.IdMiembro = IdMiembro;
            this.IdDireccion = IdDireccion;
        }

        public MiembroEnt()
        {

        }

        public void SetPassword(String password)
        {
            //Generate Random Salt
            this.Salt = RandomString(128);

            using (MD5 md5Hash = MD5.Create())
            {
                this.Contrasena = GetMd5Hash(md5Hash, password+this.Salt);
                
            }

        }
        public void SetPassword2(String password)
        {
  

            using (MD5 md5Hash = MD5.Create())
            {
                this.Contrasena = GetMd5Hash(md5Hash, password + this.Salt);

            }

        }

        public bool ContrasenaCorrecta(String password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
               password = GetMd5Hash(md5Hash,password+this.Salt);

            }

            if (password.Equals(this.Contrasena))
                return true;
            else
                return false;
        }

         static  bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
