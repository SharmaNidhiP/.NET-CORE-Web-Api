﻿namespace CorefirstProj.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficulty { get; set; }
    
    //navigation property
    public Region Region { get; set; }
        public WalkDifficulty WalkDificulty { get; set; }    
    }
}
