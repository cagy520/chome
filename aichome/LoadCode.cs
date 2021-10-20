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
/*****
 * 语义分析模块
 * 2021年10月19日
 * 1.获取
 * 2.先有一个基础，然后增加一层，对对话的类容进行分类
 * 3.计算类、问答类、感情类、功能类、
 * ******/

namespace aichome
{
    public class LoadCode
    {
        public string LoadModel(string txt)
        {
            var script = CSharpScript.RunAsync(LoadFile()).Result;
            string execode = "new QA().Get("+txt+")";
            var result = script.ContinueWithAsync<string>(execode).Result;
            return result.ReturnValue;
        }


        public string LoadFile()
        {
            StreamReader rd = new StreamReader("QA.cs");
            string code = rd.ReadToEnd();
            rd.Close();
            return code;
        }


    }
}
