namespace Ex_03_10.Modules;

public abstract class Player
{
    public string Media {set;get;}
    // private string media;
    // public void setMedia(string media)
    // {
    //     this.media = media;
    // }
    // public string getMedia()
    // {
    //     return media;
    // }

    public void player(string Media)
    {
        this.Media = Media;
    }

    
    public abstract void Play();
    
    public abstract void Stop();
    
}
