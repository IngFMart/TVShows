using System;

namespace TVShows
{
    class Program
    {
        static void Main(string[] args)
        {
            var tvShowCatalog = new TvShowCatalog();

            if(args.Length > 0)
            {
                switch (args[0])
                {
                    case "list":
                        tvShowCatalog.DisplayTvShows();
                        break;

                    case "favorites":
                        tvShowCatalog.DisplayFavoriteTvShows();
                        break;

                    default:
                        var parseSucceded = int.TryParse(args[0], out int result);
                        if (parseSucceded)
                        {
                            tvShowCatalog.SetFavoriteTvShowById(result);
                            tvShowCatalog.DisplayFavoriteTvShows();
                        }
                        break;
                }
            }
            else
            {
                tvShowCatalog.DisplayTvShows();
            }
        }
    }
}
