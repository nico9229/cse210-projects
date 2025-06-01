using System;



class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Learning C#", "Nicolas A. Ayala", 300);
        Video v2 = new Video("Learning Englis rules", "Samuel", 520);
        Video v3 = new Video("Baking cookies", "Adrian", 600);
        Video v4 = new Video("Climbing", "Pedro", 200);
        List<Video> all = new List<Video> { v1, v2, v3, v4 };


        v1.setComent(new Comment("Ana", "Good video!"));
        v1.setComent(new Comment("Marce", "Yes !, I like"));
        v1.setComent(new Comment("Bruno", "Exelent"));

        v2.setComent(new Comment("Nico", "Hufffff"));
        v2.setComent(new Comment("Bruno", "Very easy"));
        v2.setComent(new Comment("Sam", "O_O"));


        v3.setComent(new Comment("Nico", "Delicious"));
        v3.setComent(new Comment("Marce", "that's lovely!"));
        v3.setComent(new Comment("Claudio", "Wow ! "));

        v4.setComent(new Comment("Lucas", "Whats in the world !!"));
        v4.setComent(new Comment("Nico", "I would like to do it"));
        v4.setComent(new Comment("Bruno", "I'm scared of it"));

        foreach (Video i in all)
        {
            i.displayVideo();
            i.displayComment();
            
        }
        
    }
    
    
}