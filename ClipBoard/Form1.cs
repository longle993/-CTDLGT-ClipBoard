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

    public partial class frmGiaoDien : Form
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
        public frmGiaoDien() //form giao diện
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        #region Button
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmCB formmoi = new frmCB();
            this.Hide();
            formmoi.ShowDialog();
            this.Show();
        }

        private void btnexitform1_Click(object sender, EventArgs e) //Nút EXIT
        {
            Close();
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

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 750, WinAPI.BLEND);
        }

        
    }
}
