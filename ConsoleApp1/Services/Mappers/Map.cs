using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappers
{
    public static class Map
    {
        public static R MapMethod<T, R>(T value)
        {
            var responseR = typeof(R);
            var entityT = value.GetType();

            var InstanceR=(R)Activator.CreateInstance(responseR);

            var RArray = responseR.GetProperties();// title ,content 
            var TArray= entityT.GetProperties();// title ,content, SharedDate 

            foreach (var propR in RArray)
            {
                foreach (var propT in TArray)
                {
                    if(propR.Name == propT.Name)
                    {
                        propR.SetValue(InstanceR, propT.GetValue(value));
                    }
                }
            }
            return InstanceR;

        }
    }
}
