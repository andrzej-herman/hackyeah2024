namespace SerdecznaApi
{
    public class Projekt
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string Content { get; set; }

        public string Link { get; set; }
        public Projekt(string title, string subtitle, string content, string link)
        {
            Title = title;
            Subtitle = subtitle;
            Content = content;
            Link = link;
        }

    }
}
