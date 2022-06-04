using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bstree bt = new Bstree();
            bt.root = bt.insert(bt.root,15);
            bt.root = bt.insert(bt.root,20);
            bt.root = bt.insert(bt.root,25);
            bt.root = bt.insert(bt.root,22);
            bt.root = bt.insert(bt.root,5);
            bt.root = bt.insert(bt.root,1);
            bt.root = bt.insert(bt.root,100);
            int enkucuk = bt.enKucukBul(bt.root).data;
            Console.WriteLine("EN KUCUK ELEMAN : "+ enkucuk);
            int enbuyuk = bt.enBuyukBul(bt.root).data;
            Console.WriteLine("EN BUYUK ELEMAN : " + enbuyuk);
            //Console.Write("Aranacak düğümü yazınız :");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (bt.search(bt.root, x)== true)
            //{
            //    Console.WriteLine("Aranan düğüm bulundu");
            //}
            //else
            //{
            //    Console.WriteLine("Aranan düğüm bulunamadı");
            //}
            //Console.WriteLine("Kökün solundaki düğüm => "+bt.root.left.data );
            //Console.WriteLine("Kökün sağındaki düğüm => "+bt.root.right.data );
            //Console.WriteLine("Kökün sağının sağındaki düğüm => "+bt.root.right.right.data );
            //Console.WriteLine("Kökün sağının sağının solundaki düğüm => "+bt.root.right.right.left.data );


            Console.ReadLine();
        }
    }
}
