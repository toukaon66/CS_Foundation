using System;
using Ex_03_10.Modules;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("DVDのタイトルを入力してください->");
        string dvdMedia = Console.ReadLine();
        Player DVDPlayer=new DVDPlayer(dvdMedia);
        DVDPlayer.Play();
        DVDPlayer.Stop();
        System.Console.Write("Blu-rayのタイトルを入力してください->");
        string blurayMedia =Console. ReadLine();
        Player BlurayPlayer=new BlurayPlayer(blurayMedia);
        blurayMedialurayPlayer.play();
        blurayPlayer.Stop();


    }
}
