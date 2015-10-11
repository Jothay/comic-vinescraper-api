// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Studios.Studio")]
    public class Studio : NameableEntityBase, IStudio
    {
        // Associated Objects
        public virtual ICollection<MovieStudio> MovieStudios { get; set; }

        ICollection<IMovieStudio> IStudio.MovieStudios { get { return (ICollection<IMovieStudio>)MovieStudios; } set { MovieStudios = value as ICollection<MovieStudio>; } }
    }
}
