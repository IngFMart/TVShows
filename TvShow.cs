namespace TVShows
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Permalink { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Country { get; set; }
        public string Network { get; set; }
        public string Status { get; set; }
        public string Thumbnail { get; set; }
        public bool IsFavorite { get; set; }

        public TvShow()
        {
        }

        public override string ToString()
        {
            return $"{Id} {Name} {(IsFavorite ? "*" : "")}";
        }
    }
}
