// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Videos.VideoType")]
    public class VideoType : NameableEntityBase, IVideoType
    {
        // Associated  Objects
        public virtual ICollection<Video> Videos { get; set; }

        ICollection<IVideo> IVideoType.Videos { get { return (ICollection<IVideo>)Videos; } set { Videos = value as ICollection<Video>; } }
    }
}
