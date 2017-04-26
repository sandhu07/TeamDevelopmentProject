using System.Text;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace Healthcare
{
    
    /// <summary>
    /// Summary description for Modal
    /// </summary>
    public class Modal
    {

        public static void Close(Page page)
        {
            Close(page, null);
        }

        public static string Script(object result)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type='text/javascript'>");
            sb.Append("if (parent && parent.Healthcare && parent.Healthcare.ModalStatic) {");
            sb.Append("parent.Healthcare.ModalStatic.close(" + new JavaScriptSerializer().Serialize(result) + ");");
            sb.Append("}");
            sb.Append("</script>");

            return sb.ToString();
        }

        public static void Close(Page page, object result)
        {
            page.ClientScript.RegisterStartupScript(typeof(Page), "close", Script(result));
            return;
        }

    }

}
