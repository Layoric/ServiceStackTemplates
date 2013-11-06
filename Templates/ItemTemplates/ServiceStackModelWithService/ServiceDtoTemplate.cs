using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using ServiceStack.Common.Web;
using ServiceStack.DataAnnotations;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using $rootnamespace$.Models;

namespace $rootnamespace$.DTOs
{
    /// <summary>
    /// //TODO Change Path
    /// Data transport object
    /// </summary>
    [Route("/change/this/path")]
    public class $safeitemname$ : IReturn<List<$fileinputname$>>
    {
        //TODO Add Properties here, eg if you're using ORMLite
        //[AutoIncrement]
        //public int Id { get; set; }
    }
}
