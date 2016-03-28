using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HundsunExtDemo
{
    public class AutoSizeController
    {
        public struct ControlRect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
        }

        public List<ControlRect> oldCtrl = new List<ControlRect>();
        public void ControlInitializeSize(Control control)
        {
            ControlRect cR;
            cR.Left = control.Left;
            cR.Top = control.Top;
            cR.Width = control.Width;
            cR.Height = control.Height;

            oldCtrl.Add(cR);
            AddControl(control);
        }

        private void AddControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                ControlRect cR = GetControlRect(c);
                oldCtrl.Add(cR);

                if (c.Controls.Count > 0)
                {
                    AddControl(c);
                }
            }
        }

        private ControlRect GetControlRect(Control control)
        {
            ControlRect cR;
            cR.Left = control.Left;
            cR.Top = control.Top;
            cR.Width = control.Width;
            cR.Height = control.Height;

            return cR;
        }

        //public void ControlAutoSize(Control control)
        //{ 
        //    if
        //}
    }
}
