using GZPSI.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZPSI.Demo
{
    public class Management : Module
    {

        public Management()
        {
            FunctionCollection.AddFunction(typeof(frmSample), "功能演示", "Function_CsbInfo");
        }

    }
}
