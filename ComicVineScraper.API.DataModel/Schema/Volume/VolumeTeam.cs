// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Volumes.VolumeTeam")]
    public class VolumeTeam : EntityBase, IVolumeTeam
    {
        // Related Teams
        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IVolumeTeam.Volume { get { return Volume; } set { Volume = value as Volume; } }

        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam IVolumeTeam.Team { get { return Team; } set { Team = value as Team; } }
    }
}
