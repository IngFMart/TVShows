using System;
using System.Collections.Generic;
using System.Linq;

namespace TVShows
{
    public class TvShowCatalog
    {
        public IList<TvShow> TvShows = new List<TvShow>
        {
            new TvShow()
            {
                  Id = 35624,
                  Name = "The Flash",
                  Permalink = "the-flash",
                  StartDate = "2014-10-07",
                  EndDate = null,
                  Country = "US",
                  Network = "The CW",
                  Status = "Running",
                  Thumbnail = "https://static.episodate.com/images/tv-show/thumbnail/35624.jpg",
                  IsFavorite = true
            },
            new TvShow()
            {
                  Id = 23455,
                  Name = "Game of Thrones",
                  Permalink = "game-of-thrones",
                  StartDate = "2011-04-17",
                  EndDate = null,
                  Country = "US",
                  Network = "HBO",
                  Status = "Ended",
                  Thumbnail = "https://static.episodate.com/images/tv-show/thumbnail/23455.jpg"
            },
            new TvShow()
            {
                  Id = 29560,
                  Name = "Arrow",
                  Permalink = "arrow",
                  StartDate = "2012-10-10",
                  EndDate = null,
                  Country = "US",
                  Network = "The CW",
                  Status = "Ended",
                  Thumbnail = "https://static.episodate.com/images/tv-show/thumbnail/29560.jpg"
            },
        };

        public TvShowCatalog()
        {
        }

        public IEnumerable<string> GetTvShowNames()
        {
            return TvShows.Select(show => show.Name).OrderBy(show => show);
        }

        public IEnumerable<TvShow> GetSortedTvShows()
        {
            return TvShows.Select(show => show).OrderBy(show => show.Name);
        }

        public IEnumerable<TvShow> GetFavoriteTvShows()
        {
            return TvShows.Where(show => show.IsFavorite).OrderBy(show => show.Name);
        }

        public TvShow GetShowById(int id)
        {
            return TvShows.FirstOrDefault(show => show.Id == id);
        }

        public void DisplayTvShowNames()
        {
            foreach(var showName in GetTvShowNames())
            {
                Console.WriteLine(showName.ToString());
            }
        }

        public void DisplayTvShows()
        {
            foreach(var show in GetSortedTvShows())
            {
                Console.WriteLine(show);
            }
        }

        public void DisplayFavoriteTvShows()
        {
            foreach (var show in GetFavoriteTvShows())
            {
                Console.WriteLine(show);
            }
        }

        public void SetFavoriteTvShowById(int id)
        {
            var specifiedShow = GetShowById(id);
            if (specifiedShow != null)
                specifiedShow.IsFavorite = !specifiedShow.IsFavorite;
        }
    }
}
