﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IRecreationRepository
    {
        List<Recreation> GetAllRecreation();
        Recreation GetRecreationById(int id);
        Recreation PostRecreation(Recreation recreation);
        void PutRecreation(int id, Recreation recreation);
        void DeleteRecreation(int id);
    }
}
