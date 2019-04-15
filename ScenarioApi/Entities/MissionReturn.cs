namespace ScenarioApi.Controllers
{
    public class MissionReturn
    {
        public int MissionId { get; set; }
        public string MissionDescription { get; set; }
        public string MissionTypeName { get; set; }
        public string RewardDescription { get; set; }
        public string UpgradeName { get; set; }
        public string UpgradeDescription { get; set; }
    }
}