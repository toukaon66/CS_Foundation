using Ex_03_10 Modules;
namespace Ex_03_10;



static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("DVDのタイトルを入力してください->");
        string.dvdMedia = System.Console.ReadLine();
        Player DVDPlayer=new DVDPlayer(dvdMedia);
        DVDPlayer.Play();
        DVDPlayer.Stop();
        System.Console.Write("Blu-rayのタイトルを入力してください->");
        string.blurayMedia = System.Console.ReadLine();
        Player BlurayPlayer=new DVDPlayer(dvdMedia);
        BlurayPlayer.play();
        BlurayPlayer.Stop();


    }
}
