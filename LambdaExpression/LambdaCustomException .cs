using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class LambdaCustomException
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            NO_SUCH_AGE
        }
        public LambdaCustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
