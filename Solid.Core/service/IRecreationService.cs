using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.service
{
    public interface IRecreationService
    {
        List<Recreation> GetAllRecreation();
    }
}
