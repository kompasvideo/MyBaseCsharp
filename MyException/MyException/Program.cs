using System;
using System.Collections;
using System.Reflection;

namespace MyException
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Exception ex = new Exception();
            // хранит сообщение об исключении, текст ошибки
            string message = ex.Message;
            
            // хранит имя объекта или сборки
            string source = ex.Source;
            string helpLink = ex.HelpLink;   
            // строковое представление стека вызовов
            string stackTrace = ex.StackTrace;
            int hResult = ex.HResult;   
            // хранит информацию об исключении, которое послужило причиной текущего исключения
            Exception e = ex.InnerException;
            IDictionary dict = ex.Data;
            // возвращяет метод, в котором и было вызвано исключение
            MethodBase targetSite = ex.TargetSite;
        }
    }
}