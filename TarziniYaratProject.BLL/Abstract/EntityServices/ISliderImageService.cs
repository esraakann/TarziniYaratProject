﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.BLL.Abstract.EntityServices
{
    public interface ISliderImageService : IBaseService<SliderImage>
    {
        bool UpdateActive(int id);
    }
}
