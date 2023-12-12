In this Project we are exploring the .Net core 6 advance features.

1) MapGet and Map method:

2) Action method return types

ViewResult:
Represents an HTML page that is rendered using a view template.
Example:

public IActionResult Index() 
{
    return View();
}

JsonResult:

Represents a JSON-formatted response.
Example:
public IActionResult GetData()
{
    var data = new { key1 = "value1", key2 = "value2" };
    return Json(data);
}


RedirectResult:
Redirects the client to a specified URL.
Example:
public IActionResult RedirectToPage()
{
    return Redirect("/Home/Index");
}



