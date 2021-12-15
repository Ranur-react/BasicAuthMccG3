using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAuthMccG3
{
    public class DisplayHeader
    {
        public int width { private get; set; }
        public String align { protected get; set; }
        public String type { get; set; }

        private Table tb = new Table();
        private tbody tr = new tbody();
        private tbodyLine tl = new tbodyLine();
        private tbodySpace ts = new tbodySpace();

        public DisplayHeader()
        {
            this.width = 60;
            this.align = "center";
            this.type = "double";
        }

        public void Each(String val)
        {
            tb.setWidth(width);
            tr.setWidth(width);
            tl.setWidth(width);
            ts.setWidth(width);
            tb.setAlign(align);
            tr.setAlign(align);
            tl.setAlign(align);
            ts.setAlign(align);
            if (this.type.ToLower() == "line")
            {
                tl.Field(val);
            }
            else if (this.type.ToLower() == "dust")
            {
                tr.Field(val);
            }
            else if (this.type.ToLower() == "double")
            {
                tb.FieldHeader(val);
            }
            else
            {
                ts.Field(val);
            }
        }
        public void Properties(int width, String align, string type)
        {
            this.width = width;
            this.align = align;
            this.type = type;
        }


    }
    public class Display : DisplayHeader
    {
        public Display()
        {
            //constructor

        }
        public Display(int width, String align, string type)
        {
            base.Properties(width, align, type);
        }

        public void Content(String val)
        {
            base.align = "left";
            base.type = "space";
            Each(val);
        }

        public void Box(String val)
        {
            base.align = "left";
            base.type = "line";
            Each(val);
        }

        public void Header(String val)
        {
            base.align = "center";
            base.type = "double";
            base.Each(val);
        }
        public void Footer(String val)
        {
            base.align = "left";
            base.type = "dust";
            Each(val);
        }

    }
}
