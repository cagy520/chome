using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;


namespace aichome
{
    public class LoadCode
    {



        public string LoadModel()
        {
            var script = CSharpScript.RunAsync(LoadFile()).Result;
            string txt = @"new Test().Get(""cagy"")";
            var result = script.ContinueWithAsync<string>(txt).Result;
            //Console.WriteLine(result.ReturnValue);
            return result.ReturnValue;
        }


        public string LoadFile()
        {
            StreamReader rd = new StreamReader("Test.cs");
            string code = rd.ReadToEnd();
            rd.Close();
            return code;
        }


    }
}
