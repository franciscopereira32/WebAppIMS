﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.CoreBusiness;

namespace IMS.UseClases.PluginInterfaces
{
    internal interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync (string name);
    }
}
