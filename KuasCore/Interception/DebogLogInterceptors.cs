using AopAlliance.Intercept;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Interception
{
    class DebogLogInterceptors : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            /**************/
            /**************/
            /***目標程式***/
            /**************/
            /**************/
            sw.Stop();//碼錶停止
            //印出所花費的總豪秒數
            string result1 = sw.Elapsed.TotalMilliseconds.ToString();

            result += result1;


            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);

            return result;
        }
    }
}
