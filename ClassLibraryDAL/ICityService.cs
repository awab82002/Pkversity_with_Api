﻿using ClassLibraryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public interface ICityController 
    {
        List<EntCities> GetCities();

    }
}
