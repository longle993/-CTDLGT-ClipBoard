using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClipBoard
{
    public partial class frmCB : Form
    {
        #region Bo góc
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        #endregion
        Stack<string> myStack = new Stack<string>();

        public frmCB()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        #region Button
        private void btnEXIT_Click(object sender, EventArgs e) //nút exit
        {
            Close();
        }
        private void btnCopy_Click(object sender, EventArgs e) //nút copy
        {
            if (txtText.SelectedText == null || txtText.SelectedText == "")
            {
                myStack.Push(txtText.Text);

            }
            else
            {
                string txt = txtText.SelectedText;
                myStack.Push(txt);
            }
            txtClipBoard.Text = "------------------------------------------------------" + "\r\n" + myStack.Peek() + "\r\n" + txtClipBoard.Text;
        }
        private void btnPaste_Click(object sender, EventArgs e) //nút Paste
        {
            if (myStack.Count > 0)
            {
                string txt = txtClipBoard.SelectedText;
                if (txt == null || txt == "")
                        txtText.Text += myStack.Peek();
                else
                {
                    foreach (string item in myStack)
                    {
                        if (item == txt)
                            txtText.Text += item;
                    }
                }
            }
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            myStack.Clear();
            txtClipBoard.Text = "";
        }
        #endregion
        #region Di chuyển form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmGiaoDien_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void frmGiaoDien_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void frmGiaoDien_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        private void frmCB_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 750, WinAPI.BLEND);
        }
    }
}
