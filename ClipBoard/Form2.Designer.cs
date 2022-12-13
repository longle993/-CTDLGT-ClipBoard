
namespace ClipBoard
{
    partial class frmCB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtClipBoard = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblcb = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(73, 113);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(415, 468);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "Enter Text here...";
            // 
            // txtClipBoard
            // 
            this.txtClipBoard.BackColor = System.Drawing.SystemColors.Window;
            this.txtClipBoard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClipBoard.Location = new System.Drawing.Point(787, 113);
            this.txtClipBoard.Multiline = true;
            this.txtClipBoard.Name = "txtClipBoard";
            this.txtClipBoard.ReadOnly = true;
            this.txtClipBoard.Size = new System.Drawing.Size(415, 468);
            this.txtClipBoard.TabIndex = 6;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblText.Location = new System.Drawing.Point(221, 74);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(88, 36);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Text";
            // 
            // lblcb
            // 
            this.lblcb.AutoSize = true;
            this.lblcb.BackColor = System.Drawing.Color.Transparent;
            this.lblcb.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcb.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblcb.Location = new System.Drawing.Point(911, 74);
            this.lblcb.Name = "lblcb";
            this.lblcb.Size = new System.Drawing.Size(179, 36);
            this.lblcb.TabIndex = 5;
            this.lblcb.Text = "ClipBoard";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::ClipBoard.Properties.Resources.rsz_kisspng_kneaded_eraser_computer_icons_natural_rubber_rubbe_erase_5b46b4ab7e15644030505415313604275165;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(572, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 98);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "   Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEXIT.FlatAppearance.BorderSize = 0;
            this.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXIT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.ForeColor = System.Drawing.Color.Black;
            this.btnEXIT.Image = global::ClipBoard.Properties.Resources.rsz_computer_hardware_shutdown_icon;
            this.btnEXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXIT.Location = new System.Drawing.Point(572, 479);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(147, 98);
            this.btnEXIT.TabIndex = 3;
            this.btnEXIT.Text = "   EXIT";
            this.btnEXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.TextChanged += new System.EventHandler(this.btnEXIT_Click);
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.ForeColor = System.Drawing.Color.Black;
            this.btnPaste.Image = global::ClipBoard.Properties.Resources.rsz_748035;
            this.btnPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaste.Location = new System.Drawing.Point(572, 235);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(147, 98);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.Text = "   Paste";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.Image = global::ClipBoard.Properties.Resources.rsz_21621635;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.Location = new System.Drawing.Point(572, 113);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(147, 98);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "   Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblcb);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtClipBoard);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipBoard";
            this.Load += new System.EventHandler(this.frmCB_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGiaoDien_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGiaoDien_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmGiaoDien_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtClipBoard;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblcb;
        private System.Windows.Forms.Button btnClear;
    }
}