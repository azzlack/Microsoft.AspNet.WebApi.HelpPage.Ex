<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    @RenderSection("scripts", required: false)
    <link type="text/css" href="~/Areas/HelpPage/HelpPageEx.css" rel="stylesheet" />
</head>
<body>
    @RenderBody()
</body>
</html>