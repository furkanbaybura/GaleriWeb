﻿using AutoMapper;
using Galeri.DTO;
using Galeri.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.BLL.Managers.Abstract
{
    public interface IManager<TDto, TViewModel>
      where TDto : BaseDto
      where TViewModel : BaseViewModel
    {
        IMapper Mapper { set; }
        int Add(TViewModel viewmodel,bool isEntityId = false);
        int Update(TViewModel viewmodel);
        int Delete(TViewModel viewmodel);
        int Delete(int id);
        IEnumerable<TViewModel> GetAll();
        TViewModel? Get(int id);
    }
}
