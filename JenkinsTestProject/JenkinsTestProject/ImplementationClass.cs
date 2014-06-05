using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTestProject
{
    public interface IImplementationClass
    {
        int AddTwoNumbers(int a, int b);
    }

    public class ImplementationClass : IImplementationClass
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
