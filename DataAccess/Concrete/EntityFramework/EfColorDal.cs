﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color Entity)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Color GetT(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Color Entity)
        {
            throw new NotImplementedException();
        }
    }
}
