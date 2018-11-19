using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNestDemo
{
    public class SubPerson : Person
    {
        public class SubStudent:Student
        {
            public override void show()
            {
                base.show();
            }
        }
    }
}
