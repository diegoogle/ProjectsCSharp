﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_usuariosSuscritos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      GridView1.DataSource = Membership.GetAllUsers();
      GridView1.DataBind();
    }
}