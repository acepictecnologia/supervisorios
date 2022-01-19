using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    class Livro
    {
        //Construtor
        public Livro()
        {
        }

        //Propriedades - Private
        private int id;
        private string titulo;
        private string autor;
        private string editora;
        private DateTime data_pub;

        //Propriedades - Public
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public DateTime Data_pub
        {
            get { return data_pub; }
            set { data_pub = value; }
        }

    }
}
