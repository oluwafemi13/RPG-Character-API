namespace RPG_Character_API.RPG.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; } = 100;
        // public int TotalScore { get; set; }
        public int Strength { get; set; }=10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Life { get; set; } = 100;

        public RPGClass Rpg{ get; set; }

    }
}
