//Algorytmy i struktury danych
//Zadanie: Napisać strukturę drzewa z dowolną liczbą dzieci w każdym węźle
//Autor: Krzysztof Dąbrwoski

//Szkic struktury przykładowego drzewa jest w pliku "Drzewo.png"

using System;

namespace Drzewo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tree<int> tree = Tree<int>.CreateExampleTree();

            //Przechodzenie przykładowego drzewa
            Console.WriteLine("Przejście drzewa w głąb:");
            Console.WriteLine(tree.DFSWalk());

            Console.WriteLine("\nPrzejście drzewa w szerz:");
            Console.WriteLine(tree.BFSWalk());

            //Wyszukiwanie wskazanego elementu w drzewie
            int found = tree.DFS(x => x == 1);
            //Console.WriteLine("\n" + found);
        }
    }
}
