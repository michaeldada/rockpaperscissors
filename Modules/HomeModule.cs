using Nancy;
using System.Collections.Generic;

namespace AnagramNameSpace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

    }
  }
}
