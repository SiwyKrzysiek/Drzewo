//Algorytmy i struktury danych
//Zadanie: Napisać strukturę drzewa z dowolną liczbą dzieci w każdym węźle
//Autor: Krzysztof Dąbrwoski

//Szkic struktury przykładowego drzewa jest w pliku "Drzewo w programie.jpg"

using System;

namespace Drzewo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Budowa przykładowego drzewa ("Drzewo w programie.jpg")
            //Pierwszy poziom
            Tree<int> tree = new Tree<int>(7);

            //Drugi poziom
            tree.AddManyChildren(new int[]{ 8, 3, 5 });

            //Trzeci poziom
            tree[0].AddManyChildren(new int[] { 14, 2 });
            tree[1].AddOneChild(1);
            tree[2].AddManyChildren(new int[] { -8, 30 });

            //Czwarty poziom
            tree[0][0].AddManyChildren(new int[] { 0, 1, 0 });
            tree[1][0].AddManyChildren(new int[] { 3, 4, 2 });
            tree[2][0].AddOneChild(13);
            tree[2][1].AddManyChildren(new int[] { -10, 42 });

            //Console.WriteLine(tree.GetChildrenAsText());

            //tree.DFS();
            //tree.BFS();

            Console.WriteLine(tree.BFSWalk());
        }
    }


}
