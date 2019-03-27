using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Controller
{
    class List
    {
        //Nó da Cabeça e calda
        //aa
        private Node begin = null, end = null;

        internal Node Begin { get => begin; set => begin = value; }
        internal Node End { get => end; set => end = value; }

        public void RemoveFirst()
        {
            if(Begin != null)
            {
                Begin = Begin.Next;
            }
        }
        public void RemoveLast()
        {
            if (Begin == null)
            {
                
                return;
            }
            if (Begin.Next == null)
            {
                Begin = null;
            }
            else
            {
                Node last = Begin.Next;
                Node penultimate = Begin;
                while(last.Next != null)
                {
                    penultimate = last;
                    last = last.Next;
                }
                penultimate.Next = null;
                end = penultimate;
            }
        
        }
        
        public void InsertFirst(string Name, int Age)
        {
            //Cria Nó
            Node newNode = new Node(Name, Age);
            //Novo nó recebe o Valor
            newNode.Name = Name;
            newNode.Age = Age;
            //Verifica se é o primeiro nó
            if (Begin == null)
            {
                //A cabeça e a Calda recebem o novo valor
                Begin = newNode;
                End = newNode;

            }
            else
            {
                //o Próximo Nó recebe a cabeça
                newNode.Next = Begin;
            }
            //A cabeça recebe o novo nó
            Begin = newNode;
        }public void InsertLast(string Name, int Age)
        {

            //Cria o nó com os valores que serão recebidos
            Node newNode = new Node(Name, Age);
            //Novo nó recebe o valor 
            newNode.Name = Name;
            newNode.Age = Age;
            //Verifica se é o primeiro
            if (Begin == null)
            {
                Begin = newNode;
                End = newNode;
            }
            else
            {
                //Adiciona ao próximo da lista o novo valor
                End.Next = newNode;
            }
            //Adiciona a calda o novo valor
            End = newNode;
        }
    }
}
