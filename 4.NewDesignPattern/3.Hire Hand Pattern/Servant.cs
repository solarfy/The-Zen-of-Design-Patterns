using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDesignPattern.Hire_Hand_Pattern
{
    //雇工类
    class Servant
    {
        public void Work(ICleanable cleanable)
        {
            cleanable.Clean();
        }
    }
}
