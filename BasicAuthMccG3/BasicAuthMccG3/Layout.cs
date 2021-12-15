using System;

namespace BasicAuthMccG3
{
	//Table Design  - - - - - - -
	public class Layout
	{
		//Overriding Example on a method
		private String align = "center";
		public int x = 60;
		public String DefaultBodySpace = " ";
		public Layout()
		{
			//constructor;
		}
		public Layout(int v)
		{
			x = v;
		}
		public void setAlign(String x)
		{
			align = x;
		}
		public void setWidth(int v)
		{
			x = v;
		}
		public void setBodyElement(String x)
		{
			DefaultBodySpace = x;
		}
		public String MarginSpace()
		{
			String space = "| ";
			for (int i = 0; i < x; i++)
			{
				space += DefaultBodySpace;
			}
			space += " |";
			return space;
		}
		public String MarginSpace(String margin, String bdy)
		{
			//int x=getLayoutSize();

			int y = bdy.Length;
			String space = "| ";
			int z = 0;
			for (int i = 0; i < x; i++)
			{
				//rata tengah/ center align
				if (align.ToLower() == "center")
				{
					if (i >= ((x - y) / 2) && i < (((x - y) / 2) + y))
					{
						space += bdy[z];
						z++;
					}
					else
					{
						space += margin;
					}
				}
				//rata kiri /left align
				else if (align.ToLower() == "left")
				{
					if (i < y)
					{
						space += bdy[z];
						z++;
					}
					else
					{
						space += margin;
					}
				}
				//rata Kanan /right align
				else
				{
					if (i > (x - y))
					{
						space += bdy[z];
						z++;
					}
					else
					{
						space += margin;
					}
				}

			}
			space += " |";
			return space;
		}
	}
	public class Table : Layout
	{
		public Table()
		{
			//consructor
		}
		public void FieldHeader(String body)
		{
			Console.WriteLine(MarginSpace("=", ""));
			Console.WriteLine(MarginSpace());
			Console.WriteLine(MarginSpace(" ", body));
			Console.WriteLine(MarginSpace());
			Console.WriteLine(MarginSpace("=", ""));
		}

	}
	public class tbody : Table
	{
		public tbody()
		{
			//constructor
		}
		public virtual void Field(String body)
		{
			Console.WriteLine(MarginSpace(" ", ""));
			Console.WriteLine(MarginSpace(" ", body));
			Console.WriteLine(MarginSpace("-", ""));
		}
	}
	public class tbodyLine : tbody
	{
		public tbodyLine()
		{
			//constructor
		}
		public override void Field(String body)
		{
			Console.WriteLine(MarginSpace(" ", ""));
			Console.WriteLine(MarginSpace(" ", body));
			Console.WriteLine(MarginSpace("_", ""));
		}

	}
	public class tbodySpace : tbody
	{
		public tbodySpace()
		{
			//constructor
		}
		public override void Field(String body)
		{
			Console.WriteLine(MarginSpace(" ", ""));
			Console.WriteLine(MarginSpace(" ", body));
			Console.WriteLine(MarginSpace(" ", ""));
		}
	}
}