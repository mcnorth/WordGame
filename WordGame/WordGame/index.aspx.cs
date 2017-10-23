using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace WordGame
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/files/words.json");
            StreamReader rdr = new StreamReader(path);
            string json = rdr.ReadToEnd();
           
            var wordList = JsonConvert.DeserializeObject<List<Word>>(json);

        }
    }
}