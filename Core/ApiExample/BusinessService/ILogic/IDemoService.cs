﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.ILogic
{
    public interface IDemoService
    {
        public IEnumerable<T> Get<T>();
        public void Add(Request.DemoAdd demoAdd);
        public void Update(Request.DemoUpdate demoUpdate);
        public void Delete(Request.DemoDelete demoDelete);
    }
}
