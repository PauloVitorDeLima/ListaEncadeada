using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Controller
{
    class Node
    {
        private string name;
        private int age;
        private double size;
        private float salario;
        private string sexo;

        private Node next;
        public Node(string name, int age)
        {
            name = Name;
            age = Age;
            Next = null;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal Node Next { get => next; set => next = value; }
     
    }
}
