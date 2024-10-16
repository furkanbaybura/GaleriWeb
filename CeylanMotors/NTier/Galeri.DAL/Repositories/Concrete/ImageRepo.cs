﻿using Galeri.DAL.DataContext;
using Galeri.DAL.Repositories.Abstract;
using Galeri.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Repositories.Concrete
{
    public class ImageRepo : Repo<CategoryImage>
    {
        public ImageRepo(GaleriDbContext dbContext) : base(dbContext)
        {
        }
    }
}
