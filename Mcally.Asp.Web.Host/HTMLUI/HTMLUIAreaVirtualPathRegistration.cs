
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLUI
{
    public class  HTMLMUIAreaVirtualPathRegistration : IAreaVirtualPathRegistration
    {
        public List<KeyValuePair<string, string>> GetPath()
        {
            var pathList = new List<KeyValuePair<string, string>>();
            pathList.Add(new KeyValuePair<string, string>("HTMLUI", "HTMLUI"));

            return pathList;
        }
    }

    public interface IAreaVirtualPathRegistration
    {
        List<KeyValuePair<string, string>> GetPath();
    }
}



