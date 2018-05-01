using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace MyHackerrankChallenges.Practice
{
    internal class Testing : IChallenge
    {
        public void Main(string[] args)
        {
            var JsonString =
                "<![CDATA[{\r\n    \"exampleJson\": {\r\n        \"url\":  \"http://example.com/\",\r\n        \"html\": \"<a href=\\\"http://example.com\\\" rel=\\\"test\\\">example text</a>\"\r\n    }\r\n}]]>";
            StringBuilder sbXML = new StringBuilder();
            sbXML.Append("<root>");
            sbXML.AppendFormat("<messageBody>{0}</messageBody>", JsonString);
            sbXML.Append("</root>");

            XmlDocument xmlDOC = new XmlDocument();
            xmlDOC.LoadXml(sbXML.ToString());


            Type genericType = Type.GetType("MyHackerrankChallenges.Practice.Testing");
            MethodInfo methodInfo = typeof(ConverterClass).GetMethod("ConvertTableToList", BindingFlags.Public | BindingFlags.Static).MakeGenericMethod(genericType);
            methodInfo.Invoke(null, new object[]{ new List<User>() });

            //ConverterClass.ConvertTableToList<Testing>(null);
            //var t = new List<dynamic>();
            //t.ConvertTableToList<>()

        }
    }

    public class User
    {
        public int Id { get; set; }

        
    }

    public static class ConverterClass
    {
        public static List<T> ConvertTableToList<T>(this IList<User> table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();
                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType("", propertyInfo.PropertyType),
                                null);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}