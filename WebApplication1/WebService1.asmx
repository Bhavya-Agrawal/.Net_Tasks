<%@ WebService Language="C#" Class="WebService1" %>


using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Linq;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

/*public class WebService1 : System.Web.Services.WebService
{
    public WebService1()
    {
        //
        // TODO: Add any constructor code required
        //
    }

    // WEB SERVICE EXAMPLE
    // The HelloWorld() example service returns the string Hello World.

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
}*/

//defining a new public class named WebService1 for implementing Arithmetic operations
public class WebService1 : System.Web.Services.WebService
{
    public WebService1()   {
        //Uncomment the following line if using designed components  
        //InitializeComponent();  
    }
    [WebMethod]
    public int Add(int x, int y)
    {
        return x + y;
    }
    [WebMethod]
    public int Sub(int x, int y)
    {
        return x - y;
    }
    [WebMethod]
    public int Mul(int x, int y)
    {
        return x * y;
    }
    [WebMethod]
    public int Div(int x, int y)
    {
        return x / y;
    }
}
