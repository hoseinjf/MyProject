using AppDomainCore.Categorys.Entity;
using AppDomainCore.Photos.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    public class PhotoConfigurations : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasData( new Photo() { Id = 1 , Src = "ss"} );
            builder.HasData( new Photo() { Id = 2 , Src = "sqs"} );
            builder.HasData( new Photo() { Id = 3 , Src = "ee"} );
            builder.HasData( new Photo() { Id = 4 , Src = "rr"} );
            builder.HasData( new Photo() { Id = 5 , Src = "tt"} );
            builder.HasData( new Photo() { Id = 6 , Src = "yy"} );
            builder.HasData( new Photo() { Id = 7 , Src = "uu"} );
        }
    }
}
