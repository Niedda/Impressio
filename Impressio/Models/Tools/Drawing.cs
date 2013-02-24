using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Impressio.Models.Tools
{
  public static class Drawing
  {
    public static void Draw(PanelControl drawPanel, int printFormatWidth, int printFormatHeight, int width, int height, int useVertical, int useHorizontal, bool flipped = false, bool drawBorder = true)
    {
      var graphic = drawPanel.CreateGraphics();
      graphic.Clear(Color.White);
      var pen = new Pen(Color.Black, 1);
      int div = 1;
      while (drawPanel.Height < printFormatHeight)
      {
        div++;
        if ((printFormatHeight / div) < drawPanel.Height)
        {
          break;
        }
      }

      //Draw the Paper
      if (printFormatWidth > printFormatHeight)
      {
        graphic.DrawRectangle(pen, 10, 10, (float)printFormatWidth / div, (float)printFormatHeight / div);
      }
      else
      {
        graphic.DrawRectangle(pen, 10, 10, (float)printFormatHeight / div, (float)printFormatWidth / div);
      }

      //Define the values
      var drawH = (float)height / div; //drawW = height * ((pages / 2) / div;
      var drawW = (float)width / div;

      if (flipped)
      {
        drawH = (float)width / div; //drawH = width * ((pages / 2) / div;
        drawW = (float)height / div;
      }

      var distance = (float)(drawBorder ? 4 / div : 0);
      var leftDistance = (float)10 / div;
      var heightDistance = (float)10 / div;
      var totalW = drawW + distance;
      var totalH = drawH + distance;
      pen.Color = useVertical * totalH > (float)printFormatHeight / div || totalW * useHorizontal > (float)printFormatWidth / div ? Color.Red : Color.Blue;

      for (int o = 0; o <= useVertical - 1; o++)
      {
        for (int i = 0; i <= useHorizontal - 1; i++)
        {
          graphic.DrawRectangle(pen, leftDistance + distance + (i * totalW), heightDistance + distance + (o * totalH), drawW, drawH);
        }
      }
    }
  }
}
