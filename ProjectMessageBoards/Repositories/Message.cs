namespace ProjectMessageBoards.Repositories
{
    //using in memort repositroy for initial work
    //would normally use a library or in-memory database but the requirements state not to use a database

    public class Message
    {
        public string User { get; set; }
        public string Project { get; set; }
        public string MessageContent { get; set; }

        public DateTime Time { get; set; }

        //todo improve to be more than just minutes e.g.days and hours
        //likely .Net has a good timeformating API for this instead of this hack
        public string Format(DateTime time)
        {
            var differentInMinutes = (time - Time).TotalMinutes;
            var flooredTime = Math.Floor(differentInMinutes);
            if(flooredTime == 1)
            {
                return $"{MessageContent} ({flooredTime} minute ago)";
            }
            return $"{MessageContent} ({flooredTime} minutes ago)";
        }

        public string TimeAgoFormated(DateTime time)
        {
            var differentInMinutes = (time - Time).TotalMinutes;
            var flooredTime = Math.Floor(differentInMinutes);
            if (flooredTime == 1)
            {
                return $"({flooredTime} minute ago)";
            }
            return $"({flooredTime} minutes ago)";
        }
    }
}
