using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingOnDataType
{
    public class DynamicType
    {
        public void PrintDynamicType()
        {
            dynamic studentObject = "This is studentObject variable Data as a Text";

            Console.WriteLine($"Print Student Object Fist Time : {studentObject}. Type First : " + studentObject.GetType());

            //Allocate a Int value on studentObject
            studentObject = 4;
            Console.WriteLine($"Print Student Object Second Time : {studentObject}. Type Second : " + studentObject.GetType());
        }
    }
}
