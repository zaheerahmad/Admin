

using System;
using SubSonic;

public partial class Generators : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //bool missingPath = !String.IsNullOrEmpty(CodeService.TemplateDirectory) && !Directory.Exists(CodeService.TemplateDirectory);

        //divWarning.Visible = missingPath;
        //ClassGenerator1.Visible = !missingPath;
        //ScaffoldGenerator1.Visible = !missingPath;
    }

    protected override void OnPreRender(EventArgs e)
    {
        WebUIHelper.EmitClientScripts(this);
        base.OnPreRender(e);
    }
}