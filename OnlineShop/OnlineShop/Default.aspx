<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineShop.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>@ViewBag.Title</title>

    <!-- Bootstrap -->
    <link href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet"/>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->










    <style>
        .item {
            padding: 25px;
            transition: all .3s;
            -webkit-transition: all .3s;
        }

            .item:hover {
                transform: scale(1.05);
                -ms-transform: scale(1.05);
                -webkit-transform: scale(1.05);
                box-shadow: 0 0 20px #888;
            }

        .menu {
            padding: 25px
        }

        .footer {
            padding: 25px;
            text-align: center;
        }
    </style>


</head>
<body>
    <form id="form2" runat="server">
        <div>



            <nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="@Url.Content("~/")">Shop Online</a>
        </div>
        <div id="navbar" class="collapse navbar-collapse">
            <ul class="nav navbar-nav">
                <li><a href="@Url.Content("~/")">Strona glowna</a></li>


                <li class="dropdown">


                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Buty <span class="caret"></span></a>
                    <ul class="dropdown-menu">


                        <li class="dropdown-header">damskie</li>





                        @foreach (var category in Model.Where(a => a.CategoryForWomen))
                        {
                            <li>
                                <a href="@Url.Action("List", "Products", new { nameCategories = category.CategoryName.ToString() })">

                                    @category.CategoryName
                                </a>
                            </li>
                        }


                   





                        <li role="separator" class="divider"></li>
                        <li class="dropdown-header">meskie</li>

                        @foreach (var category in Model.Where(a => a.CategoryForMen))
                        {
                            <li>
                                <a href="@Url.Action("List", "Products", new { nameCategories = category.CategoryName.ToString() })">

                                    @category.CategoryName
                                </a>
                            </li>
                        }



                    </ul>
                <li><a href="@Url.Action("StaticSites","Home", new { name = "AboutUs"})">O nas</a></li>
                <li><a href="@Url.Action("StaticSites","Home", new { name = "Contact"})">Kontakt</a></li>

                <li>
                    <a id="koszykHeaderLink" href="link">
                        Koszyk (0)
                    </a>
                    <span></span>
                </li>




            </ul>
        </div><!--/.nav-collapse -->
    </div>
</nav>














        </div>
    </form>
</body>
</html>
