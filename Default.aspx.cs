using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cc_lab12
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            lblResult.Text = "You are calm and analytical!";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            lblResult.Text = "You are adventurous and bold!";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            lblResult.Text = "You are energetic and mischievous!";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            lblResult.Text = "You are creative and imaginative!";
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
                        lblResult.Text = "You are thoughtful and introspective!";
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
                        lblResult.Text = "You are calm and collected!";
        }
    }
}