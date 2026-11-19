namespace Sportovni.Liga.Api.Entities
{
    public class Match
    {
        public int Id { get; set; }
        //public int HomeTeamId { get; set; }
        //public int AwayTeamId { get; set; }
        public DateTime Date { get; set; }
        public int Round { get; set; }
    }
}
